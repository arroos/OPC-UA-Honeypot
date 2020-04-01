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
using System.Text;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// Base class for entries used to construct logs. 
    /// </summary>
    abstract public partial class Entry
    {
        /// <summary>
        /// Generate the JSON represenation of this entry. 
        /// </summary>
        /// <returns>The JSON text.</returns>
        abstract public String JsonText();

        /// <summary>
        /// Enclose a string in double quotes and escape any backslashes or double quotes in the string. 
        /// </summary>
        /// <param name="s">The string to quote and escape.</param>
        /// <returns>The quoted string.</returns>
        protected static string QuoteAndEscape(string s)
        {
            if (s == null)
            {
                return "null";
            }
            else
            {
                StringBuilder sb = new StringBuilder("\"");
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '"':
                            sb.Append("\\\"");
                            break;
                        case '\\':
                            sb.Append("\\\\");
                            break;
                        default:
                            sb.Append(s[i]);
                            break;
                    }
                }
                sb.Append("\"");
                return sb.ToString();
            }
        }
    }

    /// <summary>
    /// An entry consisting of a single signed integer. 
    /// </summary>
    public class IntegerEntry : Entry
    {
        public IntegerEntry(int value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return m_value.ToString();
        }

        private int m_value;
    }

    /// <summary>
    /// An entry consisting of a single unsigned integer. 
    /// </summary>
    public class UnsignedEntry : Entry
    {
        public UnsignedEntry(uint value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return m_value.ToString();
        }

        private uint m_value;
    }

    /// <summary>
    /// An entry consisting of a single double. 
    /// </summary>
    public class DoubleEntry : Entry
    {
        public DoubleEntry(double value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return m_value.ToString();
        }

        private double m_value;
    }

    /// <summary>
    /// An entry consisting of a single string. 
    /// </summary>
    public class StringEntry : Entry
    {
        public StringEntry(string value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return QuoteAndEscape(m_value);
        }

        private string m_value;
    }

    /// <summary>
    /// An easy way to create entries that signify "nothing", which are represented as null-valued
    /// string entries.
    /// </summary>
    public class NullEntry : StringEntry
    {
        public NullEntry() : base(null)
        {
        }
    }

    /// <summary>
    /// An entry consisting of a single boolean.
    /// </summary>
    public class BooleanEntry : Entry
    {
        public BooleanEntry(bool value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return (m_value ? "true" : "false");
        }

        private bool m_value;
    }

    /// <summary>
    /// An entry consisting of a date and time. 
    /// </summary>
    public class DateTimeEntry : Entry
    {
        public DateTimeEntry(DateTime value)
        {
            m_value = value;
        }
        public override String JsonText()
        {
            return QuoteAndEscape(m_value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }

        private DateTime m_value;
    }

    /// <summary>
    /// An entry that represents an object, which has multiple named fields (each of which is an entry). 
    /// </summary>
    public class ObjectEntry : Entry
    {
        /// <summary>
        /// Add a named field to the object.
        /// </summary>
        /// <param name="name">The field name.</param>
        /// <param name="value">The field vaue.</param>
        public void Add (String name, Entry value)
        {
            m_nameValuePairs.Add(new NameValuePair(name, value));
        }

        /// <summary>
        /// Get the JSON representation of the object.
        /// </summary>
        /// <returns>The JSON representation.</returns>
        public override String JsonText()
        {           
            StringBuilder sb = new StringBuilder("{");
            List<NameValuePair>.Enumerator e = m_nameValuePairs.GetEnumerator();
            bool isFirst = true;
            while (e.MoveNext())
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    sb.Append(",");
                }
                sb.Append(QuoteAndEscape(e.Current.getName()));
                sb.Append(":");
                sb.Append(e.Current.getValue().JsonText());
            }            
            return sb.Append("}").ToString();
        }

        /// <summary>
        /// List of the field names and values for this object. 
        /// </summary>
        private List<NameValuePair> m_nameValuePairs = new List<NameValuePair>();
    }

    /// <summary>
    /// An entry that represents an array, which can store multiple (unnamed) values.
    /// </summary>
    public class ArrayEntry : Entry
    {
        /// <summary>
        /// Add a new value to the array.
        /// </summary>
        /// <param name="value">The value to add.</param>
        public void Add(Entry value)
        {
            m_values.Add(value);
        }
        /// <summary>
        /// Get the JSON representation of the array.
        /// </summary>
        /// <returns>The JSON representation.</returns>
        public override String JsonText()
        {
            StringBuilder sb = new StringBuilder("[");
            List<Entry>.Enumerator e = m_values.GetEnumerator();
            bool isFirst = true;
            while (e.MoveNext())
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    sb.Append(",");
                }
                sb.Append(e.Current.JsonText());
            }
            sb.Append("]");
            return sb.ToString();
        }

        /// <summary>
        /// The array values. 
        /// </summary>
        private List<Entry> m_values = new List<Entry>();
    }

    /// <summary>
    /// An immutable name and value.
    /// </summary>
    public class NameValuePair
    {
        public NameValuePair(String name, Entry value)
        {
            m_name = name;
            m_value = value;
        }

        public String getName()
        {
            return m_name;
        }

        public Entry getValue()
        {
            return m_value;
        }

        private readonly String m_name;
        private readonly Entry m_value;
    }
}
