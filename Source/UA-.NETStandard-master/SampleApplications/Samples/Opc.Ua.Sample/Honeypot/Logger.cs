/* ========================================================================
 * Copyright 2019 Andrew Roos. 
 *
 * This file is part of the OPC UA Honeypot.
 *
 * The OPC UA Honeypot is free software: you can redistribute it and/or 
 * modify it under the terms of the GNU General Public License as published 
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The OPC UA Honeypot is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with the OPC UA Honeypot..  If not, see 
 * <https://www.gnu.org/licenses/>.
 * ======================================================================*/
 
using System;
using System.IO;
using System.Threading;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// Base class for honeypot loggers. The "write" method can be overridden to create a logger that 
    /// writes entries to a particular storage or transport medium.
    /// </summary>
    public abstract class HoneypotLogger
    {
        /// <summary>
        /// Record a log entry that has a secure channel context. The secure channel context includes 
        /// the IP address of the client. 
        /// </summary>
        /// <param name="entry">The log entry to record.</param>
        /// <param name="context">The secure channel context.</param>
        public void Log(LogEntry entry, SecureChannelContext context)
        {
            if (entry != null)
            {
                ObjectEntry withTimestamp = new ObjectEntry();
                withTimestamp.Add("Id", Entry.For(Interlocked.Increment(ref m_Id)));
                withTimestamp.Add("TimeLogged", Entry.For(DateTime.UtcNow));
                withTimestamp.Add(entry.getRequestName(), entry);
                if (context != null)
                {
                    withTimestamp.Add("Context", Entry.For(context));
                }
                write(withTimestamp.JsonText());
            }
        }

        /// <summary>
        /// Record a log entry that has no secure channel context, so the IP address of the client
        /// will not be recorded.
        /// </summary>
        /// <param name="entry">The entry to record.</param>
        public void Log(LogEntry entry)
        {
            Log(entry, null);
        }

        /// <summary>
        /// Write a log entry to a transport or storage medium. 
        /// </summary>
        /// <param name="entry">The log entry to write.</param>
        protected abstract void write(String entry);

        /// <summary>
        /// Record authentication information provided to the honeypot. This is not a separate OPC UA request,
        /// so it is not logged by LogIncomingRequest().
        /// </summary>
        /// <param name="username">The username supplied.</param>
        /// <param name="password">The password supplied.</param>
        /// <param name="accepted">Whether the username and password were accepted.</param>
        /// <param name="context">The secure channel context.</param>
        public void LogAuthInfo(string username, string password, bool accepted, SecureChannelContext context)
        {
            LogEntry entry = LogEntry.For(username, password, accepted);
            Log(entry, context);
        }

        /// <summary>
        /// Log an incoming OPC UA request. 
        /// </summary>
        /// <param name="incomingRequest">The OPC UA request.</param>
        public void LogIncomingRequest(IEndpointIncomingRequest incomingRequest)
        {
            if (incomingRequest != null)
            {
                LogEntry entry = LogEntry.For((dynamic)incomingRequest.Request);
                Log(entry, incomingRequest.SecureChannelContext);
            }
        }

        /// <summary>
        /// The ID of the last log entry recorded. 
        /// </summary>
        private static int m_Id = 0;
    }

    /// <summary>
    /// Writes log entries to a file, one per line. Each line is in JSON format, but the whole file is not valid JSON. 
    /// The file name is the UTC date, ISO format ("YYYY-MM-DD") with extension ".log".
    /// </summary>
    #region FileLogger
    public class FileLogger : HoneypotLogger
    {
        public FileLogger(string directoryPath)
        {
            m_directoryPath = directoryPath;
        }

        /// <summary>
        /// Write an entry to the log file. 
        /// </summary>
        /// <param name="entry">The entry to write.</param>
        protected override void write(String entry)
        {
            if (m_directoryPath != null)
            {
                String fullPath = Path.Combine(m_directoryPath, DateTime.UtcNow.ToString("yyyy-MM-dd\".log\""));
                lock (fileLock)
                {
                    using (StreamWriter writer = new StreamWriter(fullPath, true))
                    {
                        writer.WriteLine(entry);
                    }
                }
            }
        }

        private String m_directoryPath;
        private static readonly object fileLock = new object();
    }
    #endregion
}
