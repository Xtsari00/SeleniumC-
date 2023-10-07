using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class Logger
    {

        private static readonly string LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");


        public static void Log(string message)
        {
            string logMessage = $"{DateTime.Now} - {message}";
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }
    }
}
