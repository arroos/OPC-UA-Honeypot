/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

/* ========================================================================
 * Modified 2019 by Andrew Roos to:
 *     Add a Temperature Control Device custom node manager; 
 *     Change the ManufacturerName, ProductName and ProductUri;
 *     Log server startup and all incoming requests.
 * ======================================================================== */

#define CUSTOM_NODE_MANAGER

using Opc.Ua.Server;
using System.Collections.Generic;
using System.Diagnostics;
using Opc.Ua.Honeypot;
using System.Globalization;

namespace Opc.Ua.Sample
{
    /// <summary>
    /// A class which implements an instance of a UA server.
    /// </summary>
    public partial class SampleServer : StandardServer
    {
#if CUSTOM_NODE_MANAGER
        /// <summary>
        /// Creates the node managers for the server.
        /// </summary>
        /// <remarks>
        /// Add a node manager for the Temperature Control Device simulator nodes.
        /// </remarks>
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Debug.WriteLine("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new global::TCD.TCDNodeManager(server, configuration, m_Logger));

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
#endif
        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            // Set a standard culture for the entire application to prevent nasties like decimal commas, which generate JSON syntax errors.
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            base.OnServerStarting(configuration);
        }

        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            // request notifications when the user identity is changed. 
            server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
            m_Logger.Log(new LogEntry("ServerStarted"));
        }

        /// <summary>
        /// Loads the non-configurable properties for the application.
        /// </summary>
        /// <remarks>
        /// These properties are exposed by the server but cannot be changed by administrators.
        /// </remarks>
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "AR";
            properties.ProductName      = "OPC UA Server";
            properties.ProductUri       = null;
            properties.SoftwareVersion  = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber      = Utils.GetAssemblyBuildNumber();
            properties.BuildDate        = Utils.GetAssemblyTimestamp();

            return properties; 
        }

        /// <summary>
        /// Intercepts incoming requests so they can be logged.
        /// </summary>
        /// <param name="request">The request</param>
        public override void ScheduleIncomingRequest(IEndpointIncomingRequest request)
        {
            m_Logger.LogIncomingRequest(request);
            base.ScheduleIncomingRequest(request);
        }

        private readonly HoneypotLogger m_Logger = new FileLogger(@"C:\var\log\hp");
    }
}
