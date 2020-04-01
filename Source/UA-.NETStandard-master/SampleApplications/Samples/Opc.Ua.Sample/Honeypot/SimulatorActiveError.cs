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
using TCD;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// Subclass of the library class ActiveErrorDataType to provide a constructor that initialises 
    /// all fields, so that static instances can be initialised on declaration. 
    /// </summary>
    class SimulatorActiveError : ActiveErrorDataType 
    {
        public SimulatorActiveError(String id, ushort severity, String message)
        {
            Id = id;
            Severity = severity;
            Message = new LocalizedText("en-US", message);
        }
    }
}
