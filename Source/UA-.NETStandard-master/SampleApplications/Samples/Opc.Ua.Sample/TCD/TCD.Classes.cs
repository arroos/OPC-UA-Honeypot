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

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TCD
{
    #region ActiveErrorsDataState Class
    #if (!OPCUA_EXCLUDE_ActiveErrorsDataState)
    /// <summary>
    /// Stores an instance of the ActiveErrorsDataType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActiveErrorsDataState : BaseDataVariableState<ActiveErrorDataType[]>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActiveErrorsDataState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.VariableTypes.ActiveErrorsDataType, TCD.Namespaces.TCD, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.DataTypes.ActiveErrorDataType, TCD.Namespaces.TCD, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.OneDimension;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<ActiveErrorsDataTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15001</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActiveErrorsDataTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15001</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15001</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=15007</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ActiveErrorsDataTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IdentificationState Class
    #if (!OPCUA_EXCLUDE_IdentificationState)
    /// <summary>
    /// Stores an instance of the IdentificationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IdentificationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IdentificationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.IdentificationType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<IdentificationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15008</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>IdentificationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15008</uax:NumericId>" +
           "<SerialNumber>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15012</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SerialNumber</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15012</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SerialNumber>" +
           "<Model>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15013</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Model</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15013</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Model>" +
           "<Manufacturer>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15014</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Manufacturer</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15014</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Manufacturer>" +
           "<DeviceClass>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15015</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceClass</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15015</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceClass>" +
           "</IdentificationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceClass
        {
            get
            {
                return m_deviceClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case TCD.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<string>(this);
                            }
                            else
                            {
                                Model = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case TCD.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case TCD.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_model;
        private PropertyState<string> m_manufacturer;
        private PropertyState<string> m_deviceClass;
        #endregion
    }
    #endif
    #endregion

    #region TCDSpecificationState Class
    #if (!OPCUA_EXCLUDE_TCDSpecificationState)
    /// <summary>
    /// Stores an instance of the TCDSpecificationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TCDSpecificationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TCDSpecificationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.TCDSpecificationType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<TCDSpecificationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15167</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>TCDSpecificationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15167</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15167</uax:NumericId>" +
           "<CoolingCapacity>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15280</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>CoolingCapacity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15280</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15658</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15658</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</CoolingCapacity>" +
           "<ConnectedLoad>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15854</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ConnectedLoad</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15854</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15858</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15858</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</ConnectedLoad>" +
           "<NominalFlowRate>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15860</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>NominalFlowRate</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15860</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15864</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15864</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</NominalFlowRate>" +
           "<PowerValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15866</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>PowerValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15866</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15870</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15870</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</PowerValue>" +
           "<MaxTemperature>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15872</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaxTemperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15872</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15876</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15876</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MaxTemperature>" +
           "<MinTemperature>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15878</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MinTemperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15878</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15882</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15882</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MinTemperature>" +
           "</TCDSpecificationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState CoolingCapacity
        {
            get
            {
                return m_coolingCapacity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coolingCapacity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coolingCapacity = value;
            }
        }

        /// <remarks />
        public AnalogItemState ConnectedLoad
        {
            get
            {
                return m_connectedLoad;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectedLoad, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectedLoad = value;
            }
        }

        /// <remarks />
        public AnalogItemState NominalFlowRate
        {
            get
            {
                return m_nominalFlowRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominalFlowRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominalFlowRate = value;
            }
        }

        /// <remarks />
        public AnalogItemState PowerValue
        {
            get
            {
                return m_powerValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerValue = value;
            }
        }

        /// <remarks />
        public AnalogItemState MaxTemperature
        {
            get
            {
                return m_maxTemperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxTemperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxTemperature = value;
            }
        }

        /// <remarks />
        public AnalogItemState MinTemperature
        {
            get
            {
                return m_minTemperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minTemperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minTemperature = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coolingCapacity != null)
            {
                children.Add(m_coolingCapacity);
            }

            if (m_connectedLoad != null)
            {
                children.Add(m_connectedLoad);
            }

            if (m_nominalFlowRate != null)
            {
                children.Add(m_nominalFlowRate);
            }

            if (m_powerValue != null)
            {
                children.Add(m_powerValue);
            }

            if (m_maxTemperature != null)
            {
                children.Add(m_maxTemperature);
            }

            if (m_minTemperature != null)
            {
                children.Add(m_minTemperature);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.CoolingCapacity:
                {
                    if (createOrReplace)
                    {
                        if (CoolingCapacity == null)
                        {
                            if (replacement == null)
                            {
                                CoolingCapacity = new AnalogItemState(this);
                            }
                            else
                            {
                                CoolingCapacity = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = CoolingCapacity;
                    break;
                }

                case TCD.BrowseNames.ConnectedLoad:
                {
                    if (createOrReplace)
                    {
                        if (ConnectedLoad == null)
                        {
                            if (replacement == null)
                            {
                                ConnectedLoad = new AnalogItemState(this);
                            }
                            else
                            {
                                ConnectedLoad = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = ConnectedLoad;
                    break;
                }

                case TCD.BrowseNames.NominalFlowRate:
                {
                    if (createOrReplace)
                    {
                        if (NominalFlowRate == null)
                        {
                            if (replacement == null)
                            {
                                NominalFlowRate = new AnalogItemState(this);
                            }
                            else
                            {
                                NominalFlowRate = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = NominalFlowRate;
                    break;
                }

                case TCD.BrowseNames.PowerValue:
                {
                    if (createOrReplace)
                    {
                        if (PowerValue == null)
                        {
                            if (replacement == null)
                            {
                                PowerValue = new AnalogItemState(this);
                            }
                            else
                            {
                                PowerValue = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = PowerValue;
                    break;
                }

                case TCD.BrowseNames.MaxTemperature:
                {
                    if (createOrReplace)
                    {
                        if (MaxTemperature == null)
                        {
                            if (replacement == null)
                            {
                                MaxTemperature = new AnalogItemState(this);
                            }
                            else
                            {
                                MaxTemperature = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = MaxTemperature;
                    break;
                }

                case TCD.BrowseNames.MinTemperature:
                {
                    if (createOrReplace)
                    {
                        if (MinTemperature == null)
                        {
                            if (replacement == null)
                            {
                                MinTemperature = new AnalogItemState(this);
                            }
                            else
                            {
                                MinTemperature = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = MinTemperature;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState m_coolingCapacity;
        private AnalogItemState m_connectedLoad;
        private AnalogItemState m_nominalFlowRate;
        private AnalogItemState m_powerValue;
        private AnalogItemState m_maxTemperature;
        private AnalogItemState m_minTemperature;
        #endregion
    }
    #endif
    #endregion

    #region OperationState Class
    #if (!OPCUA_EXCLUDE_OperationState)
    /// <summary>
    /// Stores an instance of the OperationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OperationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OperationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.OperationType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<OperationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15047</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>OperationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15047</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15047</uax:NumericId>" +
           "<ActiveErrors>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15048</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActiveErrors</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15001</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15048</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=15007</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ActiveErrors>" +
           "<HoursOfOperation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15049</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>HoursOfOperation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15049</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15053</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15053</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</HoursOfOperation>" +
           "<HighestActiveAlarmSeverity>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15055</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>HighestActiveAlarmSeverity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15055</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</HighestActiveAlarmSeverity>" +
           "<DeviceMappingNumber>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15056</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceMappingNumber</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15056</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceMappingNumber>" +
           "<OperatingMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15057</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>OperatingMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15057</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OperatingMode>" +
           "<ResetAllErrors>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15755</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ResetAllErrors</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15755</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15755</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</ResetAllErrors>" +
           "<SwitchOn>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15064</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SwitchOn</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15064</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15064</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</SwitchOn>" +
           "<SwitchOff>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15067</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SwitchOff</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15067</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15067</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</SwitchOff>" +
           "</OperationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ActiveErrorsDataState ActiveErrors
        {
            get
            {
                return m_activeErrors;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeErrors, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeErrors = value;
            }
        }

        /// <remarks />
        public AnalogItemState HoursOfOperation
        {
            get
            {
                return m_hoursOfOperation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hoursOfOperation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hoursOfOperation = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> HighestActiveAlarmSeverity
        {
            get
            {
                return m_highestActiveAlarmSeverity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_highestActiveAlarmSeverity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_highestActiveAlarmSeverity = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> DeviceMappingNumber
        {
            get
            {
                return m_deviceMappingNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceMappingNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceMappingNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> OperatingMode
        {
            get
            {
                return m_operatingMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingMode = value;
            }
        }

        /// <remarks />
        public MethodState ResetAllErrors
        {
            get
            {
                return m_resetAllErrorsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetAllErrorsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetAllErrorsMethod = value;
            }
        }

        /// <remarks />
        public MethodState SwitchOn
        {
            get
            {
                return m_switchOnMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_switchOnMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_switchOnMethod = value;
            }
        }

        /// <remarks />
        public MethodState SwitchOff
        {
            get
            {
                return m_switchOffMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_switchOffMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_switchOffMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_activeErrors != null)
            {
                children.Add(m_activeErrors);
            }

            if (m_hoursOfOperation != null)
            {
                children.Add(m_hoursOfOperation);
            }

            if (m_highestActiveAlarmSeverity != null)
            {
                children.Add(m_highestActiveAlarmSeverity);
            }

            if (m_deviceMappingNumber != null)
            {
                children.Add(m_deviceMappingNumber);
            }

            if (m_operatingMode != null)
            {
                children.Add(m_operatingMode);
            }

            if (m_resetAllErrorsMethod != null)
            {
                children.Add(m_resetAllErrorsMethod);
            }

            if (m_switchOnMethod != null)
            {
                children.Add(m_switchOnMethod);
            }

            if (m_switchOffMethod != null)
            {
                children.Add(m_switchOffMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.ActiveErrors:
                {
                    if (createOrReplace)
                    {
                        if (ActiveErrors == null)
                        {
                            if (replacement == null)
                            {
                                ActiveErrors = new ActiveErrorsDataState(this);
                            }
                            else
                            {
                                ActiveErrors = (ActiveErrorsDataState)replacement;
                            }
                        }
                    }

                    instance = ActiveErrors;
                    break;
                }

                case TCD.BrowseNames.HoursOfOperation:
                {
                    if (createOrReplace)
                    {
                        if (HoursOfOperation == null)
                        {
                            if (replacement == null)
                            {
                                HoursOfOperation = new AnalogItemState(this);
                            }
                            else
                            {
                                HoursOfOperation = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = HoursOfOperation;
                    break;
                }

                case TCD.BrowseNames.HighestActiveAlarmSeverity:
                {
                    if (createOrReplace)
                    {
                        if (HighestActiveAlarmSeverity == null)
                        {
                            if (replacement == null)
                            {
                                HighestActiveAlarmSeverity = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                HighestActiveAlarmSeverity = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = HighestActiveAlarmSeverity;
                    break;
                }

                case TCD.BrowseNames.DeviceMappingNumber:
                {
                    if (createOrReplace)
                    {
                        if (DeviceMappingNumber == null)
                        {
                            if (replacement == null)
                            {
                                DeviceMappingNumber = new PropertyState<uint>(this);
                            }
                            else
                            {
                                DeviceMappingNumber = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = DeviceMappingNumber;
                    break;
                }

                case TCD.BrowseNames.OperatingMode:
                {
                    if (createOrReplace)
                    {
                        if (OperatingMode == null)
                        {
                            if (replacement == null)
                            {
                                OperatingMode = new PropertyState<string>(this);
                            }
                            else
                            {
                                OperatingMode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = OperatingMode;
                    break;
                }

                case TCD.BrowseNames.ResetAllErrors:
                {
                    if (createOrReplace)
                    {
                        if (ResetAllErrors == null)
                        {
                            if (replacement == null)
                            {
                                ResetAllErrors = new MethodState(this);
                            }
                            else
                            {
                                ResetAllErrors = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetAllErrors;
                    break;
                }

                case TCD.BrowseNames.SwitchOn:
                {
                    if (createOrReplace)
                    {
                        if (SwitchOn == null)
                        {
                            if (replacement == null)
                            {
                                SwitchOn = new MethodState(this);
                            }
                            else
                            {
                                SwitchOn = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SwitchOn;
                    break;
                }

                case TCD.BrowseNames.SwitchOff:
                {
                    if (createOrReplace)
                    {
                        if (SwitchOff == null)
                        {
                            if (replacement == null)
                            {
                                SwitchOff = new MethodState(this);
                            }
                            else
                            {
                                SwitchOff = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SwitchOff;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ActiveErrorsDataState m_activeErrors;
        private AnalogItemState m_hoursOfOperation;
        private PropertyState<ushort> m_highestActiveAlarmSeverity;
        private PropertyState<uint> m_deviceMappingNumber;
        private PropertyState<string> m_operatingMode;
        private MethodState m_resetAllErrorsMethod;
        private MethodState m_switchOnMethod;
        private MethodState m_switchOffMethod;
        #endregion
    }
    #endif
    #endregion

    #region TCD_InterfaceState Class
    #if (!OPCUA_EXCLUDE_TCD_InterfaceState)
    /// <summary>
    /// Stores an instance of the TCD_Interface ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TCD_InterfaceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TCD_InterfaceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.TCD_Interface, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<TCD_InterfaceInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15070</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>TCD_InterfaceInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15070</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15070</uax:NumericId>" +
           "<DeviceZone>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15071</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceZone</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15175</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15071</uax:NumericId>" +
           "<MaintenanceInformation>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15009</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaintenanceInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15193</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15009</uax:NumericId>" +
           "<Heating>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15010</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Heating</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15010</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15011</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15011</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15019</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15019</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15021</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15021</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15025</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15025</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15027</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15027</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15028</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15028</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15029</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15029</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Heating>" +
           "<Cooling>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15032</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Cooling</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15032</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15033</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15033</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15037</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15037</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15039</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15039</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15043</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15043</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15045</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15045</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15046</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15046</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15058</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15058</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Cooling>" +
           "</MaintenanceInformation>" +
           "<Temperature>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15072</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Temperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15214</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15072</uax:NumericId>" +
           "<SetValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15002</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15002</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15073</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15073</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetValue>" +
           "<ActualValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15075</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActualValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15075</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15079</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15079</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</ActualValue>" +
           "<LowerTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16150</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LowerTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16150</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16154</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16154</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</LowerTolerance>" +
           "<UpperTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16156</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>UpperTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16156</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16160</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16160</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</UpperTolerance>" +
           "<MinValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16162</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MinValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16162</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16166</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16166</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MinValue>" +
           "<MaxValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16168</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaxValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16168</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16172</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16172</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MaxValue>" +
           "<SetRampDown>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15665</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampDown</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15665</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15669</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15669</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampDown>" +
           "<SetRampUp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15659</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampUp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15659</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15663</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15663</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampUp>" +
           "</Temperature>" +
           "</DeviceZone>" +
           "<MachineConfiguration>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15097</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MachineConfiguration</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15168</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15097</uax:NumericId>" +
           "<TimeZoneOffset>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15098</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>TimeZoneOffset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15098</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=15004</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TimeZoneOffset>" +
           "<LocationName>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15099</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LocationName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15099</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "</LocationName>" +
           "<UserMachineName>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15100</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>UserMachineName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15100</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "</UserMachineName>" +
           "</MachineConfiguration>" +
           "<Operation>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15104</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Operation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15047</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15104</uax:NumericId>" +
           "<ActiveErrors>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15105</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActiveErrors</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15001</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15105</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=15007</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ActiveErrors>" +
           "<HoursOfOperation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15106</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>HoursOfOperation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15106</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15110</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15110</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</HoursOfOperation>" +
           "<HighestActiveAlarmSeverity>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15112</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>HighestActiveAlarmSeverity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15112</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</HighestActiveAlarmSeverity>" +
           "<DeviceMappingNumber>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15113</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceMappingNumber</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15113</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceMappingNumber>" +
           "<OperatingMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15114</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>OperatingMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15114</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OperatingMode>" +
           "<ResetAllErrors>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15758</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ResetAllErrors</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15755</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15758</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</ResetAllErrors>" +
           "<SwitchOn>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15121</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SwitchOn</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15064</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15121</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</SwitchOn>" +
           "<SwitchOff>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15124</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SwitchOff</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15067</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15124</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</SwitchOff>" +
           "</Operation>" +
           "<TCDSpecification>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15884</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>TCDSpecification</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15167</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15884</uax:NumericId>" +
           "<CoolingCapacity>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15885</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>CoolingCapacity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15885</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15889</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15889</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</CoolingCapacity>" +
           "<ConnectedLoad>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15891</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ConnectedLoad</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15891</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15895</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15895</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</ConnectedLoad>" +
           "<NominalFlowRate>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15897</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>NominalFlowRate</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15897</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15901</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15901</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</NominalFlowRate>" +
           "<PowerValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15903</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>PowerValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15903</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15907</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15907</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</PowerValue>" +
           "<MaxTemperature>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15909</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaxTemperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15909</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15913</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15913</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MaxTemperature>" +
           "<MinTemperature>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15915</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MinTemperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15915</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15919</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15919</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MinTemperature>" +
           "</TCDSpecification>" +
           "<Identification>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15158</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Identification</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15158</uax:NumericId>" +
           "<SerialNumber>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15162</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SerialNumber</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15162</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SerialNumber>" +
           "<Model>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15163</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Model</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15163</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Model>" +
           "<Manufacturer>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15164</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Manufacturer</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15164</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Manufacturer>" +
           "<DeviceClass>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15165</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceClass</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15165</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceClass>" +
           "</Identification>" +
           "</TCD_InterfaceInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DeviceZoneState DeviceZone
        {
            get
            {
                return m_deviceZone;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceZone, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceZone = value;
            }
        }

        /// <remarks />
        public MachineConfigurationState MachineConfiguration
        {
            get
            {
                return m_machineConfiguration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineConfiguration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineConfiguration = value;
            }
        }

        /// <remarks />
        public OperationState Operation
        {
            get
            {
                return m_operation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operation = value;
            }
        }

        /// <remarks />
        public TCDSpecificationState TCDSpecification
        {
            get
            {
                return m_tCDSpecification;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tCDSpecification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tCDSpecification = value;
            }
        }

        /// <remarks />
        public IdentificationState Identification
        {
            get
            {
                return m_identification;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identification = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceZone != null)
            {
                children.Add(m_deviceZone);
            }

            if (m_machineConfiguration != null)
            {
                children.Add(m_machineConfiguration);
            }

            if (m_operation != null)
            {
                children.Add(m_operation);
            }

            if (m_tCDSpecification != null)
            {
                children.Add(m_tCDSpecification);
            }

            if (m_identification != null)
            {
                children.Add(m_identification);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.DeviceZone:
                {
                    if (createOrReplace)
                    {
                        if (DeviceZone == null)
                        {
                            if (replacement == null)
                            {
                                DeviceZone = new DeviceZoneState(this);
                            }
                            else
                            {
                                DeviceZone = (DeviceZoneState)replacement;
                            }
                        }
                    }

                    instance = DeviceZone;
                    break;
                }

                case TCD.BrowseNames.MachineConfiguration:
                {
                    if (createOrReplace)
                    {
                        if (MachineConfiguration == null)
                        {
                            if (replacement == null)
                            {
                                MachineConfiguration = new MachineConfigurationState(this);
                            }
                            else
                            {
                                MachineConfiguration = (MachineConfigurationState)replacement;
                            }
                        }
                    }

                    instance = MachineConfiguration;
                    break;
                }

                case TCD.BrowseNames.Operation:
                {
                    if (createOrReplace)
                    {
                        if (Operation == null)
                        {
                            if (replacement == null)
                            {
                                Operation = new OperationState(this);
                            }
                            else
                            {
                                Operation = (OperationState)replacement;
                            }
                        }
                    }

                    instance = Operation;
                    break;
                }

                case TCD.BrowseNames.TCDSpecification:
                {
                    if (createOrReplace)
                    {
                        if (TCDSpecification == null)
                        {
                            if (replacement == null)
                            {
                                TCDSpecification = new TCDSpecificationState(this);
                            }
                            else
                            {
                                TCDSpecification = (TCDSpecificationState)replacement;
                            }
                        }
                    }

                    instance = TCDSpecification;
                    break;
                }

                case TCD.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new IdentificationState(this);
                            }
                            else
                            {
                                Identification = (IdentificationState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private DeviceZoneState m_deviceZone;
        private MachineConfigurationState m_machineConfiguration;
        private OperationState m_operation;
        private TCDSpecificationState m_tCDSpecification;
        private IdentificationState m_identification;
        #endregion
    }
    #endif
    #endregion

    #region MachineConfigurationState Class
    #if (!OPCUA_EXCLUDE_MachineConfigurationState)
    /// <summary>
    /// Stores an instance of the MachineConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineConfigurationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.MachineConfigurationType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<MachineConfigurationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15168</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MachineConfigurationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15168</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15168</uax:NumericId>" +
           "<TimeZoneOffset>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15169</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>TimeZoneOffset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15169</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=15004</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TimeZoneOffset>" +
           "<LocationName>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15170</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LocationName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15170</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "</LocationName>" +
           "<UserMachineName>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15171</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>UserMachineName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15171</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "</UserMachineName>" +
           "</MachineConfigurationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<TimeZoneDataType> TimeZoneOffset
        {
            get
            {
                return m_timeZoneOffset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeZoneOffset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeZoneOffset = value;
            }
        }

        /// <remarks />
        public PropertyState<string> LocationName
        {
            get
            {
                return m_locationName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locationName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locationName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserMachineName
        {
            get
            {
                return m_userMachineName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userMachineName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userMachineName = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_timeZoneOffset != null)
            {
                children.Add(m_timeZoneOffset);
            }

            if (m_locationName != null)
            {
                children.Add(m_locationName);
            }

            if (m_userMachineName != null)
            {
                children.Add(m_userMachineName);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.TimeZoneOffset:
                {
                    if (createOrReplace)
                    {
                        if (TimeZoneOffset == null)
                        {
                            if (replacement == null)
                            {
                                TimeZoneOffset = new PropertyState<TimeZoneDataType>(this);
                            }
                            else
                            {
                                TimeZoneOffset = (PropertyState<TimeZoneDataType>)replacement;
                            }
                        }
                    }

                    instance = TimeZoneOffset;
                    break;
                }

                case TCD.BrowseNames.LocationName:
                {
                    if (createOrReplace)
                    {
                        if (LocationName == null)
                        {
                            if (replacement == null)
                            {
                                LocationName = new PropertyState<string>(this);
                            }
                            else
                            {
                                LocationName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LocationName;
                    break;
                }

                case TCD.BrowseNames.UserMachineName:
                {
                    if (createOrReplace)
                    {
                        if (UserMachineName == null)
                        {
                            if (replacement == null)
                            {
                                UserMachineName = new PropertyState<string>(this);
                            }
                            else
                            {
                                UserMachineName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = UserMachineName;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<TimeZoneDataType> m_timeZoneOffset;
        private PropertyState<string> m_locationName;
        private PropertyState<string> m_userMachineName;
        #endregion
    }
    #endif
    #endregion

    #region DeviceZoneState Class
    #if (!OPCUA_EXCLUDE_DeviceZoneState)
    /// <summary>
    /// Stores an instance of the DeviceZoneType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DeviceZoneState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DeviceZoneState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.DeviceZoneType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<DeviceZoneTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15175</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>DeviceZoneTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15175</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15175</uax:NumericId>" +
           "<MaintenanceInformation>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15061</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaintenanceInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15193</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15061</uax:NumericId>" +
           "<Heating>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15062</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Heating</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15062</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15063</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15063</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15088</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15088</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15090</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15090</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15118</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15118</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15120</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15120</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15127</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15127</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15128</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15128</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Heating>" +
           "<Cooling>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15131</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Cooling</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15131</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15132</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15132</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15136</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15136</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15138</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15138</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15142</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15142</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15144</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15144</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15145</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15145</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15146</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15146</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Cooling>" +
           "</MaintenanceInformation>" +
           "<Temperature>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15176</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Temperature</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15214</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15176</uax:NumericId>" +
           "<SetValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15082</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15082</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15092</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15092</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetValue>" +
           "<ActualValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15094</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActualValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15094</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15102</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15102</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</ActualValue>" +
           "<LowerTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16174</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LowerTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16174</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16178</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16178</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</LowerTolerance>" +
           "<UpperTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16180</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>UpperTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16180</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16184</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16184</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</UpperTolerance>" +
           "<MinValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16186</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MinValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16186</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16190</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16190</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MinValue>" +
           "<MaxValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16192</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaxValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16192</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16196</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16196</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MaxValue>" +
           "<SetRampDown>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15677</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampDown</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15677</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15681</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15681</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampDown>" +
           "<SetRampUp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15671</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampUp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15671</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15675</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15675</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampUp>" +
           "</Temperature>" +
           "</DeviceZoneTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MaintenanceInformationState MaintenanceInformation
        {
            get
            {
                return m_maintenanceInformation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceInformation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceInformation = value;
            }
        }

        /// <remarks />
        public ControlledParameterState Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maintenanceInformation != null)
            {
                children.Add(m_maintenanceInformation);
            }

            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.MaintenanceInformation:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceInformation == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceInformation = new MaintenanceInformationState(this);
                            }
                            else
                            {
                                MaintenanceInformation = (MaintenanceInformationState)replacement;
                            }
                        }
                    }

                    instance = MaintenanceInformation;
                    break;
                }

                case TCD.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new ControlledParameterState(this);
                            }
                            else
                            {
                                Temperature = (ControlledParameterState)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MaintenanceInformationState m_maintenanceInformation;
        private ControlledParameterState m_temperature;
        #endregion
    }
    #endif
    #endregion

    #region ControlledParameterState Class
    #if (!OPCUA_EXCLUDE_ControlledParameterState)
    /// <summary>
    /// Stores an instance of the ControlledParameterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlledParameterState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ControlledParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.ControlledParameterType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<ControlledParameterTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15214</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ControlledParameterTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15214</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15214</uax:NumericId>" +
           "<SetValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15215</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15215</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15219</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15219</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetValue>" +
           "<ActualValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15221</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ActualValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15221</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15225</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15225</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</ActualValue>" +
           "<LowerTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16198</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LowerTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16198</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16202</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16202</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</LowerTolerance>" +
           "<UpperTolerance>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16204</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>UpperTolerance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16204</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16208</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16208</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</UpperTolerance>" +
           "<MinValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16210</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MinValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16210</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16214</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16214</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MinValue>" +
           "<MaxValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16216</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaxValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16216</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=16220</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16220</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</MaxValue>" +
           "<SetRampDown>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15713</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampDown</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15713</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15780</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15780</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampDown>" +
           "<SetRampUp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15683</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>SetRampUp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15683</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>3</uax:AccessLevel>" +
           "<uax:UserAccessLevel>3</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15707</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15707</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</SetRampUp>" +
           "</ControlledParameterTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState SetValue
        {
            get
            {
                return m_setValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setValue = value;
            }
        }

        /// <remarks />
        public AnalogItemState ActualValue
        {
            get
            {
                return m_actualValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actualValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actualValue = value;
            }
        }

        /// <remarks />
        public AnalogItemState LowerTolerance
        {
            get
            {
                return m_lowerTolerance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lowerTolerance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lowerTolerance = value;
            }
        }

        /// <remarks />
        public AnalogItemState UpperTolerance
        {
            get
            {
                return m_upperTolerance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_upperTolerance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_upperTolerance = value;
            }
        }

        /// <remarks />
        public AnalogItemState MinValue
        {
            get
            {
                return m_minValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minValue = value;
            }
        }

        /// <remarks />
        public AnalogItemState MaxValue
        {
            get
            {
                return m_maxValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxValue = value;
            }
        }

        /// <remarks />
        public AnalogItemState SetRampDown
        {
            get
            {
                return m_setRampDown;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setRampDown, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setRampDown = value;
            }
        }

        /// <remarks />
        public AnalogItemState SetRampUp
        {
            get
            {
                return m_setRampUp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setRampUp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setRampUp = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setValue != null)
            {
                children.Add(m_setValue);
            }

            if (m_actualValue != null)
            {
                children.Add(m_actualValue);
            }

            if (m_lowerTolerance != null)
            {
                children.Add(m_lowerTolerance);
            }

            if (m_upperTolerance != null)
            {
                children.Add(m_upperTolerance);
            }

            if (m_minValue != null)
            {
                children.Add(m_minValue);
            }

            if (m_maxValue != null)
            {
                children.Add(m_maxValue);
            }

            if (m_setRampDown != null)
            {
                children.Add(m_setRampDown);
            }

            if (m_setRampUp != null)
            {
                children.Add(m_setRampUp);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.SetValue:
                {
                    if (createOrReplace)
                    {
                        if (SetValue == null)
                        {
                            if (replacement == null)
                            {
                                SetValue = new AnalogItemState(this);
                            }
                            else
                            {
                                SetValue = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = SetValue;
                    break;
                }

                case TCD.BrowseNames.ActualValue:
                {
                    if (createOrReplace)
                    {
                        if (ActualValue == null)
                        {
                            if (replacement == null)
                            {
                                ActualValue = new AnalogItemState(this);
                            }
                            else
                            {
                                ActualValue = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = ActualValue;
                    break;
                }

                case TCD.BrowseNames.LowerTolerance:
                {
                    if (createOrReplace)
                    {
                        if (LowerTolerance == null)
                        {
                            if (replacement == null)
                            {
                                LowerTolerance = new AnalogItemState(this);
                            }
                            else
                            {
                                LowerTolerance = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = LowerTolerance;
                    break;
                }

                case TCD.BrowseNames.UpperTolerance:
                {
                    if (createOrReplace)
                    {
                        if (UpperTolerance == null)
                        {
                            if (replacement == null)
                            {
                                UpperTolerance = new AnalogItemState(this);
                            }
                            else
                            {
                                UpperTolerance = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = UpperTolerance;
                    break;
                }

                case TCD.BrowseNames.MinValue:
                {
                    if (createOrReplace)
                    {
                        if (MinValue == null)
                        {
                            if (replacement == null)
                            {
                                MinValue = new AnalogItemState(this);
                            }
                            else
                            {
                                MinValue = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = MinValue;
                    break;
                }

                case TCD.BrowseNames.MaxValue:
                {
                    if (createOrReplace)
                    {
                        if (MaxValue == null)
                        {
                            if (replacement == null)
                            {
                                MaxValue = new AnalogItemState(this);
                            }
                            else
                            {
                                MaxValue = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = MaxValue;
                    break;
                }

                case TCD.BrowseNames.SetRampDown:
                {
                    if (createOrReplace)
                    {
                        if (SetRampDown == null)
                        {
                            if (replacement == null)
                            {
                                SetRampDown = new AnalogItemState(this);
                            }
                            else
                            {
                                SetRampDown = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = SetRampDown;
                    break;
                }

                case TCD.BrowseNames.SetRampUp:
                {
                    if (createOrReplace)
                    {
                        if (SetRampUp == null)
                        {
                            if (replacement == null)
                            {
                                SetRampUp = new AnalogItemState(this);
                            }
                            else
                            {
                                SetRampUp = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = SetRampUp;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState m_setValue;
        private AnalogItemState m_actualValue;
        private AnalogItemState m_lowerTolerance;
        private AnalogItemState m_upperTolerance;
        private AnalogItemState m_minValue;
        private AnalogItemState m_maxValue;
        private AnalogItemState m_setRampDown;
        private AnalogItemState m_setRampUp;
        #endregion
    }
    #endif
    #endregion

    #region MaintenanceState Class
    #if (!OPCUA_EXCLUDE_MaintenanceState)
    /// <summary>
    /// Stores an instance of the MaintenanceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MaintenanceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MaintenanceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.MaintenanceType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<MaintenanceTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaintenanceTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15149</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15150</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15150</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15154</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15154</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15156</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15156</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15161</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15161</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15188</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15188</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15189</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15189</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15190</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</MaintenanceTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState RemainingInterval
        {
            get
            {
                return m_remainingInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_remainingInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_remainingInterval = value;
            }
        }

        /// <remarks />
        public AnalogItemState Interval
        {
            get
            {
                return m_interval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_interval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_interval = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AdditionalInformation
        {
            get
            {
                return m_additionalInformation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_additionalInformation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_additionalInformation = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_remainingInterval != null)
            {
                children.Add(m_remainingInterval);
            }

            if (m_interval != null)
            {
                children.Add(m_interval);
            }

            if (m_additionalInformation != null)
            {
                children.Add(m_additionalInformation);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.RemainingInterval:
                {
                    if (createOrReplace)
                    {
                        if (RemainingInterval == null)
                        {
                            if (replacement == null)
                            {
                                RemainingInterval = new AnalogItemState(this);
                            }
                            else
                            {
                                RemainingInterval = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = RemainingInterval;
                    break;
                }

                case TCD.BrowseNames.Interval:
                {
                    if (createOrReplace)
                    {
                        if (Interval == null)
                        {
                            if (replacement == null)
                            {
                                Interval = new AnalogItemState(this);
                            }
                            else
                            {
                                Interval = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = Interval;
                    break;
                }

                case TCD.BrowseNames.AdditionalInformation:
                {
                    if (createOrReplace)
                    {
                        if (AdditionalInformation == null)
                        {
                            if (replacement == null)
                            {
                                AdditionalInformation = new PropertyState<string>(this);
                            }
                            else
                            {
                                AdditionalInformation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AdditionalInformation;
                    break;
                }

                case TCD.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new PropertyState<string>(this);
                            }
                            else
                            {
                                Status = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case TCD.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState m_remainingInterval;
        private AnalogItemState m_interval;
        private PropertyState<string> m_additionalInformation;
        private PropertyState<string> m_status;
        private MethodState m_resetMethod;
        #endregion
    }
    #endif
    #endregion

    #region MaintenanceInformationState Class
    #if (!OPCUA_EXCLUDE_MaintenanceInformationState)
    /// <summary>
    /// Stores an instance of the MaintenanceInformationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MaintenanceInformationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MaintenanceInformationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TCD.ObjectTypes.MaintenanceInformationType, TCD.Namespaces.TCD, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<MaintenanceInformationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://opcfoundation.org/UA/TCD/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/TCD/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15193</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>MaintenanceInformationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15193</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15193</uax:NumericId>" +
           "<Heating>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15194</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Heating</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15194</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15195</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15195</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15228</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15228</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15231</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15231</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15241</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15241</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15243</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15243</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15244</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15244</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15245</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15245</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Heating>" +
           "<Cooling>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15248</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Cooling</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15149</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15248</uax:NumericId>" +
           "<RemainingInterval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15249</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingInterval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15249</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15253</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15253</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</RemainingInterval>" +
           "<Interval>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15255</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Interval</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15255</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15259</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15259</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Interval>" +
           "<AdditionalInformation>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15261</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>AdditionalInformation</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15261</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AdditionalInformation>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15262</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15262</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "<Reset>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=1;i=15263</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Reset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=15190</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15263</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Reset>" +
           "</Cooling>" +
           "</MaintenanceInformationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MaintenanceState Heating
        {
            get
            {
                return m_heating;
            }

            set
            {
                if (!Object.ReferenceEquals(m_heating, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_heating = value;
            }
        }

        /// <remarks />
        public MaintenanceState Cooling
        {
            get
            {
                return m_cooling;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cooling, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cooling = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_heating != null)
            {
                children.Add(m_heating);
            }

            if (m_cooling != null)
            {
                children.Add(m_cooling);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TCD.BrowseNames.Heating:
                {
                    if (createOrReplace)
                    {
                        if (Heating == null)
                        {
                            if (replacement == null)
                            {
                                Heating = new MaintenanceState(this);
                            }
                            else
                            {
                                Heating = (MaintenanceState)replacement;
                            }
                        }
                    }

                    instance = Heating;
                    break;
                }

                case TCD.BrowseNames.Cooling:
                {
                    if (createOrReplace)
                    {
                        if (Cooling == null)
                        {
                            if (replacement == null)
                            {
                                Cooling = new MaintenanceState(this);
                            }
                            else
                            {
                                Cooling = (MaintenanceState)replacement;
                            }
                        }
                    }

                    instance = Cooling;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MaintenanceState m_heating;
        private MaintenanceState m_cooling;
        #endregion
    }
    #endif
    #endregion
}