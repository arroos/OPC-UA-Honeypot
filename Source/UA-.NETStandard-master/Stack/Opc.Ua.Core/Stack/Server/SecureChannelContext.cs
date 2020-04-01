/* Copyright (c) 1996-2019 The OPC Foundation. All rights reserved.
   The source code in this file is covered under a dual-license scenario:
     - RCL: for OPC Foundation members in good-standing
     - GPL V2: everybody else
   RCL license terms accompanied with this source code. See http://opcfoundation.org/License/RCL/1.00/
   GNU General Public License as published by the Free Software Foundation;
   version 2 of the License are accompanied with this source code. See http://opcfoundation.org/License/GPLv2
   This source code is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/

/* ======================================================================
 * Modified 2019 by Andrew Roos to include private members for remote 
 * IP address and port, and to allow these to be set by the constructor 
 * and accessed by new get methods. 
 * ======================================================================*/

using System.Threading;
using System.Net;           // HONEYPOT

namespace Opc.Ua
{
    /// <summary>
    /// Stores context information for the current secure channel.
    /// </summary>
    public class SecureChannelContext
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance with the specified property values.
        /// </summary>
        /// <param name="secureChannelId">The secure channel identifier.</param>
        /// <param name="endpointDescription">The endpoint description.</param>
        /// <param name="messageEncoding">The message encoding.</param>
        public SecureChannelContext(
            string              secureChannelId,
            EndpointDescription endpointDescription,
            RequestEncoding     messageEncoding,
            IPAddress           remoteIP,       // HONEYPOT
            int                 remotePort)     // HONEYPOT
        {        
            m_secureChannelId     = secureChannelId;
            m_endpointDescription = endpointDescription;
            m_messageEncoding     = messageEncoding;
            m_remoteIP            = remoteIP;   // HONEYPOT
            m_remotePort          = remotePort; // HONEYPOT      
           
        }

        /// <summary>
        /// Initializes a new instance with the context for the current thread.
        /// </summary>
        protected SecureChannelContext()
        {        
            SecureChannelContext context = SecureChannelContext.Current;

            if (context != null)
            {
                m_secureChannelId     = context.SecureChannelId;
                m_endpointDescription = context.EndpointDescription;
                m_messageEncoding     = context.MessageEncoding;
                m_remoteIP            = context.m_remoteIP;
            }
        }
        #endregion
                
        #region Public Properties
        /// <summary>
        /// TThe unique identifier for the secure channel.
        /// </summary>
        /// <value>The secure channel identifier.</value>
        public string SecureChannelId
        {
            get { return m_secureChannelId; }
        }

        /// <summary>
        /// The description of the endpoint used with the channel.
        /// </summary>
        /// <value>The endpoint description.</value>
        public EndpointDescription EndpointDescription
        {
            get { return m_endpointDescription; }
        }

        /// <summary>
        /// The encoding used with the channel.
        /// </summary>
        /// <value>The message encoding.</value>
        public RequestEncoding MessageEncoding
        {
            get { return m_messageEncoding; }
        }

        /// <summary>
        /// HONEYPOT - return the remote (client) IP address
        /// </summary>
        public IPAddress RemoteIP
        {
            get { return m_remoteIP; }
        }

        /// <summary>
        /// HONEYPOT - return the remote (client) port
        /// </summary>
        public int RemotePort
        {
            get { return m_remotePort; }
        }


        #endregion

        #region Static Members
        /// <summary>
        /// The active secure channel for the thread.
        /// </summary>
        /// <value>The current secure channel context.</value>
        public static SecureChannelContext Current        
        {
            get
            {
                return s_Dataslot.Value;
            }

            set
            {
                s_Dataslot.Value = value;
            }
        }
        #endregion

        #region Private Fields
        private string m_secureChannelId;
        private EndpointDescription m_endpointDescription;
        private RequestEncoding m_messageEncoding;
        private IPAddress m_remoteIP;
        private int m_remotePort;
        private static ThreadLocal<SecureChannelContext> s_Dataslot = new ThreadLocal<SecureChannelContext>();
        #endregion
    }

    /// <summary>
    /// The message encoding used with a request.
    /// </summary>
    public enum RequestEncoding
    {
        /// <summary>
        /// The request used the UA binary encoding.
        /// </summary>
        Binary,

        /// <summary>
        /// The request used the UA XML encoding.
        /// </summary>
        Xml
    }
}
