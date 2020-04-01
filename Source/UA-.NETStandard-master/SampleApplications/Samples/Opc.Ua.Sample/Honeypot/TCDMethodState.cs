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
 
using Opc.Ua;
using System.Collections.Generic;
using Opc.Ua.Honeypot;

namespace TCD
{
    /// <summary>
    /// Base class for OPC UA methods that can be invoked on Temperature Control Devices. 
    /// It associates a particular TCD with a method invocation, so the correct TCD can
    /// be acted upon. This class, and its subclasses, convert method calls on a TCD made 
    /// to the OPC Server into method calls on the class representing that TCD. 
    /// </summary>
    public class TCDMethodState : MethodState
    {
        public TCDMethodState(MethodState source) : base(source.Parent)
        {
            Initialize(new SystemContext(), source);
        }

        public void setSimulator(TCDSimulator simulator)
        {
            m_simulator = simulator;
        }

        protected TCDSimulator m_simulator = null;
    }

    /// <summary>
    /// OPC UA method to switch on a TCD.
    /// </summary>
    public class SwitchOnMethodState : TCDMethodState
    {
        public SwitchOnMethodState(MethodState source) : base(source)
        {
        }

        /// <summary>
        /// When the method is called, turn on the TCD.
        /// </summary>
        /// <param name="context">Not used.</param>
        /// <param name="objectId">Not used.</param>
        /// <param name="inputArguments">Not used.</param>
        /// <param name="outputArguments">Not used.</param>
        /// <returns>StatusCodes.Good iff the TCD is valid.</returns>
        protected override ServiceResult Call(
             ISystemContext context,
             NodeId objectId,
             IList<object> inputArguments,
             IList<object> outputArguments)
        {
            if (m_simulator != null)
            {
                m_simulator.SwitchOn(true);
                return StatusCodes.Good;
            }
            else
            {
                return StatusCodes.Bad;
            }
        }
    }

    /// <summary>
    /// OPC UA method to switch off a TCD.
    /// </summary>
    public class SwitchOffMethodState : TCDMethodState
    {
        public SwitchOffMethodState(MethodState source) : base(source)
        {
        }

        /// <summary>
        /// When the method is called, turn off the TCD.
        /// </summary>
        /// <param name="context">Not used.</param>
        /// <param name="objectId">Not used.</param>
        /// <param name="inputArguments">Not used.</param>
        /// <param name="outputArguments">Not used.</param>
        /// <returns>StatusCodes.Good iff the TCD is valid.</returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (m_simulator != null)
            {
                m_simulator.SwitchOff(true);
                return StatusCodes.Good;
            }
            else
            {
                return StatusCodes.Bad;
            }
        }
    }

    /// <summary>
    /// OPC UA method to reset the cooling subsystem periodic maintenance.
    /// </summary>
    public class ResetCoolingMaintenanceMethodState : TCDMethodState
    {
        public ResetCoolingMaintenanceMethodState(MethodState source) : base(source)
        {
        }

        /// <summary>
        /// When the method is called, reset the TCD cooling subsystem periodic maintenance. 
        /// </summary>
        /// <param name="context">Not used.</param>
        /// <param name="objectId">Not used.</param>
        /// <param name="inputArguments">Not used.</param>
        /// <param name="outputArguments">Not used.</param>
        /// <returns>StatusCodes.Good iff the TCD is valid.</returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (m_simulator != null)
            {
                m_simulator.ResetCoolingMaintenance(true);
                return StatusCodes.Good;
            }
            else
            {
                return StatusCodes.Bad;
            }
        }
    }

    /// <summary>
    /// OPC UA method to reset the heating subsystem periodic maintenance.
    /// </summary>
    public class ResetHeatingMethodState : TCDMethodState
    {
        public ResetHeatingMethodState(MethodState source) : base(source)
        {
        }

        /// <summary>
        /// When the method is called, reset the TCD heating subsystem periodic maintenance. 
        /// </summary>
        /// <param name="context">Not used.</param>
        /// <param name="objectId">Not used.</param>
        /// <param name="inputArguments">Not used.</param>
        /// <param name="outputArguments">Not used.</param>
        /// <returns>StatusCodes.Good iff the TCD is valid.</returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (m_simulator != null)
            {
                m_simulator.ResetHeatingMaintenance(true);
                return StatusCodes.Good;
            }
            else
            {
                return StatusCodes.Bad;
            }
        }
    }

    /// <summary>
    /// OPC UA method to reset all TCD errors. 
    /// </summary>
    public class ResetAllErrorsMethodState : TCDMethodState
    {
        public ResetAllErrorsMethodState(MethodState source) : base(source)
        {
        }

        /// <summary>
        /// When the method is called, reset all errors. 
        /// </summary>
        /// <param name="context">Not used.</param>
        /// <param name="objectId">Not used.</param>
        /// <param name="inputArguments">Not used.</param>
        /// <param name="outputArguments">Not used.</param>
        /// <returns>StatusCodes.Good iff the TCD is valid.</returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (m_simulator != null)
            {
                m_simulator.ResetAllErrors(true);
                return StatusCodes.Good;
            }
            else
            {
                return StatusCodes.Bad;
            }
        }
    }
}
