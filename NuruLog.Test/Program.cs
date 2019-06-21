using System;
using System.Reflection;
namespace NuruLog.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NuruLog Nurulog = new NuruLog(Assembly.GetExecutingAssembly().GetName().Name);

            Console.WriteLine("Test Log Message. No Filesave.");
            var inputM = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.MESSAGE, inputM);

            Console.WriteLine("Test Log Message. No Filesave.");
            var inputS = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.SUCCESS, inputS);

            Console.WriteLine("Test Log Info. No Filesave.");
            var inputI = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.INFO, inputI);

            Console.WriteLine("Test Log Debug. No Filesave.");
            var inputD = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.DEBUG, inputD);

            Console.WriteLine("Test Log Warning. No Filesave.");
            var inputW = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.WARNING, inputW);

            Console.WriteLine("Test Log Error. No Filesave.");
            var inputE = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.ERROR, inputE);

            Console.WriteLine("Test Log Fatal. No Filesave.");
            var inputF = Console.ReadLine();
            Nurulog.Log(LogHandler.LogType.FATAL, inputF);

            Console.Clear();

            var file = "TestFile";
            Console.WriteLine("Test Log Message. Filesave.");
            var inputMF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.MESSAGE, inputMF);

            Console.WriteLine("Test Log Message. Filesave.");
            var inputSF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.SUCCESS, inputSF);

            Console.WriteLine("Test Log Info. Filesave.");
            var inputIF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.INFO, inputIF);

            Console.WriteLine("Test Log Debug. Filesave.");
            var inputDF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.DEBUG, inputDF);

            Console.WriteLine("Test Log Warning. Filesave.");
            var inputWF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.WARNING, inputWF);

            Console.WriteLine("Test Log Error. Filesave.");
            var inputEF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.ERROR, inputEF);

            Console.WriteLine("Test Log Fatal. Filesave.");
            var inputFF = Console.ReadLine();
            Nurulog.Log(file, LogHandler.LogType.FATAL, inputFF);




        }
    }
}
