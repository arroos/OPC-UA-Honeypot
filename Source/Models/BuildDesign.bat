@echo off
setlocal

SET PATH=%PATH%;C:\Honeypot\UA-ModelCompiler-master\Bin\Debug;C:\Honeypot\UA-ModelCompiler-master\Bin

echo Building TCD
Opc.Ua.ModelCompiler.exe -d2 "tcd.xml" -cg "C:\Honeypot\UA-.NETStandard-master\SampleApplications\Samples\Opc.Ua.Sample\TCD\TCD.csv" -o2 "C:\Honeypot\UA-.NETStandard-master\SampleApplications\Samples\Opc.Ua.Sample\TCD" -useXmlInitializers


