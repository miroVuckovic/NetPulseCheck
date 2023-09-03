using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    internal class Logger
    {
        public string fileNameMainLog;
        public char separator;

        private static string tempDirFailLog = "NetPulseCheck_Fail";
        private static string logPathFailLog = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.User) + "\\" + Logger.tempDirFailLog;
        private static string fileNameFailLog = string.Format("{0:yyyy-MM-dd}", DateTime.Now) + ".csv";      
        private static string failLogFullPath = Path.Combine(Logger.logPathFailLog, Logger.fileNameFailLog);

        string csvHeader = 

        public Logger(string fileName = "log.csv", char separator = ';')
        {
            WriteLog(fileNameMainLog);
            fileNameMainLog = fileName;
            this.separator = separator;
        }

        public void WriteLog(string inputText)
        {
            string path1 = Globals.logPath != null ? Globals.logPath : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path1, fileNameMainLog), true))
                    streamWriter.WriteLine("{0:yyyy-MM-dd HH:mm:ss}"+ separator + inputText, DateTime.Now);
            }
            catch
            {
            }
        }

        private void WriteFailLog(string inputText)
        {
            if (!Directory.Exists(Logger.logPathFailLog))
                Directory.CreateDirectory(Logger.logPathFailLog);
            string path2 = string.Format("{0:yyyy-MM-dd}", DateTime.Now) + ".txt";
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(Logger.logPathFailLog, path2), true))
                    streamWriter.WriteLine("{0:yyyy-MM-dd HH:mm:ss} - " + inputText, DateTime.Now);
            }
            catch
            {
            }
        }
    }
}
