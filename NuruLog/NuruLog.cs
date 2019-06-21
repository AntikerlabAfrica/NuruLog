using System;
using System.IO;
namespace NuruLog
{
    public class NuruLog
    { 
        public NuruLog(string ApplicationName)
        {
            appname = ApplicationName;
            Console.WriteLine("Antikerlab Africa NuruLog v0.1");
            Console.WriteLine("NuruLog is Released under MIT License.");
            Console.WriteLine("Loggin Application: " + appname);
        }

        internal static string appname;

        //Log to Console without writing to File
        public void Log(LogHandler.LogType Type, string Message)
        {
            switch (Type)
            {
                case LogHandler.LogType.MESSAGE:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(LogHandler.LogMessage + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.SUCCESS:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(LogHandler.LogSuccess + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.INFO:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(LogHandler.LogInfo + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.DEBUG:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(LogHandler.LogDebug + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(LogHandler.LogWarning + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(LogHandler.LogError + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.FATAL:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(LogHandler.LogFatal + Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }

        // Write to Console and safe to file
        public void Log(string Filename, LogHandler.LogType Type, string Message)
        {
            var logmsg = string.Empty;
            switch (Type)
            {
                case LogHandler.LogType.MESSAGE:
                    Console.ForegroundColor = ConsoleColor.Green;
                    logmsg = LogHandler.LogMessage + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.SUCCESS:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    logmsg = LogHandler.LogSuccess + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.INFO:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    logmsg = LogHandler.LogInfo + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.DEBUG:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    logmsg = LogHandler.LogDebug + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    logmsg = LogHandler.LogWarning + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    logmsg = LogHandler.LogError + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogHandler.LogType.FATAL:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    logmsg = LogHandler.LogFatal + Message;
                    Console.WriteLine(logmsg);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }

            var logfile = @appname +"-"+ DateTime.Now.ToString("MMddyyyy") + ".log";
            if (!File.Exists(logfile))
            {
                Console.WriteLine("Creating new LogFile: "+logfile);
                StreamWriter NewLog = File.CreateText(logfile);
                NewLog.WriteLine("Antikerlab Africa NuruLog v0.1\n" + logfile +"\n" + logmsg);
                NewLog.Close();
            }
            else
            {

                StreamWriter LogAppend = File.AppendText(logfile);
                LogAppend.WriteLine(logmsg);
                LogAppend.Close();
            }
        }




    }
}

