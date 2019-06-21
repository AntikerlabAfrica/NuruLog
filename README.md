# NuruLog
Just a Simple .netstandart2.0 Logging Library

# How to use

To use this Logger Lib include the DLL in ur Project and Initialize it.
- Initialize with Custom Application name
```cs
NuruLog Nurulog = new NuruLog("Application Name");
```
- If You Want you can Initialize it with the Assembly name of your Application
```cs
NuruLog Nurulog = new NuruLog(Assembly.GetExecutingAssembly().GetName().Name);
```
- To use the Logger simply us this Code for only Log to Consol.
```cs
Nurulog.Log(LogHandler.LogType, Message);
```
- If u want to Save the Log to a file, use this Code.
```cs
Nurulog.Log("filename", LogHandler.LogType, Message);
```

- There are different Logtypes
```cs
LogHandler.LogType.MESSAGE - Normal Messages from app/Server/Client apps

LogHandler.LogType.SUCCESS - Like when logged in

LogHandler.LogType.INFO - Application infos

LogHandler.LogType.DEBUG - Application Debug Messages

LogHandler.LogType.WARNING  - Application Warnings

LogHandler.LogType.ERROR  - Application Error

LogHandler.LogType.FATAL - Fatal Error in Application
```

# Compatability

This Library schould be compatible with any OS that supports .NetCore2.0
(Windows 10, macOS Sierra - Mojave(Lastest) and Linux, FreeBSD(possible but untested))

# License

This Project uses the MIT License. Feel free to do anything with this Project within the Terms & Conditionts of the MIT License.
