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

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// A class that represents a maintenance requirement for a Temperature Control Device. Each maintenance 
    /// requirement has a nmber of hours until due. This class tracks the number of hours remaining, and 
    /// generates a staus string that is displayed in the TCD information model. 
    /// </summary>
    public class TCDMaintenance
    {
        public TCDMaintenance(TCDSimulator parent, double interval_Hrs)
        {
            m_Parent = parent;
            m_Interval_Hrs = interval_Hrs;
            m_NextDue_Hrs = m_Parent.GetHoursOfOperation() + m_Random.NextDouble() * interval_Hrs; 
        }

        public double RemainingInterval_Hrs
        {
            get
            {
                return Math.Round(Math.Max(m_NextDue_Hrs - m_Parent.GetHoursOfOperation(), 0), 1);
            }
        }

        public String Status
        {
            get
            {
                // If we have past the time at which maintenance was scheduled, then reset the maintenance status.
                if (m_ScheduledAt != 0 && m_Parent.GetHoursOfOperation() >= m_ScheduledAt)
                {
                    Reset();
                }

                if (RemainingInterval_Hrs == 0)
                {
                    // Maintenance is due. Schedule it for some time in the next 24 hours. 
                    if (m_ScheduledAt == 0)
                    {
                        m_ScheduledAt = m_Parent.GetHoursOfOperation() + m_Random.NextDouble() * 24;
                    }
                    return "DUE_2";
                }
                else if (RemainingInterval_Hrs <= 200)
                {
                    return "WARNING_1";
                }
                else
                {
                    return "NOT_DUE_0";
                }
            }
        }

        public double Interval_Hrs
        {
            get
            {
                return m_Interval_Hrs;
            }
        }

        public void Reset()
        {
            m_NextDue_Hrs = m_Parent.GetHoursOfOperation() + Interval_Hrs;
            m_ScheduledAt = 0;
        }

        private TCDSimulator m_Parent;
        private double m_Interval_Hrs;
        private double m_NextDue_Hrs;
        private static Random m_Random = new Random();
        private double m_ScheduledAt = 0;
    }
}
