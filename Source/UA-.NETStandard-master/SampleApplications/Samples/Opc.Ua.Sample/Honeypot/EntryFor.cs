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
using System.Net;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// Create a log entry for a particular value. The For method is overloaded to create 
    /// the subclass of log entry that is appropriate for the value provided. This file 
    /// contains the overloaded "For" methods of the Entry class. 
    /// </summary>
    abstract partial class Entry
    {
        public static Entry For(int value)
        {
            return new IntegerEntry(value);
        }

        public static Entry For(uint value)
        {
            return new UnsignedEntry(value);
        }

        public static Entry For(bool value)
        {
            return new BooleanEntry(value);
        }

        public static Entry For(double value)
        {
            return new DoubleEntry(value);
        }

        public static Entry For(String value)
        {
            return new StringEntry(value);
        }

        public static Entry For(DateTime value)
        {
            return (new StringEntry(value == null ? null : value.ToString("yyyy-MM-dd HH:mm:ss.fff")));
        }

        public static Entry For(RequestHeader requestHeader)
        {
            if (requestHeader == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry requestHeaderEntry = new ObjectEntry();
                requestHeaderEntry.Add("RequestHandle", For(requestHeader.RequestHandle));
                requestHeaderEntry.Add("Timestamp", For(requestHeader.Timestamp));
                return requestHeaderEntry;
            }
        }

        public static Entry For(RegisteredServer server)
        {
            if (server == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry serverEntry = new ObjectEntry();
                serverEntry.Add("ServerURI", For(server.ServerUri));
                serverEntry.Add("ProductURI", For(server.ProductUri));
                serverEntry.Add("ServerType", For(server.ServerType));
                serverEntry.Add("GatewayServerURI", For(server.GatewayServerUri));
                serverEntry.Add("DiscoveryURLs", For(server.DiscoveryUrls));
                serverEntry.Add("SemaphoreFilePath", For(server.SemaphoreFilePath));
                serverEntry.Add("IsOnline", For(server.IsOnline));
                return serverEntry;
            }
        }

        public static Entry For(ApplicationType applicationType)
        {
            string appType = null;
            switch (applicationType)
            {
                case ApplicationType.Client:
                    appType = "Client";
                    break;
                case ApplicationType.Server:
                    appType = "Server";
                    break;
                case ApplicationType.ClientAndServer:
                    appType = "ClientAndServer";
                    break;
                case ApplicationType.DiscoveryServer:
                    appType = "DiscoveryServer";
                    break;
            }
            return new StringEntry(appType);
        }

        public static Entry For(ApplicationDescription description)
        {
            if (description == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("ApplicationUri", For(description.ApplicationUri));
                entry.Add("ProductUri", For(description.ProductUri));
                entry.Add("ApplicationName", For(description.ApplicationName));
                entry.Add("ApplicationType", For(description.ApplicationType));
                return entry;
            }
        }

        public static Entry For(LocalizedText text)
        {
            return new StringEntry(text == null ? null : text.ToString());
        }

        public static Entry For(StringCollection strings)
        {
            if (strings == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry arrayEntry = new ArrayEntry();
                StringCollection.Enumerator e = strings.GetEnumerator();
                while (e.MoveNext())
                {
                    arrayEntry.Add(For(e.Current));
                }
                return arrayEntry;
            }
        }

        public static Entry For(SecureChannelContext secureChannelContext)
        {
            if (secureChannelContext == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("SecureChannelId", For(secureChannelContext.SecureChannelId));
                entry.Add("MessageEncoding", For(secureChannelContext.MessageEncoding));
                entry.Add("EndpointURL", For(secureChannelContext.EndpointDescription));
                entry.Add("RemoteIP", For(secureChannelContext.RemoteIP));
                entry.Add("RemotePort", For(secureChannelContext.RemotePort));
                return entry;
            }
        }

        public static Entry For(RequestEncoding encoding)
        {
            String encodingText = null;
            switch (encoding)
            {
                case RequestEncoding.Binary:
                    encodingText = "Binary";
                    break;
                case RequestEncoding.Xml:
                    encodingText = "XML";
                    break;
            }
            return new StringEntry(encodingText);
        }

        public static Entry For(IPAddress ip)
        {
            if (ip == null)
            {
                return new NullEntry();
            }
            else
            {
                return new StringEntry(ip.ToString());
            }
        }

        public static Entry For(EndpointDescription endpoint)
        {
            return new StringEntry(endpoint == null ? null : endpoint.EndpointUrl);
        }

        public static Entry For(MessageSecurityMode securityMode)
        {
            string msmText = null;
            switch (securityMode)
            {
                case MessageSecurityMode.Invalid:
                    msmText = "Invalid";
                    break;
                case MessageSecurityMode.None:
                    msmText = "None";
                    break;
                case MessageSecurityMode.Sign:
                    msmText = "Sign";
                    break;
                case MessageSecurityMode.SignAndEncrypt:
                    msmText = "SignAndEncrypt";
                    break;
            }
            return new StringEntry(msmText);
        }

        public static Entry For(AddNodesItemCollection nodesToAdd)
        {
            if (nodesToAdd == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry entry = new ArrayEntry();
                AddNodesItemCollection.Enumerator e = nodesToAdd.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry node = new ObjectEntry();
                    node.Add("ParentNodeId", For(e.Current.ParentNodeId));
                    node.Add("ReferenceTypeId", For(e.Current.ReferenceTypeId));
                    node.Add("RequestedNewNodeId", For(e.Current.RequestedNewNodeId));
                    node.Add("TypeDefinition", For(e.Current.TypeDefinition));
                    entry.Add(node);
                }
                return entry;
            }
        }

        public static Entry For(AddReferencesItemCollection referencesToAdd)
        {
            if (referencesToAdd == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry entry = new ArrayEntry();
                AddReferencesItemCollection.Enumerator e = referencesToAdd.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry node = new ObjectEntry();
                    node.Add("ReferenceTypeId", For(e.Current.ReferenceTypeId));
                    node.Add("SourceNodeId", For(e.Current.SourceNodeId));
                    node.Add("TargetNodeClass", For((uint)e.Current.TargetNodeClass));
                    node.Add("TargetNodeId", For(e.Current.TargetNodeId));
                    node.Add("TargetServerURI", For(e.Current.TargetServerUri));
                    entry.Add(node);
                }
                return entry;
            }
        }

        public static Entry For(DeleteNodesItemCollection nodesToDelete)
        {
            if (nodesToDelete == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry entry = new ArrayEntry();
                DeleteNodesItemCollection.Enumerator e = nodesToDelete.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry node = new ObjectEntry();
                    node.Add("NodeId", For(e.Current.NodeId));
                    node.Add("DeleteTargetReferences", For(e.Current.DeleteTargetReferences));
                    entry.Add(node);
                }
                return entry;
            }
        }


        public static Entry For(DeleteReferencesItemCollection referencesToDelete)
        {
            if (referencesToDelete == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry entry = new ArrayEntry();
                DeleteReferencesItemCollection.Enumerator e = referencesToDelete.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry node = new ObjectEntry();
                    node.Add("SourceNodeId", For(e.Current.SourceNodeId));
                    node.Add("ReferenceTypeId", For(e.Current.ReferenceTypeId));
                    node.Add("IsForward", For(e.Current.IsForward));
                    node.Add("TargetNodeId", For(e.Current.TargetNodeId));
                    node.Add("DeleteBidirectional", For(e.Current.DeleteBidirectional));
                    entry.Add(node);
                }
                return entry;
            }
        }

        public static Entry For(BrowseDescriptionCollection nodesToBrowse)
        {
            if (nodesToBrowse == null)
            {
                return new NullEntry();
            }
            else
            {
                List<BrowseDescription>.Enumerator e = nodesToBrowse.GetEnumerator();
                ArrayEntry entry = new ArrayEntry();
                while (e.MoveNext())
                {
                    ObjectEntry node = new ObjectEntry();
                    node.Add("NodeId", For(e.Current.NodeId));
                    node.Add("BrowseDirection", For(e.Current.BrowseDirection));
                    entry.Add(node);
                }
                return entry;
            }
        }

        public static Entry For(BrowseDirection direction)
        {
            string text = null;
            switch (direction)
            {
                case BrowseDirection.Forward:
                    text = "Forward";
                    break;
                case BrowseDirection.Inverse:
                    text = "Inverse";
                    break;
                case BrowseDirection.Both:
                    text = "Both";
                    break;
                case BrowseDirection.Invalid:
                    text = "Invalid";
                    break;
            }
            return new StringEntry(text);
        }

        public static Entry For(NodeIdCollection nodeIds)
        {
            if (nodeIds == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                NodeIdCollection.Enumerator e = nodeIds.GetEnumerator();
                while (e.MoveNext())
                {
                    array.Add(For(e.Current));
                }
                return array;
            }
        }

        public static Entry For(NodeId nodeId)
        {
            if (nodeId == null)
            {
                return new NullEntry();
            }
            else
            {
                return (new StringEntry(nodeId.ToString()));
            }
        }

        public static Entry For(ExpandedNodeId nodeId)
        {
            if (nodeId == null)
            {
                return new NullEntry();
            }
            else
            {
                return (new StringEntry(nodeId.ToString()));
            }
        }

        public static Entry For(ViewDescription view)
        {
            if (view == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry viewEntry = new ObjectEntry();
                viewEntry.Add("ViewId", For(view.ViewId));
                viewEntry.Add("Timestamp", For(view.Timestamp));
                viewEntry.Add("ViewVersion", For(view.ViewVersion));
                return viewEntry;
            }
        }

        public static Entry For(NodeTypeDescriptionCollection nodeTypeDescriptions)
        {
            if (nodeTypeDescriptions == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry arrayEntry = new ArrayEntry();
                NodeTypeDescriptionCollection.Enumerator e = nodeTypeDescriptions.GetEnumerator();
                while (e.MoveNext())
                {
                    arrayEntry.Add(For(e.Current));
                }
                return arrayEntry;
            }
        }

        public static Entry For(ContentFilter filter)
        {
            if (filter == null)
            {
                return new NullEntry();
            }
            else
            {
                return new StringEntry(filter.ToString());
            }
        }

        public static Entry For(NodeTypeDescription ntd)
        {
            if (ntd == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("TypeDefinitionNode", For(ntd.TypeDefinitionNode));
                entry.Add("IncludeSubTypes", For(ntd.IncludeSubTypes));
                entry.Add("DataToReturn", For(ntd.DataToReturn));
                return entry;
            }
        }

        public static Entry For(QueryDataDescriptionCollection qddc)
        {
            if (qddc == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                QueryDataDescriptionCollection.Enumerator e = qddc.GetEnumerator();
                while (e.MoveNext())
                {
                    entry.Add("RelativePath", For(e.Current.RelativePath));
                    entry.Add("AttributeId", For(e.Current.AttributeId));
                    entry.Add("IndexRange", For(e.Current.IndexRange));
                }
                return entry;
            }
        }

        public static Entry For(RelativePath rp)
        {
            if (rp == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("TypeId", For(rp.TypeId));
                entry.Add("BinaryEncodingId", For(rp.BinaryEncodingId));
                entry.Add("XmlEncodingId", For(rp.XmlEncodingId));
                return entry;
            }
        }

        public static Entry For(ReadValueIdCollection nodesToRead)
        {
            if (nodesToRead == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                List<ReadValueId>.Enumerator e = nodesToRead.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry readValueEntry = new ObjectEntry();
                    readValueEntry.Add("NodeId", For(e.Current.NodeId));
                    readValueEntry.Add("AttributeId", For(e.Current.AttributeId));
                    readValueEntry.Add("IndexRange", For(e.Current.IndexRange));
                    readValueEntry.Add("DataEncoding", For(e.Current.DataEncoding));
                    readValueEntry.Add("Range", For(e.Current.ParsedIndexRange));
                    array.Add(readValueEntry);
                }
                return array;
            }
        }

        public static Entry For(NumericRange range)
        {
            if (range == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("Begin", For(range.Begin));
                entry.Add("End", For(range.End));
                return entry;
            }
        }

        public static Entry For(QualifiedName qualifiedName)
        {
            if (qualifiedName == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry entry = new ObjectEntry();
                entry.Add("NamespaceIndex", For(qualifiedName.NamespaceIndex));
                entry.Add("Name", For(qualifiedName.Name));
                return entry;
            }
        }

        public static Entry For(ushort us)
        {
            return For((uint)us);
        }

        public static Entry For(WriteValueCollection nodesToWrite)
        {
            if (nodesToWrite == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                List<WriteValue>.Enumerator e = nodesToWrite.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry nodeEntry = new ObjectEntry();
                    nodeEntry.Add("NodeId", For(e.Current.NodeId));
                    nodeEntry.Add("AttributeId", For(e.Current.AttributeId));
                    nodeEntry.Add("IndexRange", For(e.Current.IndexRange));
                    nodeEntry.Add("Value", For(e.Current.Value));
                    array.Add(nodeEntry);
                }
                return array;
            }
        }

        public static Entry For(DataValue value)
        {
            return new StringEntry(value == null ? null : value.ToString());
        }

        public static Entry For(CallMethodRequestCollection methodsToCall)
        {
            if (methodsToCall == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                CallMethodRequestCollection.Enumerator e = methodsToCall.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry methodEntry = new ObjectEntry();
                    methodEntry.Add("ObjectId", For(e.Current.ObjectId));
                    methodEntry.Add("MethodId", For(e.Current.MethodId));
                    methodEntry.Add("InputArguments", For(e.Current.InputArguments));
                    array.Add(methodEntry);
                }
                return array;
            }
        }

        public static Entry For(VariantCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                VariantCollection.Enumerator iae = collection.GetEnumerator();
                while (iae.MoveNext())
                {
                    Variant argument = iae.Current;
                    array.Add(For(argument.Value.ToString()));
                }
                return array;
            }
        }

        public static Entry For(MonitoredItemCreateRequestCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                MonitoredItemCreateRequestCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry itemToCreate = new ObjectEntry();
                    itemToCreate.Add("ItemToMonitor", For(e.Current.ItemToMonitor));
                    itemToCreate.Add("MonitoringMode", For(e.Current.MonitoringMode));
                    itemToCreate.Add("RequestedParameters", For(e.Current.RequestedParameters));
                    array.Add(itemToCreate);
                }
                return (array);
            }
        }

        public static Entry For(MonitoringMode mm)
        {
            string mmText = null;
            switch (mm)
            {
                case MonitoringMode.Disabled:
                    mmText = "Disabled";
                    break;
                case MonitoringMode.Sampling:
                    mmText = "Sampling";
                    break;
                case MonitoringMode.Reporting:
                    mmText = "Reporting";
                    break;
            }
            return new StringEntry(mmText);
        }

        public static Entry For(MonitoringParameters monitoringParameters)
        {
            if (monitoringParameters == null)
            {
                return new NullEntry();
            }
            else
            {
                ObjectEntry mpEntry = new ObjectEntry();
                mpEntry.Add("ClientHandle", For(monitoringParameters.ClientHandle));
                mpEntry.Add("SamplingInterval", For(monitoringParameters.SamplingInterval));
                mpEntry.Add("Filter", For(monitoringParameters.Filter));
                mpEntry.Add("QueueSize", For(monitoringParameters.QueueSize));
                mpEntry.Add("DiscardOldest", For(monitoringParameters.DiscardOldest));
                return mpEntry;
            }
        }

        public static Entry For(MonitoredItemModifyRequestCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                MonitoredItemModifyRequestCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry itemEntry = new ObjectEntry();
                    itemEntry.Add("ItemId", For(e.Current.MonitoredItemId));
                    itemEntry.Add("RequestedParameters", For(e.Current.RequestedParameters));
                    array.Add(itemEntry);
                }
                return array;
            }
        }

        public static Entry For(ExtensionObject ext)
        {
            return new StringEntry(ext == null ? null : ext.ToString());
        }

        public static Entry For(ReadValueId readValueId)
        {
            ObjectEntry readValueEntry = new ObjectEntry();
            readValueEntry.Add("NodeId", For(readValueId.NodeId));
            readValueEntry.Add("AttributeId", For(readValueId.AttributeId));
            readValueEntry.Add("IndexRange", For(readValueId.IndexRange));
            readValueEntry.Add("DataEncoding", For(readValueId.DataEncoding));
            return readValueEntry;
        }

        public static Entry For(TimestampsToReturn timestampsToReturn)
        {
            String ttrText = null;
            switch (timestampsToReturn)
            {
                case TimestampsToReturn.Source:
                    ttrText = "Source";
                    break;
                case TimestampsToReturn.Server:
                    ttrText = "Server";
                    break;
                case TimestampsToReturn.Both:
                    ttrText = "Both";
                    break;
                case TimestampsToReturn.Neither:
                    ttrText = "Neither";
                    break;
                case TimestampsToReturn.Invalid:
                    ttrText = "Invalid";
                    break;
            }
            return new StringEntry(ttrText);
        }

        public static Entry For(SubscriptionAcknowledgementCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                SubscriptionAcknowledgementCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    ObjectEntry oe = new ObjectEntry();
                    oe.Add("SubscriptionId", For(e.Current.SubscriptionId));
                    oe.Add("SequenceNo", For(e.Current.SequenceNumber));
                    array.Add(oe);
                }
                return array;
            }
        }

        public static Entry For(UInt32Collection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                UInt32Collection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    array.Add(For(e.Current));
                }
                return array;
            }
        }

        public static Entry For(BrowsePathCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                BrowsePathCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    array.Add(For(e.Current));
                }
                return array;
            }
        }

        public static Entry For(BrowsePath path)
        {
            ObjectEntry entry = new ObjectEntry();
            entry.Add("StartingNode", For(path.StartingNode));
            entry.Add("RelativePath", For(path.RelativePath));
            return entry;
        }

        public static Entry For(HistoryReadValueIdCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                HistoryReadValueIdCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    array.Add(For(e.Current));
                }
                return array;
            }
        }

        public static Entry For(HistoryReadValueId readValueId)
        {
            ObjectEntry entry = new ObjectEntry();
            entry.Add("NodeId", For(readValueId.NodeId));
            entry.Add("IndexRange", For(readValueId.IndexRange));
            entry.Add("DataEncoding", For(readValueId.DataEncoding));
            return entry;
        }

        public static Entry For(ExtensionObjectCollection collection)
        {
            if (collection == null)
            {
                return new NullEntry();
            }
            else
            {
                ArrayEntry array = new ArrayEntry();
                ExtensionObjectCollection.Enumerator e = collection.GetEnumerator();
                while (e.MoveNext())
                {
                    array.Add(For(e.Current));
                }
                return array;
            }
        }
    }
}
