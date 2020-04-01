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
    #region TimeZoneDataType Class
    #if (!OPCUA_EXCLUDE_TimeZoneDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = TCD.Namespaces.TCD)]
    public partial class TimeZoneDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public TimeZoneDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_offset = (ushort)0;
            m_daylightSavingInOffset = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "offset", IsRequired = false, Order = 1)]
        public ushort offset
        {
            get { return m_offset;  }
            set { m_offset = value; }
        }

        /// <remarks />
        [DataMember(Name = "daylightSavingInOffset", IsRequired = false, Order = 2)]
        public bool daylightSavingInOffset
        {
            get { return m_daylightSavingInOffset;  }
            set { m_daylightSavingInOffset = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.TimeZoneDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.TimeZoneDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.TimeZoneDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TCD.Namespaces.TCD);

            encoder.WriteUInt16("offset", offset);
            encoder.WriteBoolean("daylightSavingInOffset", daylightSavingInOffset);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TCD.Namespaces.TCD);

            offset = decoder.ReadUInt16("offset");
            daylightSavingInOffset = decoder.ReadBoolean("daylightSavingInOffset");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TimeZoneDataType value = encodeable as TimeZoneDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_offset, value.m_offset)) return false;
            if (!Utils.IsEqual(m_daylightSavingInOffset, value.m_daylightSavingInOffset)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (TimeZoneDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TimeZoneDataType clone = (TimeZoneDataType)base.MemberwiseClone();

            clone.m_offset = (ushort)Utils.Clone(this.m_offset);
            clone.m_daylightSavingInOffset = (bool)Utils.Clone(this.m_daylightSavingInOffset);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_offset;
        private bool m_daylightSavingInOffset;
        #endregion
    }

    #region TimeZoneDataTypeCollection Class
    /// <summary>
    /// A collection of TimeZoneDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfTimeZoneDataType", Namespace = TCD.Namespaces.TCD, ItemName = "TimeZoneDataType")]
    #if !NET_STANDARD
    public partial class TimeZoneDataTypeCollection : List<TimeZoneDataType>, ICloneable
    #else
    public partial class TimeZoneDataTypeCollection : List<TimeZoneDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public TimeZoneDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public TimeZoneDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public TimeZoneDataTypeCollection(IEnumerable<TimeZoneDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator TimeZoneDataTypeCollection(TimeZoneDataType[] values)
        {
            if (values != null)
            {
                return new TimeZoneDataTypeCollection(values);
            }

            return new TimeZoneDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator TimeZoneDataType[](TimeZoneDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (TimeZoneDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            TimeZoneDataTypeCollection clone = new TimeZoneDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TimeZoneDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ActiveErrorDataType Class
    #if (!OPCUA_EXCLUDE_ActiveErrorDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = TCD.Namespaces.TCD)]
    public partial class ActiveErrorDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ActiveErrorDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_id = null;
            m_severity = (ushort)0;
            m_message = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Id", IsRequired = false, Order = 1)]
        public string Id
        {
            get { return m_id;  }
            set { m_id = value; }
        }

        /// <remarks />
        [DataMember(Name = "Severity", IsRequired = false, Order = 2)]
        public ushort Severity
        {
            get { return m_severity;  }
            set { m_severity = value; }
        }

        /// <remarks />
        [DataMember(Name = "Message", IsRequired = false, Order = 3)]
        public LocalizedText Message
        {
            get { return m_message;  }
            set { m_message = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ActiveErrorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ActiveErrorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ActiveErrorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(TCD.Namespaces.TCD);

            encoder.WriteString("Id", Id);
            encoder.WriteUInt16("Severity", Severity);
            encoder.WriteLocalizedText("Message", Message);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(TCD.Namespaces.TCD);

            Id = decoder.ReadString("Id");
            Severity = decoder.ReadUInt16("Severity");
            Message = decoder.ReadLocalizedText("Message");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ActiveErrorDataType value = encodeable as ActiveErrorDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_id, value.m_id)) return false;
            if (!Utils.IsEqual(m_severity, value.m_severity)) return false;
            if (!Utils.IsEqual(m_message, value.m_message)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ActiveErrorDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ActiveErrorDataType clone = (ActiveErrorDataType)base.MemberwiseClone();

            clone.m_id = (string)Utils.Clone(this.m_id);
            clone.m_severity = (ushort)Utils.Clone(this.m_severity);
            clone.m_message = (LocalizedText)Utils.Clone(this.m_message);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_id;
        private ushort m_severity;
        private LocalizedText m_message;
        #endregion
    }

    #region ActiveErrorDataTypeCollection Class
    /// <summary>
    /// A collection of ActiveErrorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfActiveErrorDataType", Namespace = TCD.Namespaces.TCD, ItemName = "ActiveErrorDataType")]
    #if !NET_STANDARD
    public partial class ActiveErrorDataTypeCollection : List<ActiveErrorDataType>, ICloneable
    #else
    public partial class ActiveErrorDataTypeCollection : List<ActiveErrorDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ActiveErrorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ActiveErrorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ActiveErrorDataTypeCollection(IEnumerable<ActiveErrorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ActiveErrorDataTypeCollection(ActiveErrorDataType[] values)
        {
            if (values != null)
            {
                return new ActiveErrorDataTypeCollection(values);
            }

            return new ActiveErrorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ActiveErrorDataType[](ActiveErrorDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ActiveErrorDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ActiveErrorDataTypeCollection clone = new ActiveErrorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ActiveErrorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}