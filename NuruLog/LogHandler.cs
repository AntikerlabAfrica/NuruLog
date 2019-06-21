using System;
namespace NuruLog
{
    public static class LogHandler
    {
        internal static string LogMessage = "[" + DateTime.Now + "]" + " [MESSAGE] ";
        internal static string LogSuccess = "[" + DateTime.Now + "]" + " [SUCCESS] ";
        internal static string LogInfo = "[" + DateTime.Now + "]" + " [INFO] ";
        internal static string LogDebug = "[" + DateTime.Now + "]" + " [DEBUG] ";
        internal static string LogWarning = "[" + DateTime.Now + "]" + " [WARNING] ";
        internal static string LogError = "[" + DateTime.Now + "]" + " [ERROR] ";
        internal static string LogFatal = "[" + DateTime.Now + "]" + " [FATAL] ";

        public enum LogType
        {   MESSAGE,
            SUCCESS,
            INFO,
            DEBUG,
            WARNING,
            ERROR,
            FATAL
        }
    }
}
