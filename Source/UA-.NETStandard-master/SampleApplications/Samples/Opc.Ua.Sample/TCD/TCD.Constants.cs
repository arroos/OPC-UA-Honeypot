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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TCD
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the TimeZoneDataType DataType.
        /// </summary>
        public const uint TimeZoneDataType = 15004;

        /// <summary>
        /// The identifier for the ActiveErrorDataType DataType.
        /// </summary>
        public const uint ActiveErrorDataType = 15007;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors Method.
        /// </summary>
        public const uint OperationType_ResetAllErrors = 15755;

        /// <summary>
        /// The identifier for the OperationType_SwitchOn Method.
        /// </summary>
        public const uint OperationType_SwitchOn = 15064;

        /// <summary>
        /// The identifier for the OperationType_SwitchOff Method.
        /// </summary>
        public const uint OperationType_SwitchOff = 15067;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Reset = 15029;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Reset = 15058;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint TCD_Interface_Operation_ResetAllErrors = 15758;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_SwitchOn Method.
        /// </summary>
        public const uint TCD_Interface_Operation_SwitchOn = 15121;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_SwitchOff Method.
        /// </summary>
        public const uint TCD_Interface_Operation_SwitchOff = 15124;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_Reset = 15128;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_Reset = 15146;

        /// <summary>
        /// The identifier for the MaintenanceType_Reset Method.
        /// </summary>
        public const uint MaintenanceType_Reset = 15190;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Reset Method.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_Reset = 15245;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Reset Method.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_Reset = 15263;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Reset = 15318;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Reset = 15342;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_ResetAllErrors = 15761;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_SwitchOn = 15732;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_SwitchOff = 15735;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Reset = 15362;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Reset = 15421;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_ResetAllErrors = 15764;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_SwitchOn = 15235;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_SwitchOff = 15238;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Reset = 15440;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Reset = 15494;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_ResetAllErrors = 15767;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_SwitchOn = 15323;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_SwitchOff = 15326;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Reset = 15519;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Reset = 15564;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_ResetAllErrors = 15771;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_SwitchOn = 15411;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_SwitchOff = 15414;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Reset = 15728;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Reset = 15752;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_ResetAllErrors = 16147;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_SwitchOn = 15613;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_SwitchOff = 15616;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Reset = 16384;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Reset = 16402;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_ResetAllErrors Method.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_ResetAllErrors = 16469;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_SwitchOn Method.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_SwitchOn = 16472;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_SwitchOff Method.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_SwitchOff = 16475;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone Object.
        /// </summary>
        public const uint TCD_Interface_DeviceZone = 15071;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation = 15009;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating = 15010;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling = 15032;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature Object.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature = 15072;

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration Object.
        /// </summary>
        public const uint TCD_Interface_MachineConfiguration = 15097;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation Object.
        /// </summary>
        public const uint TCD_Interface_Operation = 15104;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification Object.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification = 15884;

        /// <summary>
        /// The identifier for the TCD_Interface_Identification Object.
        /// </summary>
        public const uint TCD_Interface_Identification = 15158;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation = 15061;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating = 15062;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling = 15131;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature Object.
        /// </summary>
        public const uint DeviceZoneType_Temperature = 15176;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating Object.
        /// </summary>
        public const uint MaintenanceInformationType_Heating = 15194;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling Object.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling = 15248;

        /// <summary>
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public const uint DeviceSet = 15227;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02 Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02 = 15230;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone = 15687;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation = 15266;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating = 15267;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling = 15321;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature = 15688;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_MachineConfiguration = 15708;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation = 15715;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification = 15921;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Identification = 15769;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24 Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24 = 15081;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone = 15166;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation = 15345;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating = 15346;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling = 15385;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature = 15172;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_MachineConfiguration = 15199;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation = 15203;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification = 15958;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Identification = 15272;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06 Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06 = 15281;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone = 15282;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation = 15424;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating = 15425;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling = 15443;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature = 15283;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_MachineConfiguration = 15302;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation = 15306;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification = 15995;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Identification = 15360;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03 Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03 = 15369;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone = 15370;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation = 15497;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating = 15498;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling = 15522;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature = 15371;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_MachineConfiguration = 15390;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation = 15394;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification = 16032;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Identification = 15448;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21 Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21 = 15571;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone = 15572;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation = 15645;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating = 15646;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling = 15731;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature = 15573;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_MachineConfiguration = 15592;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation = 15596;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification = 16106;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Identification = 15650;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521 Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521 = 16366;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone = 16367;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation = 16368;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating = 16369;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling = 16387;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature = 16405;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_MachineConfiguration = 16454;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation = 16458;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification = 16478;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification Object.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Identification = 16515;

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint TimeZoneDataType_Encoding_DefaultBinary = 15525;

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ActiveErrorDataType_Encoding_DefaultBinary = 15526;

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint TimeZoneDataType_Encoding_DefaultXml = 15537;

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ActiveErrorDataType_Encoding_DefaultXml = 15538;

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint TimeZoneDataType_Encoding_DefaultJson = 15549;

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint ActiveErrorDataType_Encoding_DefaultJson = 15550;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the IdentificationType ObjectType.
        /// </summary>
        public const uint IdentificationType = 15008;

        /// <summary>
        /// The identifier for the TCDSpecificationType ObjectType.
        /// </summary>
        public const uint TCDSpecificationType = 15167;

        /// <summary>
        /// The identifier for the OperationType ObjectType.
        /// </summary>
        public const uint OperationType = 15047;

        /// <summary>
        /// The identifier for the TCD_Interface ObjectType.
        /// </summary>
        public const uint TCD_Interface = 15070;

        /// <summary>
        /// The identifier for the MachineConfigurationType ObjectType.
        /// </summary>
        public const uint MachineConfigurationType = 15168;

        /// <summary>
        /// The identifier for the DeviceZoneType ObjectType.
        /// </summary>
        public const uint DeviceZoneType = 15175;

        /// <summary>
        /// The identifier for the ControlledParameterType ObjectType.
        /// </summary>
        public const uint ControlledParameterType = 15214;

        /// <summary>
        /// The identifier for the MaintenanceType ObjectType.
        /// </summary>
        public const uint MaintenanceType = 15149;

        /// <summary>
        /// The identifier for the MaintenanceInformationType ObjectType.
        /// </summary>
        public const uint MaintenanceInformationType = 15193;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the IdentificationType_SerialNumber Variable.
        /// </summary>
        public const uint IdentificationType_SerialNumber = 15012;

        /// <summary>
        /// The identifier for the IdentificationType_Model Variable.
        /// </summary>
        public const uint IdentificationType_Model = 15013;

        /// <summary>
        /// The identifier for the IdentificationType_Manufacturer Variable.
        /// </summary>
        public const uint IdentificationType_Manufacturer = 15014;

        /// <summary>
        /// The identifier for the IdentificationType_DeviceClass Variable.
        /// </summary>
        public const uint IdentificationType_DeviceClass = 15015;

        /// <summary>
        /// The identifier for the TCDSpecificationType_CoolingCapacity Variable.
        /// </summary>
        public const uint TCDSpecificationType_CoolingCapacity = 15280;

        /// <summary>
        /// The identifier for the TCDSpecificationType_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_CoolingCapacity_EURange = 15658;

        /// <summary>
        /// The identifier for the TCDSpecificationType_ConnectedLoad Variable.
        /// </summary>
        public const uint TCDSpecificationType_ConnectedLoad = 15854;

        /// <summary>
        /// The identifier for the TCDSpecificationType_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_ConnectedLoad_EURange = 15858;

        /// <summary>
        /// The identifier for the TCDSpecificationType_NominalFlowRate Variable.
        /// </summary>
        public const uint TCDSpecificationType_NominalFlowRate = 15860;

        /// <summary>
        /// The identifier for the TCDSpecificationType_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_NominalFlowRate_EURange = 15864;

        /// <summary>
        /// The identifier for the TCDSpecificationType_PowerValue Variable.
        /// </summary>
        public const uint TCDSpecificationType_PowerValue = 15866;

        /// <summary>
        /// The identifier for the TCDSpecificationType_PowerValue_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_PowerValue_EURange = 15870;

        /// <summary>
        /// The identifier for the TCDSpecificationType_MaxTemperature Variable.
        /// </summary>
        public const uint TCDSpecificationType_MaxTemperature = 15872;

        /// <summary>
        /// The identifier for the TCDSpecificationType_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_MaxTemperature_EURange = 15876;

        /// <summary>
        /// The identifier for the TCDSpecificationType_MinTemperature Variable.
        /// </summary>
        public const uint TCDSpecificationType_MinTemperature = 15878;

        /// <summary>
        /// The identifier for the TCDSpecificationType_MinTemperature_EURange Variable.
        /// </summary>
        public const uint TCDSpecificationType_MinTemperature_EURange = 15882;

        /// <summary>
        /// The identifier for the OperationType_ActiveErrors Variable.
        /// </summary>
        public const uint OperationType_ActiveErrors = 15048;

        /// <summary>
        /// The identifier for the OperationType_HoursOfOperation Variable.
        /// </summary>
        public const uint OperationType_HoursOfOperation = 15049;

        /// <summary>
        /// The identifier for the OperationType_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint OperationType_HoursOfOperation_EURange = 15053;

        /// <summary>
        /// The identifier for the OperationType_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint OperationType_HighestActiveAlarmSeverity = 15055;

        /// <summary>
        /// The identifier for the OperationType_DeviceMappingNumber Variable.
        /// </summary>
        public const uint OperationType_DeviceMappingNumber = 15056;

        /// <summary>
        /// The identifier for the OperationType_OperatingMode Variable.
        /// </summary>
        public const uint OperationType_OperatingMode = 15057;

        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors_InputArguments Variable.
        /// </summary>
        public const uint OperationType_ResetAllErrors_InputArguments = 15756;

        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors_OutputArguments Variable.
        /// </summary>
        public const uint OperationType_ResetAllErrors_OutputArguments = 15757;

        /// <summary>
        /// The identifier for the OperationType_SwitchOn_InputArguments Variable.
        /// </summary>
        public const uint OperationType_SwitchOn_InputArguments = 15065;

        /// <summary>
        /// The identifier for the OperationType_SwitchOn_OutputArguments Variable.
        /// </summary>
        public const uint OperationType_SwitchOn_OutputArguments = 15066;

        /// <summary>
        /// The identifier for the OperationType_SwitchOff_InputArguments Variable.
        /// </summary>
        public const uint OperationType_SwitchOff_InputArguments = 15068;

        /// <summary>
        /// The identifier for the OperationType_SwitchOff_OutputArguments Variable.
        /// </summary>
        public const uint OperationType_SwitchOff_OutputArguments = 15069;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15011;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15019;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval = 15021;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15025;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15027;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Status = 15028;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15033;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15037;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval = 15039;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15043;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15045;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Status = 15046;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetValue = 15002;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetValue_EURange = 15073;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_ActualValue = 15075;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_ActualValue_EURange = 15079;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_LowerTolerance = 16150;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_LowerTolerance_EURange = 16154;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_UpperTolerance = 16156;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_UpperTolerance_EURange = 16160;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_MinValue = 16162;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_MinValue_EURange = 16166;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_MaxValue = 16168;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_MaxValue_EURange = 16172;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetRampDown = 15665;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetRampDown_EURange = 15669;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetRampUp = 15659;

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_DeviceZone_Temperature_SetRampUp_EURange = 15663;

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint TCD_Interface_MachineConfiguration_TimeZoneOffset = 15098;

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint TCD_Interface_MachineConfiguration_LocationName = 15099;

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint TCD_Interface_MachineConfiguration_UserMachineName = 15100;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_ActiveErrors = 15105;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_HoursOfOperation = 15106;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_HoursOfOperation_EURange = 15110;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_HighestActiveAlarmSeverity = 15112;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_DeviceMappingNumber = 15113;

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_OperatingMode Variable.
        /// </summary>
        public const uint TCD_Interface_Operation_OperatingMode = 15114;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_CoolingCapacity = 15885;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_CoolingCapacity_EURange = 15889;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_ConnectedLoad = 15891;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_ConnectedLoad_EURange = 15895;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_NominalFlowRate = 15897;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_NominalFlowRate_EURange = 15901;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_PowerValue = 15903;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_PowerValue_EURange = 15907;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_MaxTemperature = 15909;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_MaxTemperature_EURange = 15913;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_MinTemperature = 15915;

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint TCD_Interface_TCDSpecification_MinTemperature_EURange = 15919;

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_SerialNumber Variable.
        /// </summary>
        public const uint TCD_Interface_Identification_SerialNumber = 15162;

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_Model Variable.
        /// </summary>
        public const uint TCD_Interface_Identification_Model = 15163;

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_Manufacturer Variable.
        /// </summary>
        public const uint TCD_Interface_Identification_Manufacturer = 15164;

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_DeviceClass Variable.
        /// </summary>
        public const uint TCD_Interface_Identification_DeviceClass = 15165;

        /// <summary>
        /// The identifier for the MachineConfigurationType_TimeZoneOffset Variable.
        /// </summary>
        public const uint MachineConfigurationType_TimeZoneOffset = 15169;

        /// <summary>
        /// The identifier for the MachineConfigurationType_LocationName Variable.
        /// </summary>
        public const uint MachineConfigurationType_LocationName = 15170;

        /// <summary>
        /// The identifier for the MachineConfigurationType_UserMachineName Variable.
        /// </summary>
        public const uint MachineConfigurationType_UserMachineName = 15171;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval = 15063;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval_EURange = 15088;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_Interval = 15090;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_Interval_EURange = 15118;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_AdditionalInformation = 15120;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Heating_Status = 15127;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval = 15132;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15136;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_Interval = 15138;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_Interval_EURange = 15142;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_AdditionalInformation = 15144;

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceZoneType_MaintenanceInformation_Cooling_Status = 15145;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetValue = 15082;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetValue_EURange = 15092;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_ActualValue = 15094;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_ActualValue_EURange = 15102;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_LowerTolerance = 16174;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_LowerTolerance_EURange = 16178;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_UpperTolerance = 16180;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_UpperTolerance_EURange = 16184;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_MinValue = 16186;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_MinValue_EURange = 16190;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_MaxValue = 16192;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_MaxValue_EURange = 16196;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetRampDown = 15677;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetRampDown_EURange = 15681;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetRampUp = 15671;

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceZoneType_Temperature_SetRampUp_EURange = 15675;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetValue Variable.
        /// </summary>
        public const uint ControlledParameterType_SetValue = 15215;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetValue_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_SetValue_EURange = 15219;

        /// <summary>
        /// The identifier for the ControlledParameterType_ActualValue Variable.
        /// </summary>
        public const uint ControlledParameterType_ActualValue = 15221;

        /// <summary>
        /// The identifier for the ControlledParameterType_ActualValue_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_ActualValue_EURange = 15225;

        /// <summary>
        /// The identifier for the ControlledParameterType_LowerTolerance Variable.
        /// </summary>
        public const uint ControlledParameterType_LowerTolerance = 16198;

        /// <summary>
        /// The identifier for the ControlledParameterType_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_LowerTolerance_EURange = 16202;

        /// <summary>
        /// The identifier for the ControlledParameterType_UpperTolerance Variable.
        /// </summary>
        public const uint ControlledParameterType_UpperTolerance = 16204;

        /// <summary>
        /// The identifier for the ControlledParameterType_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_UpperTolerance_EURange = 16208;

        /// <summary>
        /// The identifier for the ControlledParameterType_MinValue Variable.
        /// </summary>
        public const uint ControlledParameterType_MinValue = 16210;

        /// <summary>
        /// The identifier for the ControlledParameterType_MinValue_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_MinValue_EURange = 16214;

        /// <summary>
        /// The identifier for the ControlledParameterType_MaxValue Variable.
        /// </summary>
        public const uint ControlledParameterType_MaxValue = 16216;

        /// <summary>
        /// The identifier for the ControlledParameterType_MaxValue_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_MaxValue_EURange = 16220;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampDown Variable.
        /// </summary>
        public const uint ControlledParameterType_SetRampDown = 15713;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampDown_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_SetRampDown_EURange = 15780;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampUp Variable.
        /// </summary>
        public const uint ControlledParameterType_SetRampUp = 15683;

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampUp_EURange Variable.
        /// </summary>
        public const uint ControlledParameterType_SetRampUp_EURange = 15707;

        /// <summary>
        /// The identifier for the MaintenanceType_RemainingInterval Variable.
        /// </summary>
        public const uint MaintenanceType_RemainingInterval = 15150;

        /// <summary>
        /// The identifier for the MaintenanceType_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint MaintenanceType_RemainingInterval_EURange = 15154;

        /// <summary>
        /// The identifier for the MaintenanceType_Interval Variable.
        /// </summary>
        public const uint MaintenanceType_Interval = 15156;

        /// <summary>
        /// The identifier for the MaintenanceType_Interval_EURange Variable.
        /// </summary>
        public const uint MaintenanceType_Interval_EURange = 15161;

        /// <summary>
        /// The identifier for the MaintenanceType_AdditionalInformation Variable.
        /// </summary>
        public const uint MaintenanceType_AdditionalInformation = 15188;

        /// <summary>
        /// The identifier for the MaintenanceType_Status Variable.
        /// </summary>
        public const uint MaintenanceType_Status = 15189;

        /// <summary>
        /// The identifier for the MaintenanceType_Reset_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceType_Reset_InputArguments = 15191;

        /// <summary>
        /// The identifier for the MaintenanceType_Reset_OutputArguments Variable.
        /// </summary>
        public const uint MaintenanceType_Reset_OutputArguments = 15192;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_RemainingInterval = 15195;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_RemainingInterval_EURange = 15228;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Interval Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_Interval = 15231;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_Interval_EURange = 15241;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_AdditionalInformation = 15243;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Status Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Heating_Status = 15244;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_RemainingInterval = 15249;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_RemainingInterval_EURange = 15253;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Interval Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_Interval = 15255;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_Interval_EURange = 15259;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_AdditionalInformation = 15261;

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Status Variable.
        /// </summary>
        public const uint MaintenanceInformationType_Cooling_Status = 15262;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15268;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15273;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval = 15275;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15299;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15301;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Status = 15317;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15322;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15332;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval = 15334;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15338;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15340;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Status = 15341;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue = 15689;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue_EURange = 15693;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue = 15695;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue_EURange = 15699;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance = 16222;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance_EURange = 16226;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance = 16228;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance_EURange = 16232;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue = 16234;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue_EURange = 16238;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue = 16240;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue_EURange = 16244;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown = 15788;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown_EURange = 15792;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp = 15782;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp_EURange = 15786;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_MachineConfiguration_TimeZoneOffset = 15709;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_MachineConfiguration_LocationName = 15710;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_MachineConfiguration_UserMachineName = 15711;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_ActiveErrors = 15716;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation = 15717;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation_EURange = 15721;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_HighestActiveAlarmSeverity = 15723;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_DeviceMappingNumber = 15724;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Operation_OperatingMode = 15725;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity = 15922;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity_EURange = 15926;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad = 15928;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad_EURange = 15932;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate = 15934;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate_EURange = 15938;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue = 15940;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue_EURange = 15944;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature = 15946;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature_EURange = 15950;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature = 15952;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature_EURange = 15956;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Identification_SerialNumber = 15773;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Identification_Model = 15774;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Identification_Manufacturer = 15775;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_30293_02_Identification_DeviceClass = 15776;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15347;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15351;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval = 15353;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15357;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15359;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Status = 15361;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15386;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15405;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval = 15407;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15417;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15419;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Status = 15420;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue = 15173;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue_EURange = 15179;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue = 15181;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue_EURange = 15185;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance = 16246;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance_EURange = 16250;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance = 16252;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance_EURange = 16256;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue = 16258;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue_EURange = 16262;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue = 16264;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue_EURange = 16268;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown = 15800;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown_EURange = 15804;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp = 15794;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp_EURange = 15798;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_MachineConfiguration_TimeZoneOffset = 15200;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_MachineConfiguration_LocationName = 15201;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_MachineConfiguration_UserMachineName = 15202;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_ActiveErrors = 15204;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation = 15205;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation_EURange = 15209;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_HighestActiveAlarmSeverity = 15211;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_DeviceMappingNumber = 15212;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Operation_OperatingMode = 15213;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity = 15959;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity_EURange = 15963;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad = 15965;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad_EURange = 15969;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate = 15971;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate_EURange = 15975;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue = 15977;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue_EURange = 15981;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature = 15983;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature_EURange = 15987;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature = 15989;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature_EURange = 15993;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Identification_SerialNumber = 15276;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Identification_Model = 15277;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Identification_Manufacturer = 15278;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_11090_24_Identification_DeviceClass = 15279;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15426;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15430;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval = 15432;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15436;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15438;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Status = 15439;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15444;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15449;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval = 15451;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15475;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15477;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Status = 15493;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue = 15284;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue_EURange = 15288;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue = 15290;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue_EURange = 15294;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance = 16270;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance_EURange = 16274;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance = 16276;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance_EURange = 16280;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue = 16282;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue_EURange = 16286;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue = 16288;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue_EURange = 16292;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown = 15812;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown_EURange = 15816;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp = 15806;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp_EURange = 15810;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_MachineConfiguration_TimeZoneOffset = 15303;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_MachineConfiguration_LocationName = 15304;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_MachineConfiguration_UserMachineName = 15305;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_ActiveErrors = 15307;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation = 15308;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation_EURange = 15312;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_HighestActiveAlarmSeverity = 15314;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_DeviceMappingNumber = 15315;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Operation_OperatingMode = 15316;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity = 15996;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity_EURange = 16000;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad = 16002;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad_EURange = 16006;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate = 16008;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate_EURange = 16012;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue = 16014;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue_EURange = 16018;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature = 16020;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature_EURange = 16024;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature = 16026;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature_EURange = 16030;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Identification_SerialNumber = 15364;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Identification_Model = 15365;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Identification_Manufacturer = 15366;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_26179_06_Identification_DeviceClass = 15367;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15505;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15509;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval = 15511;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15515;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15517;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Status = 15518;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15523;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15553;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval = 15555;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15559;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15561;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Status = 15563;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue = 15372;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue_EURange = 15376;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue = 15378;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue_EURange = 15382;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance = 16294;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance_EURange = 16298;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance = 16300;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance_EURange = 16304;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue = 16306;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue_EURange = 16310;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue = 16312;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue_EURange = 16316;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown = 15824;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown_EURange = 15828;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp = 15818;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp_EURange = 15822;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_MachineConfiguration_TimeZoneOffset = 15391;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_MachineConfiguration_LocationName = 15392;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_MachineConfiguration_UserMachineName = 15393;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_ActiveErrors = 15395;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation = 15396;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation_EURange = 15400;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_HighestActiveAlarmSeverity = 15402;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_DeviceMappingNumber = 15403;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Operation_OperatingMode = 15404;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity = 16033;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity_EURange = 16037;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad = 16039;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad_EURange = 16043;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate = 16045;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate_EURange = 16049;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue = 16051;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue_EURange = 16055;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature = 16057;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature_EURange = 16061;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature = 16063;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature_EURange = 16067;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Identification_SerialNumber = 15452;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Identification_Model = 15453;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Identification_Manufacturer = 15454;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_22507_03_Identification_DeviceClass = 15455;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 15647;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 15652;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval = 15701;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 15705;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 15726;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Status = 15727;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 15738;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 15742;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval = 15744;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 15748;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 15750;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Status = 15751;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue = 15574;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue_EURange = 15578;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue = 15580;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue_EURange = 15584;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance = 16342;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance_EURange = 16346;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance = 16348;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance_EURange = 16352;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue = 16354;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue_EURange = 16358;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue = 16360;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue_EURange = 16364;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown = 15848;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown_EURange = 15852;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp = 15842;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp_EURange = 15846;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_MachineConfiguration_TimeZoneOffset = 15593;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_MachineConfiguration_LocationName = 15594;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_MachineConfiguration_UserMachineName = 15595;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_ActiveErrors = 15597;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation = 15598;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation_EURange = 15602;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_HighestActiveAlarmSeverity = 15604;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_DeviceMappingNumber = 15605;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Operation_OperatingMode = 15606;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity = 16107;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity_EURange = 16111;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad = 16113;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad_EURange = 16117;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate = 16119;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate_EURange = 16123;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue = 16125;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue_EURange = 16129;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature = 16131;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature_EURange = 16135;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature = 16137;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature_EURange = 16141;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Identification_SerialNumber = 15654;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Identification_Model = 15655;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Identification_Manufacturer = 15656;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_TPS_13502_21_Identification_DeviceClass = 15657;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = 16370;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = 16374;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval = 16376;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = 16380;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = 16382;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Status = 16383;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = 16388;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = 16392;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval = 16394;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = 16398;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = 16400;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Status = 16401;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue = 16406;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue_EURange = 16410;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue = 16412;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue_EURange = 16416;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance = 16418;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance_EURange = 16422;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance = 16424;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance_EURange = 16428;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue = 16430;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue_EURange = 16434;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue = 16436;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue_EURange = 16440;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown = 16442;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown_EURange = 16446;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp = 16448;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp_EURange = 16452;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_MachineConfiguration_TimeZoneOffset = 16455;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_LocationName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_MachineConfiguration_LocationName = 16456;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_MachineConfiguration_UserMachineName = 16457;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_ActiveErrors Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_ActiveErrors = 16459;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation = 16460;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation_EURange = 16464;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_HighestActiveAlarmSeverity = 16466;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_DeviceMappingNumber = 16467;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_OperatingMode Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Operation_OperatingMode = 16468;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity = 16479;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity_EURange = 16483;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad = 16485;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad_EURange = 16489;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate = 16491;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate_EURange = 16495;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue = 16497;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue_EURange = 16501;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature = 16503;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature_EURange = 16507;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature = 16509;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature_EURange = 16513;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Identification_SerialNumber = 16516;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_Model Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Identification_Model = 16517;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Identification_Manufacturer = 16518;

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_DeviceClass Variable.
        /// </summary>
        public const uint DeviceSet_TCD_CSZ_103521_Identification_DeviceClass = 16519;

        /// <summary>
        /// The identifier for the TCD_BinarySchema Variable.
        /// </summary>
        public const uint TCD_BinarySchema = 15527;

        /// <summary>
        /// The identifier for the TCD_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint TCD_BinarySchema_NamespaceUri = 15529;

        /// <summary>
        /// The identifier for the TCD_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint TCD_BinarySchema_Deprecated = 15530;

        /// <summary>
        /// The identifier for the TCD_BinarySchema_TimeZoneDataType Variable.
        /// </summary>
        public const uint TCD_BinarySchema_TimeZoneDataType = 15531;

        /// <summary>
        /// The identifier for the TCD_BinarySchema_ActiveErrorDataType Variable.
        /// </summary>
        public const uint TCD_BinarySchema_ActiveErrorDataType = 15534;

        /// <summary>
        /// The identifier for the TCD_XmlSchema Variable.
        /// </summary>
        public const uint TCD_XmlSchema = 15539;

        /// <summary>
        /// The identifier for the TCD_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint TCD_XmlSchema_NamespaceUri = 15541;

        /// <summary>
        /// The identifier for the TCD_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint TCD_XmlSchema_Deprecated = 15542;

        /// <summary>
        /// The identifier for the TCD_XmlSchema_TimeZoneDataType Variable.
        /// </summary>
        public const uint TCD_XmlSchema_TimeZoneDataType = 15543;

        /// <summary>
        /// The identifier for the TCD_XmlSchema_ActiveErrorDataType Variable.
        /// </summary>
        public const uint TCD_XmlSchema_ActiveErrorDataType = 15546;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the ActiveErrorsDataType VariableType.
        /// </summary>
        public const uint ActiveErrorsDataType = 15001;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the TimeZoneDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId TimeZoneDataType = new ExpandedNodeId(TCD.DataTypes.TimeZoneDataType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ActiveErrorDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ActiveErrorDataType = new ExpandedNodeId(TCD.DataTypes.ActiveErrorDataType, TCD.Namespaces.TCD);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_ResetAllErrors = new ExpandedNodeId(TCD.Methods.OperationType_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOn = new ExpandedNodeId(TCD.Methods.OperationType_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOff = new ExpandedNodeId(TCD.Methods.OperationType_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.TCD_Interface_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.TCD_Interface_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.TCD_Interface_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceZoneType_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceZoneType_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Reset = new ExpandedNodeId(TCD.Methods.MaintenanceType_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_Reset = new ExpandedNodeId(TCD.Methods.MaintenanceInformationType_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_Reset = new ExpandedNodeId(TCD.Methods.MaintenanceInformationType_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_30293_02_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_30293_02_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_30293_02_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_11090_24_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_11090_24_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_11090_24_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_26179_06_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_26179_06_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_26179_06_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_22507_03_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_22507_03_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_22507_03_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_13502_21_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_13502_21_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_TPS_13502_21_Operation_SwitchOff, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Reset = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Reset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_ResetAllErrors Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_ResetAllErrors = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_CSZ_103521_Operation_ResetAllErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_SwitchOn Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_SwitchOn = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_CSZ_103521_Operation_SwitchOn, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_SwitchOff Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_SwitchOff = new ExpandedNodeId(TCD.Methods.DeviceSet_TCD_CSZ_103521_Operation_SwitchOff, TCD.Namespaces.TCD);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone = new ExpandedNodeId(TCD.Objects.TCD_Interface_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.TCD_Interface_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.TCD_Interface_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.TCD_Interface_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_MachineConfiguration = new ExpandedNodeId(TCD.Objects.TCD_Interface_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation = new ExpandedNodeId(TCD.Objects.TCD_Interface_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification = new ExpandedNodeId(TCD.Objects.TCD_Interface_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Identification = new ExpandedNodeId(TCD.Objects.TCD_Interface_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceZoneType_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceZoneType_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceZoneType_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature = new ExpandedNodeId(TCD.Objects.DeviceZoneType_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating = new ExpandedNodeId(TCD.Objects.MaintenanceInformationType_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling = new ExpandedNodeId(TCD.Objects.MaintenanceInformationType_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet = new ExpandedNodeId(TCD.Objects.DeviceSet, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_30293_02_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_11090_24_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_26179_06_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_22507_03_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_TPS_13502_21_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521 Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521 = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_DeviceZone, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_MachineConfiguration = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_MachineConfiguration, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_Operation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_TCDSpecification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Identification = new ExpandedNodeId(TCD.Objects.DeviceSet_TCD_CSZ_103521_Identification, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeZoneDataType_Encoding_DefaultBinary = new ExpandedNodeId(TCD.Objects.TimeZoneDataType_Encoding_DefaultBinary, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ActiveErrorDataType_Encoding_DefaultBinary = new ExpandedNodeId(TCD.Objects.ActiveErrorDataType_Encoding_DefaultBinary, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeZoneDataType_Encoding_DefaultXml = new ExpandedNodeId(TCD.Objects.TimeZoneDataType_Encoding_DefaultXml, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ActiveErrorDataType_Encoding_DefaultXml = new ExpandedNodeId(TCD.Objects.ActiveErrorDataType_Encoding_DefaultXml, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TimeZoneDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeZoneDataType_Encoding_DefaultJson = new ExpandedNodeId(TCD.Objects.TimeZoneDataType_Encoding_DefaultJson, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ActiveErrorDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId ActiveErrorDataType_Encoding_DefaultJson = new ExpandedNodeId(TCD.Objects.ActiveErrorDataType_Encoding_DefaultJson, TCD.Namespaces.TCD);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the IdentificationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IdentificationType = new ExpandedNodeId(TCD.ObjectTypes.IdentificationType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType = new ExpandedNodeId(TCD.ObjectTypes.TCDSpecificationType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OperationType = new ExpandedNodeId(TCD.ObjectTypes.OperationType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface = new ExpandedNodeId(TCD.ObjectTypes.TCD_Interface, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MachineConfigurationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineConfigurationType = new ExpandedNodeId(TCD.ObjectTypes.MachineConfigurationType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType = new ExpandedNodeId(TCD.ObjectTypes.DeviceZoneType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType = new ExpandedNodeId(TCD.ObjectTypes.ControlledParameterType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType = new ExpandedNodeId(TCD.ObjectTypes.MaintenanceType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType = new ExpandedNodeId(TCD.ObjectTypes.MaintenanceInformationType, TCD.Namespaces.TCD);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the IdentificationType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IdentificationType_SerialNumber = new ExpandedNodeId(TCD.Variables.IdentificationType_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the IdentificationType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IdentificationType_Model = new ExpandedNodeId(TCD.Variables.IdentificationType_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the IdentificationType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IdentificationType_Manufacturer = new ExpandedNodeId(TCD.Variables.IdentificationType_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the IdentificationType_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IdentificationType_DeviceClass = new ExpandedNodeId(TCD.Variables.IdentificationType_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_CoolingCapacity = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_ConnectedLoad = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_NominalFlowRate = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_PowerValue = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_MaxTemperature = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_MinTemperature = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCDSpecificationType_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCDSpecificationType_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.TCDSpecificationType_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_ActiveErrors = new ExpandedNodeId(TCD.Variables.OperationType_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_HoursOfOperation = new ExpandedNodeId(TCD.Variables.OperationType_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.OperationType_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.OperationType_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.OperationType_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_OperatingMode = new ExpandedNodeId(TCD.Variables.OperationType_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_ResetAllErrors_InputArguments = new ExpandedNodeId(TCD.Variables.OperationType_ResetAllErrors_InputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_ResetAllErrors_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_ResetAllErrors_OutputArguments = new ExpandedNodeId(TCD.Variables.OperationType_ResetAllErrors_OutputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOn_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOn_InputArguments = new ExpandedNodeId(TCD.Variables.OperationType_SwitchOn_InputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOn_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOn_OutputArguments = new ExpandedNodeId(TCD.Variables.OperationType_SwitchOn_OutputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOff_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOff_InputArguments = new ExpandedNodeId(TCD.Variables.OperationType_SwitchOff_InputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the OperationType_SwitchOff_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OperationType_SwitchOff_OutputArguments = new ExpandedNodeId(TCD.Variables.OperationType_SwitchOff_OutputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.TCD_Interface_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.TCD_Interface_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.TCD_Interface_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.TCD_Interface_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.TCD_Interface_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.TCD_Interface_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Identification_Model = new ExpandedNodeId(TCD.Variables.TCD_Interface_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.TCD_Interface_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_Interface_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_Interface_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.TCD_Interface_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MachineConfigurationType_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineConfigurationType_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.MachineConfigurationType_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MachineConfigurationType_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineConfigurationType_LocationName = new ExpandedNodeId(TCD.Variables.MachineConfigurationType_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MachineConfigurationType_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineConfigurationType_UserMachineName = new ExpandedNodeId(TCD.Variables.MachineConfigurationType_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceZoneType_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceZoneType_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceZoneType_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceZoneType_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetValue = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetValue_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_ActualValue = new ExpandedNodeId(TCD.Variables.ControlledParameterType_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_LowerTolerance = new ExpandedNodeId(TCD.Variables.ControlledParameterType_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_UpperTolerance = new ExpandedNodeId(TCD.Variables.ControlledParameterType_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_MinValue = new ExpandedNodeId(TCD.Variables.ControlledParameterType_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_MinValue_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_MaxValue = new ExpandedNodeId(TCD.Variables.ControlledParameterType_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetRampDown = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetRampUp = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the ControlledParameterType_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControlledParameterType_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.ControlledParameterType_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_RemainingInterval = new ExpandedNodeId(TCD.Variables.MaintenanceType_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceType_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Interval = new ExpandedNodeId(TCD.Variables.MaintenanceType_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Interval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceType_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_AdditionalInformation = new ExpandedNodeId(TCD.Variables.MaintenanceType_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Status = new ExpandedNodeId(TCD.Variables.MaintenanceType_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Reset_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Reset_InputArguments = new ExpandedNodeId(TCD.Variables.MaintenanceType_Reset_InputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceType_Reset_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceType_Reset_OutputArguments = new ExpandedNodeId(TCD.Variables.MaintenanceType_Reset_OutputArguments, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_Interval = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Heating_Status = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_Interval = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the MaintenanceInformationType_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceInformationType_Cooling_Status = new ExpandedNodeId(TCD.Variables.MaintenanceInformationType_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_30293_02_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_30293_02_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_30293_02_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_11090_24_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_11090_24_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_11090_24_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_26179_06_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_26179_06_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_26179_06_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_22507_03_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_22507_03_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_22507_03_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_TPS_13502_21_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_TPS_13502_21_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_TPS_13502_21_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Heating_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_RemainingInterval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Interval_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_AdditionalInformation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Status = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_MaintenanceInformation_Cooling_Status, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_ActualValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_LowerTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_UpperTolerance_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MinValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_MaxValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampDown_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_DeviceZone_Temperature_SetRampUp_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_TimeZoneOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_MachineConfiguration_TimeZoneOffset = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_MachineConfiguration_TimeZoneOffset, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_LocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_MachineConfiguration_LocationName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_MachineConfiguration_LocationName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_MachineConfiguration_UserMachineName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_MachineConfiguration_UserMachineName = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_MachineConfiguration_UserMachineName, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_ActiveErrors Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_ActiveErrors = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_ActiveErrors, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_HoursOfOperation_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_HighestActiveAlarmSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_HighestActiveAlarmSeverity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_HighestActiveAlarmSeverity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_DeviceMappingNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_DeviceMappingNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_DeviceMappingNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Operation_OperatingMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Operation_OperatingMode = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Operation_OperatingMode, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_CoolingCapacity_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_ConnectedLoad_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_NominalFlowRate_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_PowerValue_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_MaxTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature_EURange = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_TCDSpecification_MinTemperature_EURange, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Identification_SerialNumber = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Identification_SerialNumber, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Identification_Model = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Identification_Model, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Identification_Manufacturer = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Identification_Manufacturer, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the DeviceSet_TCD_CSZ_103521_Identification_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_TCD_CSZ_103521_Identification_DeviceClass = new ExpandedNodeId(TCD.Variables.DeviceSet_TCD_CSZ_103521_Identification_DeviceClass, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_BinarySchema = new ExpandedNodeId(TCD.Variables.TCD_BinarySchema, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_BinarySchema_NamespaceUri = new ExpandedNodeId(TCD.Variables.TCD_BinarySchema_NamespaceUri, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_BinarySchema_Deprecated = new ExpandedNodeId(TCD.Variables.TCD_BinarySchema_Deprecated, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_BinarySchema_TimeZoneDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_BinarySchema_TimeZoneDataType = new ExpandedNodeId(TCD.Variables.TCD_BinarySchema_TimeZoneDataType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_BinarySchema_ActiveErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_BinarySchema_ActiveErrorDataType = new ExpandedNodeId(TCD.Variables.TCD_BinarySchema_ActiveErrorDataType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_XmlSchema = new ExpandedNodeId(TCD.Variables.TCD_XmlSchema, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_XmlSchema_NamespaceUri = new ExpandedNodeId(TCD.Variables.TCD_XmlSchema_NamespaceUri, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_XmlSchema_Deprecated = new ExpandedNodeId(TCD.Variables.TCD_XmlSchema_Deprecated, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_XmlSchema_TimeZoneDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_XmlSchema_TimeZoneDataType = new ExpandedNodeId(TCD.Variables.TCD_XmlSchema_TimeZoneDataType, TCD.Namespaces.TCD);

        /// <summary>
        /// The identifier for the TCD_XmlSchema_ActiveErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TCD_XmlSchema_ActiveErrorDataType = new ExpandedNodeId(TCD.Variables.TCD_XmlSchema_ActiveErrorDataType, TCD.Namespaces.TCD);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the ActiveErrorsDataType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ActiveErrorsDataType = new ExpandedNodeId(TCD.VariableTypes.ActiveErrorsDataType, TCD.Namespaces.TCD);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ActiveErrorDataType component.
        /// </summary>
        public const string ActiveErrorDataType = "ActiveErrorDataType";

        /// <summary>
        /// The BrowseName for the ActiveErrors component.
        /// </summary>
        public const string ActiveErrors = "ActiveErrors";

        /// <summary>
        /// The BrowseName for the ActiveErrorsDataType component.
        /// </summary>
        public const string ActiveErrorsDataType = "ActiveErrorsDataType";

        /// <summary>
        /// The BrowseName for the ActualValue component.
        /// </summary>
        public const string ActualValue = "ActualValue";

        /// <summary>
        /// The BrowseName for the AdditionalInformation component.
        /// </summary>
        public const string AdditionalInformation = "AdditionalInformation";

        /// <summary>
        /// The BrowseName for the ConnectedLoad component.
        /// </summary>
        public const string ConnectedLoad = "ConnectedLoad";

        /// <summary>
        /// The BrowseName for the ControlledParameterType component.
        /// </summary>
        public const string ControlledParameterType = "ControlledParameterType";

        /// <summary>
        /// The BrowseName for the Cooling component.
        /// </summary>
        public const string Cooling = "Cooling";

        /// <summary>
        /// The BrowseName for the CoolingCapacity component.
        /// </summary>
        public const string CoolingCapacity = "CoolingCapacity";

        /// <summary>
        /// The BrowseName for the DeviceClass component.
        /// </summary>
        public const string DeviceClass = "DeviceClass";

        /// <summary>
        /// The BrowseName for the DeviceMappingNumber component.
        /// </summary>
        public const string DeviceMappingNumber = "DeviceMappingNumber";

        /// <summary>
        /// The BrowseName for the DeviceSet component.
        /// </summary>
        public const string DeviceSet = "DeviceSet";

        /// <summary>
        /// The BrowseName for the DeviceZone component.
        /// </summary>
        public const string DeviceZone = "DeviceZone";

        /// <summary>
        /// The BrowseName for the DeviceZoneType component.
        /// </summary>
        public const string DeviceZoneType = "DeviceZoneType";

        /// <summary>
        /// The BrowseName for the Heating component.
        /// </summary>
        public const string Heating = "Heating";

        /// <summary>
        /// The BrowseName for the HighestActiveAlarmSeverity component.
        /// </summary>
        public const string HighestActiveAlarmSeverity = "HighestActiveAlarmSeverity";

        /// <summary>
        /// The BrowseName for the HoursOfOperation component.
        /// </summary>
        public const string HoursOfOperation = "HoursOfOperation";

        /// <summary>
        /// The BrowseName for the Identification component.
        /// </summary>
        public const string Identification = "Identification";

        /// <summary>
        /// The BrowseName for the IdentificationType component.
        /// </summary>
        public const string IdentificationType = "IdentificationType";

        /// <summary>
        /// The BrowseName for the Interval component.
        /// </summary>
        public const string Interval = "Interval";

        /// <summary>
        /// The BrowseName for the LocationName component.
        /// </summary>
        public const string LocationName = "LocationName";

        /// <summary>
        /// The BrowseName for the LowerTolerance component.
        /// </summary>
        public const string LowerTolerance = "LowerTolerance";

        /// <summary>
        /// The BrowseName for the MachineConfiguration component.
        /// </summary>
        public const string MachineConfiguration = "MachineConfiguration";

        /// <summary>
        /// The BrowseName for the MachineConfigurationType component.
        /// </summary>
        public const string MachineConfigurationType = "MachineConfigurationType";

        /// <summary>
        /// The BrowseName for the MaintenanceInformation component.
        /// </summary>
        public const string MaintenanceInformation = "MaintenanceInformation";

        /// <summary>
        /// The BrowseName for the MaintenanceInformationType component.
        /// </summary>
        public const string MaintenanceInformationType = "MaintenanceInformationType";

        /// <summary>
        /// The BrowseName for the MaintenanceType component.
        /// </summary>
        public const string MaintenanceType = "MaintenanceType";

        /// <summary>
        /// The BrowseName for the Manufacturer component.
        /// </summary>
        public const string Manufacturer = "Manufacturer";

        /// <summary>
        /// The BrowseName for the MaxTemperature component.
        /// </summary>
        public const string MaxTemperature = "MaxTemperature";

        /// <summary>
        /// The BrowseName for the MaxValue component.
        /// </summary>
        public const string MaxValue = "MaxValue";

        /// <summary>
        /// The BrowseName for the MinTemperature component.
        /// </summary>
        public const string MinTemperature = "MinTemperature";

        /// <summary>
        /// The BrowseName for the MinValue component.
        /// </summary>
        public const string MinValue = "MinValue";

        /// <summary>
        /// The BrowseName for the Model component.
        /// </summary>
        public const string Model = "Model";

        /// <summary>
        /// The BrowseName for the NominalFlowRate component.
        /// </summary>
        public const string NominalFlowRate = "NominalFlowRate";

        /// <summary>
        /// The BrowseName for the OperatingMode component.
        /// </summary>
        public const string OperatingMode = "OperatingMode";

        /// <summary>
        /// The BrowseName for the Operation component.
        /// </summary>
        public const string Operation = "Operation";

        /// <summary>
        /// The BrowseName for the OperationType component.
        /// </summary>
        public const string OperationType = "OperationType";

        /// <summary>
        /// The BrowseName for the PowerValue component.
        /// </summary>
        public const string PowerValue = "PowerValue";

        /// <summary>
        /// The BrowseName for the RemainingInterval component.
        /// </summary>
        public const string RemainingInterval = "RemainingInterval";

        /// <summary>
        /// The BrowseName for the Reset component.
        /// </summary>
        public const string Reset = "Reset";

        /// <summary>
        /// The BrowseName for the ResetAllErrors component.
        /// </summary>
        public const string ResetAllErrors = "ResetAllErrors";

        /// <summary>
        /// The BrowseName for the SerialNumber component.
        /// </summary>
        public const string SerialNumber = "SerialNumber";

        /// <summary>
        /// The BrowseName for the SetRampDown component.
        /// </summary>
        public const string SetRampDown = "SetRampDown";

        /// <summary>
        /// The BrowseName for the SetRampUp component.
        /// </summary>
        public const string SetRampUp = "SetRampUp";

        /// <summary>
        /// The BrowseName for the SetValue component.
        /// </summary>
        public const string SetValue = "SetValue";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the SwitchOff component.
        /// </summary>
        public const string SwitchOff = "SwitchOff";

        /// <summary>
        /// The BrowseName for the SwitchOn component.
        /// </summary>
        public const string SwitchOn = "SwitchOn";

        /// <summary>
        /// The BrowseName for the TCD_BinarySchema component.
        /// </summary>
        public const string TCD_BinarySchema = "TCD";

        /// <summary>
        /// The BrowseName for the TCD_CSZ_103521 component.
        /// </summary>
        public const string TCD_CSZ_103521 = "TCD_CSZ_103521";

        /// <summary>
        /// The BrowseName for the TCD_Interface component.
        /// </summary>
        public const string TCD_Interface = "TCD_Interface";

        /// <summary>
        /// The BrowseName for the TCD_TPS_11090_24 component.
        /// </summary>
        public const string TCD_TPS_11090_24 = "TCD_TPS_11090_24";

        /// <summary>
        /// The BrowseName for the TCD_TPS_13502_21 component.
        /// </summary>
        public const string TCD_TPS_13502_21 = "TCD_TPS_13502_21";

        /// <summary>
        /// The BrowseName for the TCD_TPS_22507_03 component.
        /// </summary>
        public const string TCD_TPS_22507_03 = "TCD_TPS_22507_03";

        /// <summary>
        /// The BrowseName for the TCD_TPS_26179_06 component.
        /// </summary>
        public const string TCD_TPS_26179_06 = "TCD_TPS_26179_06";

        /// <summary>
        /// The BrowseName for the TCD_TPS_30293_02 component.
        /// </summary>
        public const string TCD_TPS_30293_02 = "TCD_TPS_30293_02";

        /// <summary>
        /// The BrowseName for the TCD_XmlSchema component.
        /// </summary>
        public const string TCD_XmlSchema = "TCD";

        /// <summary>
        /// The BrowseName for the TCDSpecification component.
        /// </summary>
        public const string TCDSpecification = "TCDSpecification";

        /// <summary>
        /// The BrowseName for the TCDSpecificationType component.
        /// </summary>
        public const string TCDSpecificationType = "TCDSpecificationType";

        /// <summary>
        /// The BrowseName for the Temperature component.
        /// </summary>
        public const string Temperature = "Temperature";

        /// <summary>
        /// The BrowseName for the TimeZoneDataType component.
        /// </summary>
        public const string TimeZoneDataType = "TimeZoneDataType";

        /// <summary>
        /// The BrowseName for the TimeZoneOffset component.
        /// </summary>
        public const string TimeZoneOffset = "TimeZoneOffset";

        /// <summary>
        /// The BrowseName for the UpperTolerance component.
        /// </summary>
        public const string UpperTolerance = "UpperTolerance";

        /// <summary>
        /// The BrowseName for the UserMachineName component.
        /// </summary>
        public const string UserMachineName = "UserMachineName";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the TCD namespace (.NET code namespace is 'TCD').
        /// </summary>
        public const string TCD = "http://opcfoundation.org/UA/TCD/";
    }
    #endregion
}