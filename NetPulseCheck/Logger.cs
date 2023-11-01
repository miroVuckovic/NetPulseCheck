namespace NetPulseCheck
{
    internal class Logger
    {
        public string fileNameMainLog;

        private char separator = ';';

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

        public void SetFileNamePath()
        {
            if (Globals.logPath != null)
            {
                path = Globals.logPath;
            }
            else
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }

        public Logger(string fileName = "log.csv")
        {
            fileNameMainLog = fileName;
            GetPath();
        }

        public void CreateCSVHeader()
        {
            WriteLog(string.Empty,1);
        }

        public void WriteLog(string inputText, int headerSelect = 0)
        {

            GetPath();


            string csvLine = string.Format("{0:yyyy-MM-dd HH:mm:ss}" + separator + inputText, DateTime.Now);
            string header = "Time" + separator + "Ping" + separator + "IP/DNS" + separator + "Target description" + separator;

            if (headerSelect > 0)
            {
                csvLine = header;
            }

            try
            {

                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, fileNameMainLog), true))
                {
                    streamWriter.WriteLine(csvLine);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write log.\n\n" + ex.Message, Application.ProductName + " - " + "Error");
                return;
            }
        }

    }
}
