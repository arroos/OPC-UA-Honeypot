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
using System.Collections.Generic;
using System.Timers;
using TCD;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// A simple interface for classes that want to be notified when the state of a simulator changes.
    /// </summary>
    public interface SimulationListener
    {
        void Notify(TCDSimulator tcs);
    }

    /// <summary>
    /// Simulates a Temperature Control Device. The simulator is programmable so operations can be 
    /// sequenced in order to give more realistic looking data.
    /// </summary>
    public abstract class TCDSimulator
    {
        #region Constructor and Initialization
        public TCDSimulator()
        {
            m_UltimateSetPoint_C = m_AmbientTemp_C;
            m_CurrentSetPoint_C = m_AmbientTemp_C;
            m_ActualTemp_C = m_AmbientTemp_C;
            m_HoursOfOperation = (40 + m_Random.NextDouble() * 100) * 52 * 10;
            m_CoolingMaintenance = new TCDMaintenance(this, 2000);
            m_HeatingMaintenance = new TCDMaintenance(this, 5000);
            m_RandomEfficiency = 0.95 + 0.1 * m_Random.NextDouble();
            m_MinValue_C = GetMinTemperature_C();
            m_MaxValue_C = GetMaxTemperature_C();
            m_LowerTolerance_C = -5;
            m_UpperTolerance_C = 5;
        }

        /// <summary>
        /// Associate a logger with this simulator. Simulator events will be written to this logger.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public void SetLogger(HoneypotLogger logger)
        {
            m_Logger = logger;
        }
        #endregion

        #region Programming Methods

        /// <summary>
        /// Program the simulator to wait for a number of minutes before proceeding to the next operation.
        /// </summary>
        /// <param name="time_min">The number of minutes to wait for</param>
        public void ProgramWaitFor(double time_min)
        {
            m_Program.Add(new TCDWaitForOp(time_min, time_min));
        }

        /// <summary>
        /// Program the simulator to wait for a random time before proceeding to the next operation.
        /// </summary>
        /// <param name="minTime_min">The minimum number of minutes to wait for.</param>
        /// <param name="maxTime_min">The maximum number of minutes to wait for.</param>
        public void ProgramWaitFor(double minTime_min, double maxTime_min)
        {
            m_Program.Add(new TCDWaitForOp(minTime_min, maxTime_min));
        }

        /// <summary>
        /// Program the simulator to wait until a certain time of day. This can be used to synchronise
        /// activities with the workday. Time is UTC.
        /// </summary>
        /// <param name="hour">The hour to wait for</param>
        /// <param name="minute">The minute to wait for</param>
        public void ProgramWaitUntilUTC(int hour, int minute)
        {
            m_Program.Add(new TCDWaitUntilOp(hour, minute));
        }
        /// <summary>
        /// Program the simulator to switch the TCD on. 
        /// </summary>
        public void ProgramSwitchOn()
        {
            m_Program.Add(new TCDSwitchOnOp());
        }

        /// <summary>
        /// Program the simulator to switch the TCD off. 
        /// </summary>
        public void ProgramSwitchOff()
        {
            m_Program.Add(new TCDSwitchOffOp());
        }

        /// <summary>
        /// Program the simulator to open the chamber door, which increases heat transfer to ambient. 
        /// </summary>
        public void ProgramOpenDoor()
        {
            m_Program.Add(new TCDOpenDoorOp());
        }

        /// <summary>
        /// Program the simulator to close the chamber door, which reduces heat transfer to ambient. 
        /// </summary>
        public void ProgramCloseDoor()
        {
            m_Program.Add(new TCDCloseDoorOp());
        }

        /// <summary>
        /// Program the simulator to simulate a live load inside the chamber with the specified power.
        /// This adds additional heating and reduces the rate of cooling.
        /// </summary>
        public void ProgramSetLoadPower(double loadPower_W)
        {
            m_Program.Add(new TCDSetLoadPowerOp(loadPower_W));
        }

        /// <summary>
        /// Program the simulator to set the setpoint temperature of the TCD, degrees Celcius.
        /// </summary>
        /// <param name="temp_C">The desired setpoint temperature.</param>
        public void ProgramSetTemperature(double temp_C)
        {
            m_Program.Add(new TCDSetTemperatureOp(temp_C));
        }

        /// <summary>
        /// Program the simulator to set the ramp-up rate, which is the rate at which the temperature
        /// will be ramped up if it is below the set-point.
        /// </summary>
        /// <param name="rate_CpMin">The ramp rate, in degrees Celcius per minute.</param>
        public void ProgramSetRampUp(double rate_CpMin)
        {
            m_Program.Add(new TCDSetRampUpOp(rate_CpMin));
        }

        /// <summary>
        /// Program the simulator to set the ramp-down rate, which is the rate at which the temperature
        /// will be ramped down if it is above the set-point.
        /// </summary>
        /// <param name="rate_CpS">The ramp rate, in degrees Celcius per second.</param>
        public void ProgramSetRampDown(double rate_CpS)
        {
            m_Program.Add(new TCDSetRampDownOp(rate_CpS));
        }

        #endregion

        #region Simulation Control Methods

        /// <summary>
        /// Set the ambient temperature. This is the temperature that a TCD that is turned off will
        /// gravitate to. 
        /// </summary>
        /// <param name="ambientTemp_C"></param>
        public void SetAmbientTemp(double ambientTemp_C)
        {
            m_AmbientTemp_C = ambientTemp_C;
        }

        /// <summary>
        /// Set the timestep for simulation. TCD operating parameters such as actual temperature are
        /// recalculated at each timestep.
        /// </summary>
        /// <param name="timeStep_s">The interval between simulation timesteps, in seconds.</param>
        public void setTimeStep(double timeStep_s)
        {
            m_TimeStep_s = timeStep_s;
        }

        /// <summary>
        /// Set the speedup factor, which makes the simulation happen in faster than real time. For example,
        /// a speedup factor of 60 will simulate a minute of real time for every second of simulator activity.
        /// </summary>
        /// <param name="speedupFactor"></param>
        public void SetSpeedupFactor(double speedupFactor)
        {
            m_SpeedupFactor = speedupFactor;
        }

        /// <summary>
        /// Start the simulation running in the background, triggered by a timer. The initial timer delay is set
        /// to a random amount less than the timestep, so that if multiple simulators are started simultaneously
        /// thy won't all operate in lockstep.
        /// </summary>
        public void StartSimulation()
        {
            m_TimeRemaining_s = 0;
            m_ProgramCounter = m_Program.GetEnumerator();
            m_SimulationTimer.Elapsed += Tick;
            m_SimulationTimer.AutoReset = false;
            m_SimulationTimer.Interval = m_Random.NextDouble() * m_TimeStep_s * 1000 / m_SpeedupFactor;
            m_SimulationTimer.Start();
        }

        /// <summary>
        /// Add a listener that will be notified when the simulator state changes.
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(SimulationListener listener)
        {
            if (listener != null)
            {
                m_Listeners.Add(listener);
            }
        }
        #endregion

        #region TCD Control Methods
        /// <summary>
        /// Switch on the TCD.
        /// </summary>
        /// <param name="log">True iff this event should be logged.</param>
        public void SwitchOn(bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SwitchOn");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("WasOn", Entry.For(m_State != TCState.OFF));
                    m_Logger.Log(entry);
                }

                if (m_State == TCState.OFF)
                {
                    m_State = TCState.IDLE;
                    m_HasActiveErrorsChanged = true;
                }
            }
        }

        /// <summary>
        /// Switch off the TCD.
        /// </summary>
        /// <param name="log">True iff this event should be logged.</param>
        public void SwitchOff(bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SwitchOff");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("WasOn", Entry.For(m_State != TCState.OFF));
                    m_Logger.Log(entry);
                }

                if (m_State != TCState.OFF)
                {
                    m_State = TCState.OFF;
                    m_HasActiveErrorsChanged = true;
                }
            }
        }

        /// <summary>
        /// Reset the time period until cooling maintenance is due.
        /// </summary>
        /// <param name="log">True iff this event should be logged.</param>
        public void ResetCoolingMaintenance(bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("ResetCoolingMaintenance");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("RemainingInterval", Entry.For(CoolingMaintenance.RemainingInterval_Hrs));
                    m_Logger.Log(entry);
                }
                m_CoolingMaintenance.Reset();
            }
        }

        /// <summary>
        /// Reset the time period until heating maintenance is due.
        /// </summary>
        /// <param name="log">True iff this event should be logged.</param>
        public void ResetHeatingMaintenance(bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("ResetHeatingMaintenance");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("RemainingInterval", Entry.For(HeatingMaintenance.RemainingInterval_Hrs));
                    m_Logger.Log(entry);
                }
                m_HeatingMaintenance.Reset();
            }
        }

        /// <summary>
        /// Reset all TCD errors.
        /// </summary>
        /// <param name="log">True iff this event should be logged.</param>
        public void ResetAllErrors(bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("ResetAllErrors");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    m_Logger.Log(entry);
                }
                m_ActiveErrors.Clear();
                m_HasActiveErrorsChanged = true;
            }
        }

        /// <summary>
        /// Open the door. This increases the heatflow between the chamber and ambient, and raises a
        /// warning in the ActiveErrors array.
        /// </summary>
        public void OpenDoor()
        {
            lock (m_StateLock)
            {
                m_IsDoorOpen = true;
            }
        }

        /// <summary>
        /// Close the door. This decreases the heatflow between the chamber and ambient.
        /// </summary>
        public void CloseDoor()
        {
            lock (m_StateLock)
            {
                m_IsDoorOpen = false;
            }
        }

        /// <summary>
        /// Set the TCD temperature setpoint.
        /// </summary>
        /// <param name="setpoint_C">The desired setpoint, in degrees Centigrade.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetSetpoint(double setpoint_C, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetSetpoint");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldSetpoint", Entry.For(m_UltimateSetPoint_C));
                    entry.Add("NewSetpoint", Entry.For(setpoint_C));
                    m_Logger.Log(entry);
                }

                if (setpoint_C < GetMinTemperature_C())
                {
                    m_UltimateSetPoint_C = GetMinTemperature_C();
                }
                else if (setpoint_C > GetMaxTemperature_C())
                {
                    m_UltimateSetPoint_C = GetMaxTemperature_C();
                }
                else
                {
                    m_UltimateSetPoint_C = setpoint_C;
                }
                m_HasSetpointChanged = true;
            }
        }

        /// <summary>
        /// Set the TCD temperature ramp-up rate.
        /// </summary>
        /// <param name="rampUp_CpMin">The desired ramp rate, in degrees Centigrade per minute.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetRampUp(double rampUp_CpMin, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetRampUp");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldRampUp", Entry.For(m_RampUp_CpMin));
                    entry.Add("NewRampUp", Entry.For(rampUp_CpMin));
                    m_Logger.Log(entry);
                }

                if (rampUp_CpMin < 0)
                {
                    rampUp_CpMin = 0;
                }
                m_RampUp_CpMin = rampUp_CpMin;
                m_HasRampUpChanged = true;
            }
        }

        /// <summary>
        /// Set the TCD temperature ramp-down rate.
        /// </summary>
        /// <param name="rampUp_CpMin">The desired ramp rate, in degrees Centigrade per minute.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetRampDown(double rampDown_CpMin, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetRampDown");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldRampDown", Entry.For(m_RampDown_CpMin));
                    entry.Add("NewRampDown", Entry.For(rampDown_CpMin));
                    m_Logger.Log(entry);
                }
                if (rampDown_CpMin < 0)
                {
                    rampDown_CpMin = 0;
                }
                m_RampDown_CpMin = rampDown_CpMin;
                m_HasRampDownChanged = true;
            }
        }

        /// <summary>
        /// Set the lower temperature tolerance level relative to the temperature setpoint. An error will be
        /// raised if the temperature falls below this level. 
        /// </summary>
        /// <param name="lowerTolerance_C">Lower tolerance delta from setpoint, in degrees Centigrade.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetLowerTolerance(double lowerTolerance_C, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetLowerTolerance");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldLowerTolerance", Entry.For(m_LowerTolerance_C));
                    entry.Add("NewLowerTolerance", Entry.For(lowerTolerance_C));
                    m_Logger.Log(entry);
                }
                if (lowerTolerance_C > 0)
                {
                    lowerTolerance_C = -lowerTolerance_C;
                }
                m_LowerTolerance_C = lowerTolerance_C;
                m_HasLowerToleranceChanged = true;
            }
        }

        /// <summary>
        /// Set the upper temperature tolerance level relative to the temperature setpoint. An error will be
        /// raised if the temperature rises above this level.  
        /// </summary>
        /// <param name="upperTolerance_C">Upper tolerance delta from setpoint, in degrees Centigrade.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetUpperTolerance(double upperTolerance_C, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetUpperTolerance");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldUpperTolerance", Entry.For(m_UpperTolerance_C));
                    entry.Add("NewUpperTolerance", Entry.For(upperTolerance_C));
                    m_Logger.Log(entry);
                }
                if (upperTolerance_C < 0)
                {
                    upperTolerance_C = -upperTolerance_C;
                }
                m_UpperTolerance_C = upperTolerance_C;
                m_HasUpperToleranceChanged = true;
            }
        }

        /// <summary>
        /// Set an absolute minimum temperature value. An error will be raised if the termperature falls 
        /// below this level 
        /// </summary>
        /// <param name="minValue_C">The absolute minimum temperature, in degrees Centigrade.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetMinValue(double minValue_C, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetMinValue");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldMinValue", Entry.For(m_MinValue_C));
                    entry.Add("NewMinValue", Entry.For(minValue_C));
                    m_Logger.Log(entry);
                }
                if (minValue_C <= m_MaxValue_C)
                {
                    m_MinValue_C = minValue_C;
                }
                m_HasMinValueChanged = true;
            }
        }

        /// <summary>
        /// Set an absolute maximum temperature value. An error will be raised if the termperature rises 
        /// above this level 
        /// </summary>
        /// <param name="maxValue_C">The maximum value, in degrees Centigrade.</param>
        /// <param name="log"></param>
        public void SetMaxValue(double maxValue_C, bool log)
        {
            lock (m_StateLock)
            {
                if (log && m_Logger != null)
                {
                    LogEntry entry = new LogEntry("SetMaxValue");
                    entry.Add("SerialNo", Entry.For(SerialNumber));
                    entry.Add("OldMaxValue", Entry.For(m_MaxValue_C));
                    entry.Add("NewMaxValue", Entry.For(maxValue_C));
                    m_Logger.Log(entry);
                }
                if (maxValue_C >= m_MinValue_C)
                { 
                    m_MaxValue_C = maxValue_C;
                }
                m_HasMaxValueChanged = true;
            }
        }

        /// <summary>
        /// Set the live load power. The heat generated by the load affects temperature heating and cooling.
        /// </summary>
        /// <param name="loadPower_W">Live load power, in Watts.</param>
        public void SetLiveLoadPower(double loadPower_W)
        {
            m_LoadPower_W = loadPower_W;
        }

        /// <summary>
        /// Set the user machine name. 
        /// </summary>
        /// <param name="name">User machine name.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetUserMachineName(String name, bool log)
        {
            if (name != null)
            {
                lock (m_StateLock)
                {
                    if (log)
                    {
                        LogEntry entry = new LogEntry("SetUserMachineName");
                        entry.Add("OldName", Entry.For(m_UserMachineName));
                        entry.Add("NewName", Entry.For(name));
                        m_Logger.Log(entry);
                    }
                    m_UserMachineName = name;
                    m_HasUserMachineNameChanged = true;
                }
            }
        }

        /// <summary>
        /// Set the TCD location.
        /// </summary>
        /// <param name="location">The TCD location.</param>
        /// <param name="log">True iff this event should be logged.</param>
        public void SetLocationName(String location, bool log)
        {
            if (location != null)
            {
                lock (m_StateLock)
                {
                    if (log)
                    {
                        LogEntry entry = new LogEntry("SetLocation");
                        entry.Add("OldLocation", Entry.For(m_LocationName));
                        entry.Add("NewLocation", Entry.For(location));
                        m_Logger.Log(entry);
                    }
                    m_LocationName = location;
                    m_HasLocationNameChanged = true;
                }
            }
        }

        #endregion

        #region TCD Status Enquiry Methods
        public double GetSetpoint_C()
        {
            lock (m_StateLock)
            {
                return m_UltimateSetPoint_C;
            }
        }

        public double GetRampUp_CpMin()
        {
            lock (m_StateLock)
            {
                return m_RampUp_CpMin;
            }
        }

        public double GetRampDown_CpMin()
        {
            lock (m_StateLock)
            {
                return m_RampDown_CpMin;
            }
        }

        public double GetLowerTolerance_C()
        {
            lock (m_StateLock)
            {
                return m_LowerTolerance_C;
            }
        }

        public double GetUpperTolerance_C()
        {
            lock (m_StateLock)
            {
                return m_UpperTolerance_C;
            }
        }

        public double GetMinValue_C()
        {
            lock (m_StateLock)
            {
                return m_MinValue_C;
            }
        }

        public double GetMaxValue_C()
        {
            lock (m_StateLock)
            {
                return m_MaxValue_C;
            }
        }

        public double GetActualTemp_C()
        {
            lock (m_StateLock)
            {
                return Math.Round(m_ActualTemp_C, 1);
            }
        }

        public double GetHoursOfOperation()
        {
            return Math.Round(m_HoursOfOperation, 1);
        }

        public string GetOperatingMode()
        {
            lock (m_StateLock)
            {
                return (m_State == TCState.OFF ? "READY_TO_OPERATE_1" : "NORMAL_OPERATION_2");
            }
        }

        public ActiveErrorDataType[] GetActiveErrors()
        {
            lock (m_StateLock)
            {
                return m_ActiveErrors.ToArray();
            }
        }

        public string GetUserMachineName()
        {
            return m_UserMachineName;
        }

        public string GetLocationName()
        {
            return m_LocationName;
        }
        #endregion

        #region State-Change Indicators
        /// <summary>
        /// Indicates whether the setpoint has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasSetpointChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasSetpointChanged;
                m_HasSetpointChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the ramp up rate has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasRampUpChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasRampUpChanged;
                m_HasRampUpChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the ramp down rate has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasRampDownChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasRampDownChanged;
                m_HasRampDownChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the lower tolerance has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasLowerToleranceChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasLowerToleranceChanged;
                m_HasLowerToleranceChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the upper tolerance has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasUpperToleranceChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasUpperToleranceChanged;
                m_HasUpperToleranceChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the minimum permissible value has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasMinValueChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasMinValueChanged;
                m_HasMinValueChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates whether the maximum permissible value has changed since this method was last called. 
        /// </summary>
        /// <returns></returns>
        public Boolean HasMaxValueChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasMaxValueChanged;
                m_HasMaxValueChanged = false;
                return changed;
            }
        }

        /// <summary>
        /// Indicates that the door has been opened or closed since this method was last called.
        /// </summary>
        /// <returns></returns>
        public Boolean HasActiveErrorsChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasActiveErrorsChanged;
                m_HasActiveErrorsChanged = false;
                return changed;
            }
        }

        public Boolean HasUserMachineNameChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasUserMachineNameChanged;
                m_HasUserMachineNameChanged = false;
                return changed;
            }
        }

        public Boolean HasLocationNameChanged()
        {
            lock (m_StateLock)
            {
                bool changed = m_HasLocationNameChanged;
                m_HasLocationNameChanged = false;
                return changed;
            }
        }

        #endregion

        #region Public Properties
        public String SerialNumber { get; set; } = null;
        public uint DeviceMappingNumber { get; set; } = 0;
        public ushort TimeZoneOffset { get; set; } = 2;
        public bool DaylightSavingsInOffset { get; set; } = false;

        public TCDMaintenance CoolingMaintenance
        {
            get
            {
                lock (m_StateLock)
                {
                    return m_CoolingMaintenance;
                }
            }
        }

        public TCDMaintenance HeatingMaintenance
        {
            get
            {
                lock (m_StateLock)
                {
                    return m_HeatingMaintenance;
                }
            }
        }

        public String DeviceClass
        {
            get
            {
                return "Temperature Control Device";    // Specified by EUROMAP 82.1
            }
        }
        #endregion

        #region Abstract methods
        abstract public String GetManufacturer();
        abstract public String GetModel();
        abstract public double GetConnectedLoad();
        abstract public double GetMinTemperature_C();
        abstract public double GetMaxTemperature_C();
        abstract public double GetHeatingPower_W();
        abstract public double GetCoolingCapacity_W();
        abstract protected double GetBasePower_W();
        abstract protected double GetFlowClosed_WperC();
        abstract protected double GetFlowOpen_WperC();
        abstract protected double GetHeatCapacity_JperC();
        abstract protected double GetHysteresis_C();         
        #endregion

        #region Private methods
        /// <summary>
        /// This method is called by the operating system at regular intervals of m_TimeStep_s and executes a single simulation time step.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void Tick(Object source, System.Timers.ElapsedEventArgs e)
        {
            /// The initial timer interval is random to prevent multiple simulators from operating in lockstep. If this is the first tick,
            /// then reset it to the nominal timestep value.
            if (!m_SimulationTimer.AutoReset)
            {
                m_SimulationTimer.Interval = m_TimeStep_s * 1000 / m_SpeedupFactor;
                m_SimulationTimer.AutoReset = true;
                m_SimulationTimer.Enabled = true;
            }

            // Calculate TCD temperatures, set errors, etc.
            SimulatePhysics();

            // Execute any programmed operations for this simulator.
            ExecuteProgram();

            // Simulate the temperature control loop of the TCD.
            lock (m_StateLock)
            {
                if (m_State != TCState.OFF)
                {
                    SimulateController();
                }
            }

            // Advise any listeners that the TCD state has changed.
            NotifyListeners();
        }

        /// <summary>
        /// Calculate the new temperature based on heat flow into or out of the chamber, and set any
        /// errors caused by the TCD state.
        /// </summary>
        private void SimulatePhysics()
        {
            lock (m_StateLock)
            {
                double heatFlowIn_W = m_LoadPower_W + (m_AmbientTemp_C - m_ActualTemp_C) * (m_IsDoorOpen ? GetFlowOpen_WperC() : GetFlowClosed_WperC());
                switch (m_State)
                {
                    case TCState.HEATING:
                        heatFlowIn_W += GetHeatingPower_W();
                        break;
                    case TCState.COOLING:
                        heatFlowIn_W -= GetCoolingCapacity_W();
                        break;
                }
                m_ActualTemp_C += heatFlowIn_W * m_RandomEfficiency * m_TimeStep_s / GetHeatCapacity_JperC();

                SetActiveError(ERROR_DOOR_OPEN, m_IsDoorOpen);
                SetActiveError(ERROR_BELOW_TOLERANCE, m_ActualTemp_C < m_CurrentSetPoint_C + m_LowerTolerance_C);
                SetActiveError(ERROR_ABOVE_TOLERANCE, m_ActualTemp_C > m_CurrentSetPoint_C + m_UpperTolerance_C);
                SetActiveError(ERROR_BELOW_MINIMUM, m_ActualTemp_C < m_MinValue_C);
                SetActiveError(ERROR_ABOVE_MAXIMUM, m_ActualTemp_C > m_MaxValue_C);
            }
        }

        /// <summary>
        /// Execute any due programmed operations. 
        /// </summary>
        private void ExecuteProgram()
        {
            if (m_Program.Count > 0)
            {
                m_TimeRemaining_s -= m_TimeStep_s;
                while (m_TimeRemaining_s <= 0)
                {
                    while (!m_ProgramCounter.MoveNext())
                    {
                        m_ProgramCounter = m_Program.GetEnumerator();
                    }
                    m_ProgramCounter.Current.ExecuteOn(this);
                    m_TimeRemaining_s = m_ProgramCounter.Current.getWaitTime_min() * 60;
                }
            }
        }

        /// <summary>
        /// Simulate a simple controller for the TCD.
        /// </summary>
        private void SimulateController()
        {
            // Implement temperature ramp up / down. 
            if (m_CurrentSetPoint_C < m_UltimateSetPoint_C)
            {
                if (m_RampUp_CpMin == 0)
                {
                    m_CurrentSetPoint_C = m_UltimateSetPoint_C;
                }
                else
                {
                    m_CurrentSetPoint_C += m_RampUp_CpMin * m_TimeStep_s / 60;
                    if (m_CurrentSetPoint_C > m_UltimateSetPoint_C)
                    {
                        m_CurrentSetPoint_C = m_UltimateSetPoint_C;
                    }
                }
            }
            else if (m_CurrentSetPoint_C > m_UltimateSetPoint_C)
            {
                if (m_RampDown_CpMin == 0)
                {
                    m_CurrentSetPoint_C = m_UltimateSetPoint_C;
                }
                else
                {
                    m_CurrentSetPoint_C -= m_RampDown_CpMin * m_TimeStep_s / 60;
                    if (m_CurrentSetPoint_C < m_UltimateSetPoint_C)
                    {
                        m_CurrentSetPoint_C = m_UltimateSetPoint_C;
                    }
                }
            }

            // Simulate a tristate hysteresis chamber controller that can be heating, cooling, or idle.
            double delta_C = m_ActualTemp_C - m_CurrentSetPoint_C;
            switch (m_State)
            {
                case TCState.IDLE:
                    if (delta_C > GetHysteresis_C())
                    {
                        m_State = TCState.COOLING;
                    }
                    else if (delta_C < -GetHysteresis_C())
                    {
                        m_State = TCState.HEATING;
                    }
                    break;
                case TCState.HEATING:
                    if (delta_C > GetHysteresis_C() / 2)
                    {
                        m_State = TCState.IDLE;
                    }
                    break;
                case TCState.COOLING:
                    if (delta_C < -GetHysteresis_C() / 2)
                    {
                        m_State = TCState.IDLE;
                    }
                    break;
            }

            // Update hours of operation
            m_HoursOfOperation += m_TimeStep_s / 3600;
        }

        /// <summary>
        /// Notify listeners that the state of the TCD may have changed.
        /// </summary>
        private void NotifyListeners()
        {
            List<SimulationListener>.Enumerator listenerEnumerator = m_Listeners.GetEnumerator();
            while (listenerEnumerator.MoveNext())
            {
                listenerEnumerator.Current.Notify(this);
            }
        }

        /// <summary>
        /// Raise an error. It first checks whether the error has previously been set to avoid 
        /// setting the change flag if nothing has really changed.
        /// </summary>
        /// <param name="error">The new error.</param>
        /// <param name="active">True iff the error should be raised.</param>
        private void SetActiveError(ActiveErrorDataType error, bool active)
        {
            if (active && !m_ActiveErrors.Contains(error))
            {
                m_ActiveErrors.Add(error);
                m_HasActiveErrorsChanged = true;
            }           
        }
        #endregion

        #region Private data
        #region Type Definitions

        /// <summary>
        /// The operating state of the TCD.
        /// </summary>
        private enum TCState
        {
            OFF,
            IDLE,
            HEATING,
            COOLING
        };
        #endregion

        #region Programming 
        private List<TCDOperation> m_Program = new List<TCDOperation>();
        private List<TCDOperation>.Enumerator m_ProgramCounter;
        private double m_TimeRemaining_s;
        #endregion

        #region Simulation Control
        private Timer m_SimulationTimer = new Timer();
        private double m_TimeStep_s = 1;
        private double m_AmbientTemp_C = 24.1;
        private TCState m_State = TCState.OFF;
        private bool m_IsDoorOpen = false;
        private double m_LoadPower_W = 0;
        private double m_SpeedupFactor = 1.0;
        private double m_RandomEfficiency;
        #endregion

        #region TCD state
        private Object m_StateLock = new object();
        private double m_UltimateSetPoint_C;
        private double m_CurrentSetPoint_C;
        private double m_ActualTemp_C;
        private double m_HoursOfOperation;
        private double m_RampUp_CpMin = 0;
        private double m_RampDown_CpMin = 0;
        private double m_MinValue_C;
        private double m_MaxValue_C;
        private double m_LowerTolerance_C;
        private double m_UpperTolerance_C;
        private String m_LocationName;
        private String m_UserMachineName;
        #endregion

        #region Notification and Logging
        private List<SimulationListener> m_Listeners = new List<SimulationListener>();
        private Boolean m_HasSetpointChanged = true;
        private Boolean m_HasRampUpChanged = true;
        private Boolean m_HasRampDownChanged = true;
        private Boolean m_HasActiveErrorsChanged = true;
        private Boolean m_HasUserMachineNameChanged = true;
        private Boolean m_HasLocationNameChanged = true;
        private Boolean m_HasLowerToleranceChanged = true;
        private Boolean m_HasUpperToleranceChanged = true;
        private Boolean m_HasMinValueChanged = true;
        private Boolean m_HasMaxValueChanged = true;
        private List<ActiveErrorDataType> m_ActiveErrors = new List<ActiveErrorDataType>();
        private HoneypotLogger m_Logger;
        #endregion

        #region Maintenance
        TCDMaintenance m_CoolingMaintenance;
        TCDMaintenance m_HeatingMaintenance;
        #endregion

        #region Static data
        private static Random m_Random = new Random();

        private static ActiveErrorDataType ERROR_DOOR_OPEN = new SimulatorActiveError("W17", 400, "DOOR OPEN");
        private static ActiveErrorDataType ERROR_BELOW_TOLERANCE = new SimulatorActiveError("W26", 500, "TEMPERATURE BELOW TOLERANCE");
        private static ActiveErrorDataType ERROR_ABOVE_TOLERANCE = new SimulatorActiveError("W27", 500, "TEMPERATURE ABOVE TOLERANCE");
        private static ActiveErrorDataType ERROR_BELOW_MINIMUM = new SimulatorActiveError("E31", 700, "TEMPERATURE BELOW MINIMUM VALUE");
        private static ActiveErrorDataType ERROR_ABOVE_MAXIMUM = new SimulatorActiveError("E32", 700, "TEMPERATURE ABOVE MAXIMUM VALUE");
        #endregion
        #endregion
    }

    #region Subclasses representing particuar models of TCD
    class TenneyTC40C : TCDSimulator
    {
        public override String GetManufacturer() { return "Thermal Product Solutions LLC"; }
        public override String GetModel() { return "Tenney TC40C"; }
        public override double GetMinTemperature_C() { return -68; }
        public override double GetMaxTemperature_C() { return 180; }
        public override double GetConnectedLoad() { return 10.0; }
        public override double GetHeatingPower_W() { return 3000; }
        public override double GetCoolingCapacity_W() { return 2500; }
        protected override double GetBasePower_W() { return 68; }
        protected override double GetFlowClosed_WperC() { return 15; }
        protected override double GetFlowOpen_WperC() { return 150; }
        protected override double GetHeatCapacity_JperC() { return 79000; }
        protected override double GetHysteresis_C() { return 0.5; }
    }

    class TenneyTC10S : TCDSimulator
    {
        public override String GetManufacturer() { return "Thermal Product Solutions LLC"; }
        public override String GetModel() { return "Tenney TC10S"; }
        public override double GetMinTemperature_C() { return -35; }
        public override double GetMaxTemperature_C() { return 180; }
        public override double GetConnectedLoad() { return 7.0; }
        public override double GetHeatingPower_W() { return 3000; }
        public override double GetCoolingCapacity_W() { return 2300; }
        protected override double GetBasePower_W() { return 68; }
        protected override double GetFlowClosed_WperC() { return 10; }
        protected override double GetFlowOpen_WperC() { return 80; }
        protected override double GetHeatCapacity_JperC() { return 36300; }
        protected override double GetHysteresis_C() { return 1; }
    }
    
    class TenneyTC10C : TCDSimulator
    {
        public override String GetManufacturer() { return "Thermal Product Solutions LLC"; }
        public override String GetModel() { return "Tenney TC10C"; }
        public override double GetMinTemperature_C() { return -68; }
        public override double GetMaxTemperature_C() { return 180; }
        public override double GetConnectedLoad() { return 7.0; }
        public override double GetHeatingPower_W() { return 3000; }
        public override double GetCoolingCapacity_W() { return 2300; }
        protected override double GetBasePower_W() { return 68; }
        protected override double GetFlowClosed_WperC() { return 10; }
        protected override double GetFlowOpen_WperC() { return 80; }
        protected override double GetHeatCapacity_JperC() { return 36300; }
        protected override double GetHysteresis_C() { return 1; }
    }

    class TimeCompressorTC2: TCDSimulator
    {
        public override String GetManufacturer() { return "Cincinnati Sub-Zero Products LLC"; }
        public override String GetModel() { return "Time Compressor TC-2.0"; }
        public override double GetMinTemperature_C() { return -100; }
        public override double GetMaxTemperature_C() { return 200; }
        public override double GetConnectedLoad() { return 60.0; }
        public override double GetHeatingPower_W() { return 50000; }
        public override double GetCoolingCapacity_W() { return 50000; }
        protected override double GetBasePower_W() { return 68; }
        protected override double GetFlowClosed_WperC() { return 20; }
        protected override double GetFlowOpen_WperC() { return 150; }
        protected override double GetHeatCapacity_JperC() { return 40000; }
        protected override double GetHysteresis_C() { return 1; }
    }
    #endregion
}


