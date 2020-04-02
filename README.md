# opc-ua-hp
OPC UA Honeypot

Copyright 2019 Andrew Roos. 

LICENSING

The OPC UA Honeypot is free software: you can redistribute it and/or 
modify it under the terms of the GNU General Public License as published 
by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

The OPC UA Honeypot is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with the OPC UA Honeypot. If not, see 
<https://www.gnu.org/licenses/>.

Some individual files are Copyright The OPC Foundation, Inc and licensed 
under either the OPC Reciprocal Community License or the OPC Foundation 
MIT License, as specified by the copyright notices in these files. 

BUILD INSTRUCTIONS

This project is a delta to the OPC Foundation UA-.NETStandard software
(https://github.com/OPCFoundation/UA-.NETStandard). It was implemented 
and tested with version 1.04.354. To build, first install the OPC 
Foundation UA-.NETStandard solution. This will create a directory 
called "UA-.NETStandard-master". Copy the contents of this project's
UA-.NETStandard-master folder into this directory, retaining subdirectory
paths. This will add some files to the OPC Foundation project, and replace 
others. Then build the NetCoreConsoleServer project according to the 
UA-.NETStandard documentation.

CONFIGURATION

The honeypot run-time configuration is specified in 
Source/UA-.NETStandard-master/SampleApplications/Samples/NetCoreConsoleServer/Opc.Ua.SampleServer.Config.xml.

INFORMATION MODEL

The information model source XML is found in Source/Models/tcd.xml. This file 
is not required to build the honeypot, as it has been precompiled using the
OPC Foundation UA Model Compiler. The generated files are found in
/Source/UA-.NETStandard-master/SampleApplications/Samples/Opc.Ua.Sample/TCD.
They should not be modified since recompiling the information model will 
overwrite them. The batch file used to invoke the model compiler is 
/Source/Models/BuildDesign.bat. A diagram of the information model can
be found in InformationModel.png in the top-level folder. Variables and methods 
coloured yellow can be updated or executed by an intruder, while those coloured 
green are updated automatically by the simulation subsystem.

SOURCE CODE

The main honeypot functions of user authentication, logging and simulation, are 
implemented in the new source files found in  
/Source/UA-.NETStandard-master/SampleApplications/Samples/Opc.Ua.Sample/Honeypot.
Other than the generated files in TCD, the remainder of the files are modifications
to the OPC Foundation UA-.NETStandard SampleServer to integrate the honeypot
functionality. One necessary change was to modify stack to include the client
IP address and port in the SecureChannelContext, so that these can be recorded
in the honeypot log files. 

