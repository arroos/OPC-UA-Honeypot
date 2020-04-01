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
using Opc.Ua;
using Opc.Ua.Honeypot;

namespace TCD
{

    public partial class TCD_InterfaceState : SimulationListener
    {
        /// <summary>
        /// Notification method that is called when the simulator state changes. 
        /// </summary>
        /// <param name="simulator"></param>
        public void Notify(TCDSimulator simulator)
        {
            m_deviceZone.SyncWith(simulator);
            m_identification.SyncWith(simulator);
            m_machineConfiguration.SyncWith(simulator);
            m_operation.SyncWith(simulator);
            m_tCDSpecification.SyncWith(simulator);
            ClearChangeMasks(new SystemContext(), true);
        }
    }

    /// <summary>
    /// Add functionality to the DeviceZoneState class generated from the information model by the model compiler. 
    /// Making this a partial class allows the information model to be recompiled without overwriting this code. 
    /// </summary>
    public partial class DeviceZoneState
    {

        /// <summary>
        /// Synchronise the DeviceZone information in the OPC UA information model with the current state of a 
        /// Temperature Control Device simulator. For read-write fields the synchronisation is bidirectional: if the 
        /// simulator indicates that the value has changed, then the OPC UA information model is updated; otherwise
        /// if the value in the information model is different from that in the simulator, then the simulator is
        /// upated with the new value. Read-only fields are updated from the simulator if the value has changed. 
        /// </summary>
        /// <param name="simulator">The simulator to sync with.</param>
        public void SyncWith(TCDSimulator simulator)
        {
            // Update Temperature.ActualValue.
            double actualTemp = simulator.GetActualTemp_C();
            if (!(m_temperature.ActualValue.Value is double) || (double) m_temperature.ActualValue.Value != actualTemp)
            {
                m_temperature.ActualValue.Value = actualTemp;
                if (m_temperature.ActualValue.EngineeringUnits == null) 
                {
                    m_temperature.ActualValue.EngineeringUnits = new PropertyState<EUInformation>(m_temperature.ActualValue);
                }
                m_temperature.ActualValue.EngineeringUnits.Value = new EUInformation("C", "Degrees Centigrade", @"http://www.opcfoundation.org/UA/units/un/cefact");
                m_temperature.ActualValue.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Synchronise Temperature.SetValue.
            double setpoint = simulator.GetSetpoint_C();
            if (simulator.HasSetpointChanged())
            {
                m_temperature.SetValue.Value = setpoint;
                m_temperature.SetValue.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.SetValue.Value is double && (double)m_temperature.SetValue.Value != setpoint)
            {
                simulator.SetSetpoint((double)m_temperature.SetValue.Value, true);
            }

            // Synchronise Temperature.SetRampUp.
            double rampUp = simulator.GetRampUp_CpMin();
            if (simulator.HasRampUpChanged())
            {
                m_temperature.SetRampUp.Value = rampUp;
                m_temperature.SetRampUp.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.SetRampUp.Value is double && (double)m_temperature.SetRampUp.Value != rampUp)
            {
                simulator.SetRampUp((double)m_temperature.SetRampUp.Value, true);
            }

            // Synchronise Temperature.SetRampDown.
            double rampDown = simulator.GetRampDown_CpMin();
            if (simulator.HasRampDownChanged())
            {
                m_temperature.SetRampDown.Value = rampDown;
                m_temperature.SetRampDown.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.SetRampDown.Value is double && (double)m_temperature.SetRampDown.Value != rampDown)
            {
                simulator.SetRampDown((double)m_temperature.SetRampDown.Value, true);
            }

            // Synchronise Temperature.LowerTolerance.
            double lowerTolerance = simulator.GetLowerTolerance_C();
            if (simulator.HasLowerToleranceChanged())
            {
                m_temperature.LowerTolerance.Value = lowerTolerance;
                m_temperature.LowerTolerance.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.LowerTolerance.Value is double && (double)m_temperature.LowerTolerance.Value != lowerTolerance)
            {
                simulator.SetLowerTolerance((double)m_temperature.LowerTolerance.Value, true);
            }

            // Synchroise Temperature.UpperTolerance.
            double upperTolerance = simulator.GetUpperTolerance_C();
            if (simulator.HasUpperToleranceChanged())
            {
                m_temperature.UpperTolerance.Value = upperTolerance;
                m_temperature.UpperTolerance.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.UpperTolerance.Value is double && (double)m_temperature.UpperTolerance.Value != upperTolerance)
            {
                simulator.SetUpperTolerance((double)m_temperature.UpperTolerance.Value, true);
            }

            // Synchronise Temperature.MinValue.
            double minValue = simulator.GetMinValue_C();
            if (simulator.HasMinValueChanged())
            {
                m_temperature.MinValue.Value = minValue;
                m_temperature.MinValue.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.MinValue.Value is double && (double)m_temperature.MinValue.Value != minValue)
            {
                simulator.SetMinValue((double)m_temperature.MinValue.Value, true);
            }

            // Synchronise Temperature.MaxValue.
            double maxValue = simulator.GetMaxValue_C();
            if (simulator.HasMaxValueChanged())
            {
                m_temperature.MaxValue.Value = maxValue;
                m_temperature.MaxValue.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_temperature.MaxValue.Value is double && (double)m_temperature.MaxValue.Value != maxValue)
            {
                simulator.SetMaxValue((double)m_temperature.MaxValue.Value, true);
            }

            if (m_maintenanceInformation != null)
            {
                // Synchronise MaintenanceInformation Cooling.
                if (m_maintenanceInformation.Cooling != null)
                {
                    m_maintenanceInformation.Cooling.SyncWith(simulator.CoolingMaintenance);
                    if (!(m_maintenanceInformation.Cooling.Reset is ResetCoolingMaintenanceMethodState))
                    {
                        ResetCoolingMaintenanceMethodState method = new ResetCoolingMaintenanceMethodState(m_maintenanceInformation.Cooling.Reset);
                        method.setSimulator(simulator);
                        m_maintenanceInformation.Cooling.Reset = method;
                    }
                }

                // Synchronise MaintenanceInformation Heating.
                if (m_maintenanceInformation.Heating != null)
                {
                    m_maintenanceInformation.Heating.SyncWith(simulator.HeatingMaintenance);
                    if (!(m_maintenanceInformation.Heating.Reset is ResetHeatingMethodState))
                    {
                        ResetHeatingMethodState method = new ResetHeatingMethodState(m_maintenanceInformation.Heating.Reset);
                        method.setSimulator(simulator);
                        m_maintenanceInformation.Heating.Reset = method;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Synchronise the MachineConfiguration information in the OPC UA information model with the current state of
    /// a Temperature Control Device simulator. For read-write fields the synchronisation is bidirectional: if the 
    /// simulator indicates that the value has changed, then the OPC UA information model is updated; otherwise
    /// if the value in the information model is different from that in the simulator, then the simulator is
    /// upated with the new value. Read-only fields are updated from the simulator if the value has changed. 
    /// </summary>
    public partial class MachineConfigurationState
    {
        public void SyncWith(TCDSimulator simulator)
        {
            // Synchronise UserMachineName.
            string machineName = simulator.GetUserMachineName();
            if (simulator.HasUserMachineNameChanged())
            {
                m_userMachineName.Value = machineName;
                m_userMachineName.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_userMachineName.Value is string && (string)m_userMachineName.Value != machineName)
            {
                simulator.SetUserMachineName((string)m_userMachineName.Value, true);
            }

            // Synchronise LocationName.
            string locationName = simulator.GetLocationName();
            if (simulator.HasLocationNameChanged())
            {
                m_locationName.Value = locationName;
                m_locationName.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            else if (m_locationName.Value is string && (string)m_locationName.Value != locationName)
            {

                simulator.SetLocationName((string)m_locationName.Value, true);
            }

            // Update TimeZoneOffset.
            if (m_timeZoneOffset.Value == null)
            {
                m_timeZoneOffset.Value = new TimeZoneDataType();
                m_timeZoneOffset.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            if (m_timeZoneOffset.Value.offset != simulator.TimeZoneOffset)
            {
                m_timeZoneOffset.Value.offset = simulator.TimeZoneOffset;
                m_timeZoneOffset.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            if (m_timeZoneOffset.Value.daylightSavingInOffset != simulator.DaylightSavingsInOffset)
            {
                m_timeZoneOffset.Value.daylightSavingInOffset = simulator.DaylightSavingsInOffset;
                m_timeZoneOffset.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
        }
    }

    /// <summary>
    /// Synchronise the Operation information in the OPC UA information model with the current state of a 
    /// Temperature Control Device simulator. For read-write fields the synchronisation is bidirectional: if the 
    /// simulator indicates that the value has changed, then the OPC UA information model is updated; otherwise
    /// if the value in the information model is different from that in the simulator, then the simulator is
    /// upated with the new value. Read-only fields are updated from the simulator if the value has changed. 
    /// </summary>
    public partial class OperationState
    { 
        public void SyncWith(TCDSimulator simulator)
        {
            // Update HoursOfOperation. 
            double hoursOfOperation = simulator.GetHoursOfOperation();
            if (!(m_hoursOfOperation.Value is double) || (double) m_hoursOfOperation.Value != hoursOfOperation)
            {
                m_hoursOfOperation.Value = hoursOfOperation;
                m_hoursOfOperation.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update DeviceMappingNumber.
            if (m_deviceMappingNumber.Value != simulator.DeviceMappingNumber)
            {
                m_deviceMappingNumber.Value = simulator.DeviceMappingNumber;
                m_deviceMappingNumber.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update OperatingMode.
            if (!String.Equals(m_operatingMode.Value, simulator.GetOperatingMode()))
            {
                m_operatingMode.Value = simulator.GetOperatingMode();
                m_operatingMode.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // If the SwitchOn method has been invoked replace the generated method state with
            // one that will switch on this TCD.
            if (!(m_switchOnMethod is SwitchOnMethodState))
            {
                SwitchOnMethodState method = new SwitchOnMethodState(m_switchOnMethod);
                method.setSimulator(simulator);
                m_switchOnMethod = method;
            }

            // If the SwitchOff method has been invoked replace the generated method state with
            // one that will switch off this TCD.
            if (!(m_switchOffMethod is SwitchOffMethodState))
            {
                SwitchOffMethodState method = new SwitchOffMethodState(m_switchOffMethod);
                method.setSimulator(simulator);
                m_switchOffMethod = method;
            }

            // If the ResetAllErrors method has been invoked, then replace the generated 
            // method state with one that will reset errors for this TCD.
            if (!(m_resetAllErrorsMethod is ResetAllErrorsMethodState))
            {
                ResetAllErrorsMethodState method = new ResetAllErrorsMethodState(m_resetAllErrorsMethod);
                method.setSimulator(simulator);
                m_resetAllErrorsMethod = method;
            }

            // Update ActiveErrors.
            if (m_activeErrors.Value == null || simulator.HasActiveErrorsChanged())
            {
                m_activeErrors.Value = simulator.GetActiveErrors();
                m_highestActiveAlarmSeverity.Value = 0;
                for (int errorIndex=0; errorIndex< m_activeErrors.Value.Length; errorIndex++)
                {
                    if (m_activeErrors.Value[errorIndex].Severity > m_highestActiveAlarmSeverity.Value)
                    {
                        m_highestActiveAlarmSeverity.Value = m_activeErrors.Value[errorIndex].Severity;
                    }
                }
                m_activeErrors.UpdateChangeMasks(NodeStateChangeMasks.Value);
                m_highestActiveAlarmSeverity.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
        }
    }

    /// <summary>
    /// Synchronise the Specification information in the OPC UA information model with the current state of a 
    /// Temperature Control Device simulator. These elements do not change, but must still be updated from
    /// the simulator on start-up.
    /// </summary>
    public partial class TCDSpecificationState
    {
        public void SyncWith(TCDSimulator simulator)
        {
            // Update ConnectedLoad.
            double connectedLoad = simulator.GetConnectedLoad();
            if (!(m_connectedLoad.Value is double) || (double) m_connectedLoad.Value != connectedLoad)
            {
                m_connectedLoad.Value = connectedLoad;
                m_connectedLoad.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update CoolingCapacity.
            double coolingCapacity = simulator.GetCoolingCapacity_W() / 1000.0;
            if (!(m_coolingCapacity.Value is double) || (double)m_coolingCapacity.Value != connectedLoad)
            {
                m_coolingCapacity.Value = coolingCapacity;
                m_coolingCapacity.EngineeringUnits = new PropertyState<EUInformation>(m_coolingCapacity);
                m_coolingCapacity.EngineeringUnits.Value = new EUInformation("W", "uri");
                m_coolingCapacity.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update MaxTemperature
            double maxTemperature = simulator.GetMaxTemperature_C();
            if (!(m_maxTemperature.Value is double) || (double)m_maxTemperature.Value != maxTemperature)
            {
                m_maxTemperature.Value = maxTemperature;
                m_maxTemperature.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update MinTemperature
            double minTemperature = simulator.GetMinTemperature_C();
            if (!(m_minTemperature.Value is double) || (double)m_minTemperature.Value != minTemperature)
            {
                m_minTemperature.Value = minTemperature;
                m_minTemperature.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update PowerValue
            double power = simulator.GetHeatingPower_W() / 1000.0;
            if (!(m_powerValue.Value is double) || (double)m_powerValue.Value != minTemperature)
            {
                m_powerValue.Value = power;
                m_powerValue.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
        }
    }

    /// <summary>
    /// Synchronise the Identification information in the OPC UA information model with the current state of a 
    /// Temperature Control Device simulator. These elements do not change, but must still be updated from
    /// the simulator on start-up.
    /// </summary>
    public partial class IdentificationState
    {
        public void SyncWith(TCDSimulator simulator)
        {
            // Update DeviceClass.
            if (!String.Equals(m_deviceClass.Value, simulator.DeviceClass))
            {
                m_deviceClass.Value = simulator.DeviceClass;
                m_deviceClass.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
            
            // Update Manufacturer.
            if (!String.Equals(m_manufacturer.Value, simulator.GetManufacturer()))
            {
                m_manufacturer.Value = simulator.GetManufacturer();
                m_manufacturer.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update Model.
            if (!String.Equals(m_model.Value, simulator.GetModel()))
            {
                m_model.Value = simulator.GetModel();
                m_model.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update SerialNumber.
            if (!String.Equals(m_serialNumber.Value, simulator.SerialNumber))
            {
                m_serialNumber.Value = simulator.SerialNumber;
                m_serialNumber.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
        }
    }

    /// <summary>
    /// Update the Maintenance information in the OPC UA information model to reflect the current state of a 
    /// Temperature Control Device simulator. 
    /// </summary>
    public partial class MaintenanceState
    {
        public void SyncWith(TCDMaintenance maintenance)
        {
            // Update Interval.
            if (!(m_interval.Value is double) || (double)m_interval.Value != maintenance.Interval_Hrs)
            {
                m_interval.Value = maintenance.Interval_Hrs;
                m_interval.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update RemainingInterval.
            if (!(m_remainingInterval.Value is double) || (double)m_remainingInterval.Value != maintenance.RemainingInterval_Hrs)
            {
                m_remainingInterval.Value = maintenance.RemainingInterval_Hrs;
                m_remainingInterval.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }

            // Update Status.
            if (!String.Equals(m_status.Value, maintenance.Status))
            {
                m_status.Value = maintenance.Status;
                m_status.UpdateChangeMasks(NodeStateChangeMasks.Value);
            }
        }
    }

}
