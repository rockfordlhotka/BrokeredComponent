BrokeredComponent
====
This is a demo solution that shows how to create and use a brokered component in WinRT.

A brokered component is a Win32 .NET assembly that can be called by a WinRT app. To make this possible there 
is a proxy/stub project in C++ that brokers the cross-process call from WinRT to Win32.

Resources:
* http://devhawk.net/2014/04/25/brokered-winrt-components-step-one/
* http://msdn.microsoft.com/en-us/library/windows/apps/dn630195.aspx

To run:
* Build the BrokeredComponent.sln solution
* Run the serverprep.bat script as Administrator
* Open the WinRTClient.sln solution and run it
