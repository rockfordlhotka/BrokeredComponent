mkdir serverbin
copy Debug\BrokeredComponentPS serverbin
copy SecondaryAssembly\bin\Debug serverbin
regsvr32 serverbin\BrokeredComponentPS.dll
icacls serverbin /T /grant *S-1-15-2-1:RX
