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
    /// Base class for operations that can be performed programatically on Temperature Control Devices. 
    /// Sequences of these operations are used to simulate activity on the TCDs. 
    /// </summary>
    abstract class TCDOperation
    {
        /// <summary>
        /// Get the time to wait until the operation is performed. 
        /// </summary>
        /// <returns>Time to wait, in minutes.</returns>
        public virtual double getWaitTime_min()
        {
            return 0;
        }

        /// <summary>
        /// Get a description of the operation. 
        /// </summary>
        /// <returns>The description.</returns>
        abstract public string getDescription();

        abstract public void ExecuteOn(TCDSimulator tcs);
    }

    /// <summary>
    /// Operation to do nothing for a bounded random time period. 
    /// </summary>
    class TCDWaitForOp : TCDOperation
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="minTime_min">The minimum time to wait (minutes)</param>
        /// <param name="maxTime_min">The maximum time to wait (minutes)</param>
        public TCDWaitForOp(double minTime_min, double maxTime_min)
        {
            m_MinTime_min = minTime_min;
            m_MaxTime_min = maxTime_min;
        }
        /// <summary>
        /// Because the whole purpose is to wait, when the wait is over it does nothing!
        /// </summary>
        /// <param name="tcs">The simulator that this operation should be executed on.</param>
        public override void ExecuteOn(TCDSimulator tcs)
        {
            // do nothing
        }
        public override string getDescription()
        {
            return String.Format("Wait for {0} to {1} minutes",Math.Round(m_MinTime_min), Math.Round(m_MaxTime_min));
        }

        /// <summary>
        /// Get the actual time to wait. This will be different each time the method is called. 
        /// </summary>
        /// <returns>Time to wait, in minutes.</returns>
        public override double getWaitTime_min()
        {
            return m_MinTime_min + m_Random.NextDouble() * (m_MaxTime_min - m_MinTime_min);
        }

        private double m_MinTime_min;
        private double m_MaxTime_min;
        private static Random m_Random = new Random();
    }

    /// <summary>
    /// Operation to turn the TCD on.
    /// </summary>
    class TCDSwitchOnOp : TCDOperation
    {
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SwitchOn(false);
        }
        public override string getDescription()
        {
            return "Power on";
        }
    }

    /// <summary>
    /// Operation to turn the TCD off.
    /// </summary>
    class TCDSwitchOffOp : TCDOperation
    {
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SwitchOff(false);
        }
        public override string getDescription()
        {
            return "Power off";
        }

    }

    /// <summary>
    /// Operation to open the TCD door (which raises an alarm and affects heating and cooling rates).
    /// </summary>
    class TCDOpenDoorOp : TCDOperation
    {
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.OpenDoor();
        }
        public override string getDescription()
        {
            return "Open door";
        }

    }

    /// <summary>
    /// Operation to close the TCD door (which affects heating and cooling rates).
    /// </summary>
    class TCDCloseDoorOp : TCDOperation
    {
       public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.CloseDoor();
        }
        public override string getDescription()
        {
            return "Close door";
        }

    }

    /// <summary>
    /// Operation to set the temperature set-point of the TCD. 
    /// </summary>
    class TCDSetTemperatureOp : TCDOperation
    {
        public TCDSetTemperatureOp(double setpoint_C) 
        {
            m_Setpoint_C = setpoint_C;
        }
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SetSetpoint(m_Setpoint_C, false);
        }

        public override string getDescription()
        {
            return String.Format("Set temperature to {0}C",m_Setpoint_C);
        }

        private double m_Setpoint_C;
    }

    /// <summary>
    /// OPeration to set the target temperature ramp-up time of the TCD.
    /// </summary>
    class TCDSetRampUpOp : TCDOperation
    {
        public TCDSetRampUpOp(double rate_CpMin)
        {
            m_Rate_CpMin = rate_CpMin;
        }
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SetRampUp(m_Rate_CpMin, false);
        }

        public override string getDescription()
        {
            return String.Format("Set ramp up rate to {0} C per minute ", m_Rate_CpMin);
        }

        private double m_Rate_CpMin;
    }

    /// <summary>
    /// Operation to set the target temperature ramp-down time of the TCD.
    /// </summary>
    class TCDSetRampDownOp : TCDOperation
    {
        public TCDSetRampDownOp(double rate_CpMin)
        {
            m_Rate_CpMin = rate_CpMin;
        }
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SetRampDown(m_Rate_CpMin, false);
        }

        public override string getDescription()
        {
            return String.Format("Set ramp down rate to {0} C per minute ", m_Rate_CpMin);
        }

        private double m_Rate_CpMin;
    }

    /// <summary>
    /// Operation to set the live load power operating inside the TCD. The live load power 
    /// affects the heating and cooling behaviour of the TCD.
    /// </summary>
    class TCDSetLoadPowerOp : TCDOperation
    {
        public TCDSetLoadPowerOp(double loadPower_W)
        {
            m_LoadPower_W = loadPower_W;
        }
        public override void ExecuteOn(TCDSimulator tcs)
        {
            tcs.SetLiveLoadPower(m_LoadPower_W);
        }

        public override string getDescription()
        {
            return String.Format("Set load power to {0}W", m_LoadPower_W);
        }

        private double m_LoadPower_W;
    }

    /// <summary>
    /// Operation to wait until a certain UTC time. This is used to start simulated operations 
    /// at a specific time of day.  
    /// </summary>
    class TCDWaitUntilOp : TCDOperation
    {
        public TCDWaitUntilOp(int hourUTC, int minuteUTC = 0)
        {
            m_HourUTC = hourUTC;
            m_MinuteUTC = minuteUTC;
        }

        public override double getWaitTime_min()
        {
            DateTime utc = DateTime.UtcNow;
            int nowPastMidnight_min = utc.Hour * 60 + utc.Minute;
            int duePastMidnight_min = m_HourUTC * 60 + m_MinuteUTC;
            int waitTime_min = duePastMidnight_min - nowPastMidnight_min;
            if (waitTime_min < 0)
            {
                waitTime_min += 24 * 60;
            }
            return waitTime_min;
         }

        public override void ExecuteOn(TCDSimulator tcs)
        {
            // do nothing
        }

        public override string getDescription()
        {
            return String.Format("Wait until {0,2:D2}:{1,2:D2} UTC", m_HourUTC, m_MinuteUTC);
        }

        private int m_HourUTC;
        private int m_MinuteUTC;
    }



}
