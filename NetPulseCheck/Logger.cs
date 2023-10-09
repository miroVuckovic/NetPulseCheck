using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    internal class Logger
    {
        public string fileNameMainLog;
        public char separator = ';';

        private static string tempDirFailLog = "NetPulseCheck_Fail";
        private static string logPathFailLog = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.User) + "\\" + Logger.tempDirFailLog;
        private static string fileNameFailLog = string.Format("{0:yyyy-MM-dd}", DateTime.Now) + ".csv";

        string csvHeader = "Time";

        string path = string.Empty;       

        private string GetPath()
        {
            if (Globals.logPath != null)
            {
                path = Globals.logPath;
            }
            else
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            return path;
        }

        public Logger(string fileName = "log.csv")
        {
            fileNameMainLog = fileName;
            GetPath();
        }

        private string CreateCSVHeader()
        {
            char separator = ';';

            string header = "Time" + separator + "Ping" + separator + "IP/DNS" + separator + "Target description" + separator;

            return header;
        }

        public void WriteLog(string inputText)
        {

            GetPath();

            try
            {

                string csvLine = string.Format("{0:yyyy-MM-dd HH:mm:ss}" + separator + inputText, DateTime.Now);

                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, fileNameMainLog), true))
                    streamWriter.WriteLine(csvLine);
            }
            catch
            {
                MessageBox.Show("Unable to write log.", Application.ProductName + " - " + "Error");
                return;
            }
        }

        public void WriteLog(int header = 0)
        {
            char separator = ';';

            if (header > 0)
            {
                WriteLog("Time" + separator + "Ping" + separator + "IP/DNS" + separator + "Target description" + separator);
            }
            
        }

    }
}
