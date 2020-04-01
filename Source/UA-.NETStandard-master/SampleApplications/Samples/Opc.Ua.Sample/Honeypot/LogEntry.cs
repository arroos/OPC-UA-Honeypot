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
    /// A class representing log entries. Each entry consists of an OPC UA service request 
    /// name and an arbitrary number of field/value pairs. Log entries are written one
    /// per line to the log file as JSON objects, with the object name being the request 
    /// name. 
    /// </summary>
    public class LogEntry : ObjectEntry
    {
        /// <summary>
        /// Set the name of the log entry, which is typically the OPC UA service request. 
        /// </summary>
        /// <param name="requestName">The name of the log entry</param>
        public LogEntry(String requestName)
        {
            m_RequestName = requestName;
        }

        /// <summary>
        /// Get the name of the service request that generated this log entry. 
        /// </summary>
        /// <returns>The name of the service request.</returns>
        public string getRequestName()
        {
            return m_RequestName;
        }

        /// <summary>
        /// Create a log entry for an authentication event. This generates a log entry 
        /// with requestName "AuthInfo", even though that is not actually a service 
        /// request. 
        /// </summary>
        /// <param name="username">The username used.</param>
        /// <param name="password">The password used.</param>
        /// <param name="accepted">Whether the username/password was accepted.</param>
        public static LogEntry For(string username, string password, bool accepted)
        {
            LogEntry entry = new LogEntry("AuthInfo");
            entry.Add("Username", For(username));
            entry.Add("Password", For(password));
            entry.Add("Accepted", For(accepted));
            return entry;
        }

        // The overriden For methods below create Log entries specific to all OPC UA 
        // service request types. 

        public static LogEntry For(FindServersRequest request)
        {
            LogEntry entry = new LogEntry("FindServersRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("LocaleIds", For(request.LocaleIds));
            entry.Add("ServerURIs", For(request.ServerUris));
            return entry;
        }

        public static LogEntry For(FindServersOnNetworkRequest request)
        {
            LogEntry entry = new LogEntry("FindServersOnNetworkRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("StartingRecordId", For(request.StartingRecordId));
            entry.Add("MaxRecordsToReturn", For(request.MaxRecordsToReturn));
            entry.Add("ServerCapabilityFilter", For(request.ServerCapabilityFilter));
            return entry;
        }

        public static LogEntry For(GetEndpointsRequest request)
        {
            LogEntry entry = new LogEntry("GetEndpointsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("EndpointURL", For(request.EndpointUrl));
            entry.Add("LocaleIds", For(request.LocaleIds));
            entry.Add("ProfileURIs", For(request.ProfileUris));
            return entry;
        }

        public static LogEntry For(RegisterServerRequest request)
        {
            LogEntry entry = new LogEntry("RegisterServerRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("Server", For(request.Server));
            return entry;
        }


        public static LogEntry For(CreateSessionRequest request)
        {
            LogEntry entry = new LogEntry("CreateSessionRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("ClientDescription", For(request.ClientDescription));
            entry.Add("ServerUri", For(request.ServerUri));
            entry.Add("EndpointUrl", For(request.EndpointUrl));
            entry.Add("SessionName", For(request.SessionName));
            entry.Add("RequestedSessionTimeout", For(request.RequestedSessionTimeout));
            entry.Add("MaxResponseMessageSize", For(request.MaxResponseMessageSize));
            return entry;
        }
        public static LogEntry For(RegisterServer2Request request)
        {
            LogEntry entry = new LogEntry("RegisterServer2Request");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("Server", For(request.Server));
            return entry;
        }

        public static LogEntry For(OpenSecureChannelRequest request)
        {
            LogEntry entry = new LogEntry("OpenSecureChannelRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SecurityMode", For(request.SecurityMode));
            return entry;
        }

        public static LogEntry For(CloseSecureChannelRequest request)
        {
            LogEntry entry = new LogEntry("CloseSecureChannelRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            return entry;
        }

        public static LogEntry For(ActivateSessionRequest request)
        {
            LogEntry entry = new LogEntry("ActivateSessionRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("LocaleIds", For(request.LocaleIds));
            return entry;
        }

        public static LogEntry For(CloseSessionRequest request)
        {
            LogEntry entry = new LogEntry("CloseSessionRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("DeleteSubscriptions", For(request.DeleteSubscriptions));
            return entry;
        }

        public static LogEntry For(CancelRequest request)
        {
            LogEntry entry = new LogEntry("CancelRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("RequestHandle", For(request.RequestHandle));
            return entry;
        }

        public static LogEntry For(AddNodesRequest request)
        {
            LogEntry entry = new LogEntry("AddNodesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToAdd", For(request.NodesToAdd));
            return entry;
        }

        public static LogEntry For(AddReferencesRequest request)
        {
            LogEntry entry = new LogEntry("AddReferencesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("ReferencesToAdd", For(request.ReferencesToAdd));
            return entry;
        }

        public static LogEntry For(DeleteNodesRequest request)
        {
            LogEntry entry = new LogEntry("DeleteNodesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToDelete", For(request.NodesToDelete));
            return entry;
        }

        public static LogEntry For(DeleteReferencesRequest request)
        {
            LogEntry entry = new LogEntry("DeleteReferencesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("ReferencesToDelete", For(request.ReferencesToDelete));
            return entry;
        }

        public static LogEntry For(BrowseRequest request)
        {
            LogEntry entry = new LogEntry("BrowseRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToBrowse", For(request.NodesToBrowse));
            return entry;
        }

        public static LogEntry For(BrowseNextRequest request)
        {
            LogEntry entry = new LogEntry("BrowseNextRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("ReleaseContinuationPoints", For(request.ReleaseContinuationPoints));
            return entry;
        }

        public static LogEntry For(TranslateBrowsePathsToNodeIdsRequest request)
        {
            LogEntry entry = new LogEntry("TranslateBrowsePathsToNodeIdsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("BrowsePaths", For(request.BrowsePaths));
            return entry;
        }

        public static LogEntry For(RegisterNodesRequest request)
        {
            LogEntry entry = new LogEntry("RegisterNodesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToRegister", For(request.NodesToRegister));
            return entry;
        }

        public static LogEntry For(UnregisterNodesRequest request)
        {
            LogEntry entry = new LogEntry("UnregisterNodesRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToUnregister", For(request.NodesToUnregister));
            return entry;
        }

        public static LogEntry For(QueryFirstRequest request)
        {
            LogEntry entry = new LogEntry("QueryFirstRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("View", For(request.View));
            entry.Add("NodeTypes", For(request.NodeTypes));
            entry.Add("Filter", For(request.Filter));
            entry.Add("MaxDataSetsToReturn", For(request.MaxDataSetsToReturn));
            entry.Add("MaxReferencesToReturn", For(request.MaxReferencesToReturn));
            return entry;
        }

        public static LogEntry For(QueryNextRequest request)
        {
            LogEntry entry = new LogEntry("QueryNextRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("ReleaseContinuationPoint", For(request.ReleaseContinuationPoint));
            return entry;
        }

        public static LogEntry For(ReadRequest request)
        {
            LogEntry entry = new LogEntry("ReadRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToRead", For(request.NodesToRead));
            return entry;
        }

        public static LogEntry For(HistoryReadRequest request)
        {
            LogEntry entry = new LogEntry("HistoryReadRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("HistoryReadDetails", For(request.HistoryReadDetails));
            entry.Add("TimestampsToReturn", For(request.TimestampsToReturn));
            entry.Add("ReleaseContinuationPoints", For(request.ReleaseContinuationPoints));
            entry.Add("NodesToRead", For(request.NodesToRead));
            return entry;
        }

        public static LogEntry For(WriteRequest request)
        {
            LogEntry entry = new LogEntry("WriteRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("NodesToWrite",For(request.NodesToWrite));
            return entry;
        }

        public static LogEntry For(HistoryUpdateRequest request)
        {
            LogEntry entry = new LogEntry("HistoryUpdateRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("HistoryUpdateDetails", For(request.HistoryUpdateDetails));
            return entry;
        }

        public static LogEntry For(CallRequest request)
        {
            LogEntry entry = new LogEntry("CallRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("MethodsToCall", For(request.MethodsToCall));
            return entry;
        }

        public static LogEntry For(CreateMonitoredItemsRequest request)
        {
            LogEntry entry = new LogEntry("CreateMonitoredItemsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionID", For(request.SubscriptionId));
            entry.Add("TimestampsToReturn", For(request.TimestampsToReturn));
            entry.Add("ItemsToCreate", For(request.ItemsToCreate));
            return entry;
        }

        public static LogEntry For(ModifyMonitoredItemsRequest request)
        {
            LogEntry entry = new LogEntry("ModifyMonitoredItemsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionID", For(request.SubscriptionId));
            entry.Add("TimestampsToReturn", For(request.TimestampsToReturn));
            entry.Add("ItemsToModify", For(request.ItemsToModify));
            return entry;
        }

        public static LogEntry For(SetMonitoringModeRequest request)
        {
            LogEntry entry = new LogEntry("SetMonitoringModeRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionId", For(request.SubscriptionId));
            entry.Add("MonitoringMode", For(request.MonitoringMode));
            entry.Add("MonitoredItemIds", For(request.MonitoredItemIds));
            return entry;
        }

        public static LogEntry For(SetTriggeringRequest request)
        {
            LogEntry entry = new LogEntry("SetTriggeringRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionId", For(request.SubscriptionId));
            entry.Add("TriggeringItemId", For(request.TriggeringItemId));
            entry.Add("LinksToAdd", For(request.LinksToAdd));
            entry.Add("LinksToRemove", For(request.LinksToRemove));
            return entry;
        }

        public static LogEntry For(DeleteMonitoredItemsRequest request)
        {
            LogEntry entry = new LogEntry("SetMonitoringModeRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionId", For(request.SubscriptionId));
            entry.Add("MonitoredItemIds", For(request.MonitoredItemIds));
            return entry;
        }

        public static LogEntry For(CreateSubscriptionRequest request)
        {
            LogEntry entry = new LogEntry("CreateSubscriptionRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("RequestedPublishingInterval", For(request.RequestedPublishingInterval));
            entry.Add("RequestedLifetimeCount", For(request.RequestedLifetimeCount));
            entry.Add("RequestedMaxKeepAliveCount", For(request.RequestedMaxKeepAliveCount));
            entry.Add("MaxNotificationsPerPublish", For(request.MaxNotificationsPerPublish));
            entry.Add("PublishingEnabled", For(request.PublishingEnabled));
            entry.Add("Priority", For(request.Priority));
            return entry;
        }

        public static LogEntry For(ModifySubscriptionRequest request)
        {
            LogEntry entry = new LogEntry("ModifySubscriptionRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionId", For(request.SubscriptionId));
            entry.Add("RequestedPublishingInterval", For(request.RequestedPublishingInterval));
            entry.Add("RequestedLifetimeCount", For(request.RequestedLifetimeCount));
            entry.Add("RequestedMaxKeepAliveCount", For(request.RequestedMaxKeepAliveCount));
            entry.Add("MaxNotificationsPerPublish", For(request.MaxNotificationsPerPublish));
            entry.Add("Priority", For(request.Priority));
            return entry;
        }

        public static LogEntry For(SetPublishingModeRequest request)
        {
            LogEntry entry = new LogEntry("SetPublishingModeRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("PublishingEnabled", For(request.PublishingEnabled));
            entry.Add("SubscriptionIds", For(request.SubscriptionIds));
            return entry;
        }

        public static LogEntry For(PublishRequest request)
        {
            // Don't log Publish requests
            //return null;

            LogEntry entry = new LogEntry("PublishRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionAcknowledgements", For(request.SubscriptionAcknowledgements));
            return entry;
        }

        public static LogEntry For(RepublishRequest request)
        {
            LogEntry entry = new LogEntry("RepublishRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionId", For(request.SubscriptionId));
            entry.Add("RetransmitSequenceNumber", For(request.RetransmitSequenceNumber));
            return entry;
        }

        public static LogEntry For(TransferSubscriptionsRequest request)
        {
            LogEntry entry = new LogEntry("TransferSubscriptionsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionIds", For(request.SubscriptionIds));
            return entry;
        }

        public static LogEntry For(DeleteSubscriptionsRequest request)
        {
            LogEntry entry = new LogEntry("DeleteSubscriptionsRequest");
            entry.Add("RequestHeader", For(request.RequestHeader));
            entry.Add("SubscriptionIds", For(request.SubscriptionIds));
            return entry;
        }

        private string m_RequestName;
    }
}
