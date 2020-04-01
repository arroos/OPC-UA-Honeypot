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

using System.Collections.Generic;
using Opc.Ua;
using Opc.Ua.Sample;
using System.Reflection;
using Opc.Ua.Honeypot;
using System.Text;
using System;
using System.IO;

namespace TCD
{
    /// <summary>
    /// Manage Temperature Control Device nodes in the honeypot.
    /// </summary>
    public class TCDNodeManager : SampleNodeManager
    {
        #region Constructor and Factory Method
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public TCDNodeManager(
            Opc.Ua.Server.IServerInternal server, 
            ApplicationConfiguration configuration,
            HoneypotLogger logger)
        :
            base(server)
        {
            List<string> namespaceUris = new List<string>();
            namespaceUris.Add(Namespaces.TCD);
            namespaceUris.Add(Namespaces.TCD + "/Instance");
            NamespaceUris = namespaceUris;

            m_TypeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
            m_NamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);
            m_Logger = logger;
            m_LastUsedId = 0;

            m_ReecordTimer = new System.Timers.Timer();
            m_ReecordTimer.Elapsed += RecordTemperatures;
            m_ReecordTimer.AutoReset = true;
            m_ReecordTimer.Interval = 1 * 60 * 1000;
            m_ReecordTimer.Start();
        }

        /// <summary>
        /// Append the simulated temperatures of the Temperature Control Devices to a file. 
        /// The filename is hard-coded in the method. 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="eventArgs"></param>
        private void RecordTemperatures(Object source, System.Timers.ElapsedEventArgs eventArgs)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.UtcNow.ToString("yyyy-MM-dd,HH:mm:ss"));
            List<TCDSimulator>.Enumerator e = m_Simulators.GetEnumerator();
            while (e.MoveNext())
            {
                sb.AppendFormat(",{0:0.0},{1:0.0}", e.Current.GetSetpoint_C(), e.Current.GetActualTemp_C());
            }
            using (StreamWriter writer = new StreamWriter(@"C:\var\log\hp\temperature.csv", true))
            {
                try
                {
                    writer.WriteLine(sb.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception writing temperatures:");
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Create a simulator for a specific TCD_Interface node name. 
        /// </summary>
        /// <param name="nodeName">The simulator, or null if the node name is not found.</param>
        /// <returns></returns>
        private TCDSimulator CreateSimulatorForNode(TCD_InterfaceState node)
        {
            string nodeName = node.DisplayName.ToString();
            if (string.Equals(nodeName, "TCD_TPS_30293_02"))
            {
                TCDSimulator chamber = new TenneyTC40C();
                chamber.SetLocationName("RCD-PROD-T1", false);
                chamber.SetUserMachineName("EC-TC40C-01", false);
                chamber.SerialNumber = "30293-02";
                chamber.DeviceMappingNumber = 101;

                // MIL-STD-810F "Basic Hot" temperature cycle
                chamber.ProgramWaitUntilUTC(6, 7);      // Wait until 06h07 UTC
                chamber.ProgramSetRampUp(1);            // Set the target ramp-up rate to 1 deg. C per minute
                chamber.ProgramSetRampDown(1);          // Set the target ramp-down rate to 1 deg. C per minute      
                chamber.ProgramSwitchOn();              // Turn the chamber ON
                chamber.ProgramSetTemperature(33);      // Set the temperature set-point to 33 deg. C. 
                chamber.ProgramWaitFor(120);            // Wait for 120 min.
                chamber.ProgramSetTemperature(32);      // Set the temperature set-point to 32 deg. C.
                chamber.ProgramWaitFor(120);            // Wait for 120 min.
                chamber.ProgramSetTemperature(31);      // Set the temperature set-point to 31 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min.
                chamber.ProgramSetTemperature(30);      // Set the temperature set-point to 30 deg. C.
                chamber.ProgramWaitFor(0, 10);          // Wait for a random period of 0 to 10 min. 
                chamber.ProgramOpenDoor();              // Open the chamber door.
                chamber.ProgramWaitFor(20,30);          // Wait for between 20 and 30 min. 
                chamber.ProgramCloseDoor();             // Close the chamber door.
                chamber.ProgramWaitFor(90);             // Wait for 90 min. 
                chamber.ProgramSetTemperature(31);      // Set the temperature set-point to 31 deg. C.  
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(34);      // Set the temperature set-point to 34 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(37);      // Set the temperature set-point to 37 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(39);      // Set the temperature set-point to 39 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(41);      // Set the temperature set-point to 41 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(42);      // Set the temperature set-point to 42 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(43);      // Set the temperature set-point to 43 deg. C.
                chamber.ProgramWaitFor(300);            // Wait for 300 min. 
                chamber.ProgramSetTemperature(42);      // Set the temperature set-point to 42 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(40);      // Set the temperature set-point to 40 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(38);      // Set the temperature set-point to 38 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(36);      // Set the temperature set-point to 36 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(35);      // Set the temperature set-point to 35 deg. C.
                chamber.ProgramWaitFor(60);             // Wait for 60 min. 
                chamber.ProgramSetTemperature(34);      // Set the temperature set-point to 34 deg. C.
                return chamber;
            }
            else if (string.Equals(nodeName, "TCD_TPS_22507_03"))
            {
                TCDSimulator chamber = new TenneyTC40C();
                chamber.SetLocationName("RCD-PROD-T2", false);
                chamber.SetUserMachineName("EC-TC40C-02", false);
                chamber.SerialNumber = "22507-03";
                chamber.DeviceMappingNumber = 102;

                // MIL-STD-810F "typical test cycle" for airborne equipment, repeated twice a day.
                chamber.ProgramWaitUntilUTC(5, 0);
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(10, 20);
                chamber.ProgramCloseDoor();
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(300);
                chamber.ProgramSetTemperature(60);
                chamber.ProgramWaitFor(60);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(300);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(30);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(10, 20);
                chamber.ProgramCloseDoor();
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(300);
                chamber.ProgramSetTemperature(60);
                chamber.ProgramWaitFor(60);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(300);
                chamber.ProgramSwitchOff();

                return chamber;
            }
            else if (string.Equals(nodeName, "TCD_TPS_13502_21"))
            {
                TCDSimulator chamber = new TenneyTC10S();
                chamber.SetLocationName("RCD-PROD-T1", false);
                chamber.SetUserMachineName("EC-T10S-01", false);
                chamber.SerialNumber = "13502-21";
                chamber.DeviceMappingNumber = 103;

                // Constant +71 deg. C, with door being opened and closed during business hours.
                chamber.ProgramSetRampUp(1);
                chamber.ProgramSetRampDown(1);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitUntilUTC(6, 0);
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();

                return chamber;
            }
            else if (string.Equals(nodeName, "TCD_TPS_11090_24"))
            {
                TCDSimulator chamber = new TenneyTC10S();
                chamber.SetLocationName("RCD-PROD-T2", false);
                chamber.SetUserMachineName("EC-TC10S-03", false);
                chamber.SerialNumber = "11090-24";
                chamber.DeviceMappingNumber = 104;

                // Constant +51 deg. C, with door being opened and closed during business hours.
                chamber.ProgramSetRampUp(1);
                chamber.ProgramSetRampDown(1);
                chamber.ProgramSetTemperature(51);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitUntilUTC(6, 0);
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(30, 60);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();

                return chamber;
            }
            else if (string.Equals(nodeName, "TCD_TPS_26179_06"))
            {
                TCDSimulator chamber = new TenneyTC10C();
                chamber.SetLocationName("RCD-PROD-T1", false);
                chamber.SetUserMachineName("EC-TC10C-03", false);
                chamber.SerialNumber = "26179-06";
                chamber.DeviceMappingNumber = 105;

                // Constant -40 deg. C, with door being opened and closed during business hours.
                chamber.ProgramSetRampUp(1);
                chamber.ProgramSetRampDown(1);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitUntilUTC(6, 0);
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(60, 120);
                chamber.ProgramOpenDoor();
                chamber.ProgramWaitFor(0, 10);
                chamber.ProgramCloseDoor();

                return chamber;
            }
            else if (string.Equals(nodeName, "TCD_CSZ_103521"))
            {
                TCDSimulator chamber = new TimeCompressorTC2();
                chamber.SetLocationName("RCD-PROD-HASS", false);
                chamber.SetUserMachineName("EC-TC20-01", false);
                chamber.SerialNumber = "103521";
                chamber.DeviceMappingNumber = 106;

                // Simulated Highly Accelerated Stress Screening cycle during office hours.

                chamber.ProgramWaitUntilUTC(6, 0);
                chamber.ProgramWaitFor(0, 15);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                chamber.OpenDoor();
                chamber.ProgramWaitFor(5, 10);
                chamber.ProgramCloseDoor();
                chamber.ProgramWaitFor(1, 2);
                chamber.ProgramSetTemperature(-60);
                chamber.ProgramSwitchOn();
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(120);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(71);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(-40);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSetTemperature(23);
                chamber.ProgramWaitFor(10);
                chamber.ProgramSwitchOff();
                chamber.ProgramWaitFor(0, 2);

                return chamber;
            }

            else
            {
                return null;
            }
        }

        #endregion

        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="node">The node.</param>
        /// <returns>The new NodeId.</returns>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            uint id = Utils.IncrementIdentifier(ref m_LastUsedId);
            return new NodeId(id, m_NamespaceIndex);
        }
        #endregion

        #region INodeManager Members
        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context, "Opc.Ua.Sample.TCD.TCD.PredefinedNodes.uanodes", this.GetType().GetTypeInfo().Assembly, true);
            return predefinedNodes;
        }

        /// <summary>
        /// Bind each TCD_Interface node to separate TCDSimulator.
        /// </summary>
        protected override NodeState AddBehaviourToPredefinedNode(ISystemContext context, NodeState predefinedNode)
        {
            BaseObjectState passiveNode = predefinedNode as BaseObjectState;
            if (passiveNode != null)
            {
                NodeId typeId = passiveNode.TypeDefinitionId;
                if (IsNodeIdInNamespace(typeId) && typeId.IdType == IdType.Numeric && (uint)typeId.Identifier == ObjectTypes.TCD_Interface)
                {
                    // Found a TCD_Interface. If it is not already an active node, then replace it with one.
                    TCD_InterfaceState activeNode = passiveNode as TCD_InterfaceState;
                    if (activeNode == null)
                    {
                        activeNode = new TCD_InterfaceState(passiveNode.Parent);
                        activeNode.Create(context, passiveNode);
                        if (passiveNode.Parent != null)
                        {
                            passiveNode.Parent.ReplaceChild(context, activeNode);
                        }
                    }

                    // Now that we have an active node, bind it to a simulator.
                    TCDSimulator simulator = CreateSimulatorForNode(activeNode);
                    if (simulator != null)
                    {
                        simulator.AddListener(activeNode);
                        simulator.SetLogger(m_Logger);
                        simulator.StartSimulation();
                        m_Simulators.Add(simulator);    // Prevent it from being disposed
                    }
                    return activeNode;
                }
            }
            return predefinedNode;
        }
        #endregion

        #region Private Fields
        private ushort m_NamespaceIndex;
        private ushort m_TypeNamespaceIndex;
        private long m_LastUsedId;
        private List<TCDSimulator> m_Simulators = new List<TCDSimulator>();
        private HoneypotLogger m_Logger;
        private System.Timers.Timer m_ReecordTimer;
        #endregion
    }
}
