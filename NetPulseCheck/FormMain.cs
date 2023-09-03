using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Timers;
using System.Windows.Forms;

namespace NetPulseCheck
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            HandleDefaultGui();
            AutoFillDefaultTargets();
            notifyIconMain.Visible = true;
            buttonStop.Enabled = false;
            comboBoxLogLevel.SelectedItem = "ERROR";

            //SaveAllSettings();
            ReadAllSettings();
            //SetPingInterval();
        }

        Logger logger = new Logger();

        #region backgroundWorker

        BackgroundWorker bWorker = new BackgroundWorker()
        {
            WorkerSupportsCancellation = true
        };

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            PingAllTargets();
            logger.WriteLog("Process started.");
            if (bWorker.CancellationPending)
                return;
            e.Cancel = true;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
                return;
            logger.WriteLog("Process stopped.");
        }

        #endregion

        #region Messages
        private string MsgStrings(int status)
        {
            switch (status)
            {
                case 0:
                    return "Host unreachable";
                case 1:
                    return "Connection OK";
                default:
                    return "Connection OK";
            }
        }

        #endregion

        #region GUI

        private void HandleDefaultGui()
        {
            checkBoxActivate01.Checked = true;
            checkBoxActivate02.Checked = true;
            checkBoxActivate03.Checked = true;
            labelTargetPing01.Text = "-";
            labelTargetPing02.Text = "-";
            labelTargetPing03.Text = "-";
            checkBoxTargetsAll.Checked = true;
        }

        private void AutoFillDefaultTargets()
        {
            textBoxTargetIp01.Text = "8.8.8.8";
            textBoxTargetDesc01.Text = "Google DNS";
            textBoxTargetIp02.Text = "1.1.1.1";
            textBoxTargetDesc02.Text = "Cloudflare DNS";
            textBoxTargetIp03.Text = "4.2.2.2";
            textBoxTargetDesc03.Text = "Level3 nameserver";
        }
        #endregion


        #region ping

        //static int interval = (int)textBoxInterval.Text;

        public void PingAllTargets()
        {
            PingTarget01(textBoxTargetIp01.Text, Convert.ToInt32(pingInterval));
            PingTarget02(textBoxTargetIp02.Text, Convert.ToInt32(pingInterval));
            PingTarget03(textBoxTargetIp03.Text, Convert.ToInt32(pingInterval));
        }

        public void PingTarget01(string hostname, int time)
        {
            try
            {
                if (!checkBoxActivate01.Checked)
                {
                    return;
                }

                textBoxTargetIp01.Text = hostname;
                ThreadHelperClass.SetText((Form)this, (Control)labelTargetPing01, PingTargets(hostname, time, textBoxTargetDesc01.Text));
            }
            catch (Exception ex)
            {
            }
        }

        private void PingTarget02(string hostname, int time)
        {
            try
            {
                if (!checkBoxActivate02.Checked)
                {
                    return;
                }

                textBoxTargetIp02.Text = hostname;
                ThreadHelperClass.SetText((Form)this, (Control)labelTargetPing02, PingTargets(hostname, time, textBoxTargetDesc02.Text));
            }
            catch (Exception ex)
            {
            }
        }

        private void PingTarget03(string hostname, int time)
        {
            try
            {
                if (!checkBoxActivate03.Checked)
                {
                    return;
                }

                textBoxTargetIp03.Text = hostname;
                ThreadHelperClass.SetText((Form)this, (Control)labelTargetPing03, PingTargets(hostname, time, textBoxTargetDesc03.Text));
            }
            catch (Exception ex)
            {
            }
        }

        private string PingTargets(string hostname, int timeout, string dnsName = "")
        {
            Ping ping = new();

            PingReply pingReply = ping.Send(hostname, timeout);

            string logTextSuccess = hostname + " = " + pingReply.RoundtripTime + " ms" + " - (" + dnsName + ")";
            string logTextFail = MsgStrings(0) + " " + hostname + " (" + dnsName + ")";
            string notifTextFail = "Connection fail detected" + " for" + hostname + " (" + dnsName + ")";

            try
            {
                switch (pingReply.Status)
                {
                    case IPStatus.DestinationHostUnreachable:
                        logger.WriteLog(logTextFail);
                        //richTextBoxLog.AppendText(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination host unreachable", 2000, true);
                        return "Destination host unreachable";
                    case IPStatus.DestinationUnreachable:
                        logger.WriteLog(logTextFail);
                        //richTextBoxLog.AppendText(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination unreachable", 2000, true);
                        return "Destination unreachable";
                    case IPStatus.TimedOut:
                        logger.WriteLog(logTextFail);
                        //richTextBoxLog.AppendText(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination timed out", 2000, true);
                        return "Destination timed out";
                    default:
                        logger.WriteLog(logTextSuccess);
                        //richTextBoxLog.AppendText(logTextSuccess);
                        //DisplayNotification(Application.ProductName, "Destination success", 2000, true);
                        return "" + pingReply.RoundtripTime;
                }
            }
            catch
            {
                logger.WriteLog(logTextFail);
                richTextBoxLog.AppendText(logTextFail);
                //DisplayNotification(Application.ProductName, "Destination exception", 2000, true);
                while (pingReply.Status == IPStatus.DestinationHostUnreachable)
                {
                    return "Destination exception";
                }
                return "Destination exception";
            }
        }

        #endregion

        #region Timer

        System.Timers.Timer pingTimer = new System.Timers.Timer();

        private double pingInterval;

        private void SetPingInterval()
        {
            double interval = Convert.ToDouble(numericUpDownInterval.Value.ToString());

            pingInterval = interval;
        }

        private void SetTimerInterval()
        {
            pingTimer.Interval = pingInterval;
        }

        private void SetPingTimer(double interval)
        {
            pingTimer.Interval = interval;
            pingTimer.Elapsed += OnTimedEvent;
            pingTimer.AutoReset = true;
            pingTimer.Enabled = true;
        }

        private void StopTimer() => pingTimer.Stop();

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            PingTarget01(textBoxTargetIp01.Text, Convert.ToInt32(pingInterval));
            PingTarget02(textBoxTargetIp02.Text, Convert.ToInt32(pingInterval));
            PingTarget03(textBoxTargetIp03.Text, Convert.ToInt32(pingInterval));
        }

        #endregion

        //private void DisplayNotification(string balloonTipTitle, string balloonTipText, int timeframe)
        //{
        //    string str = string.Format("{0:yyyy-MM-dd HH:mm:ss}", (object)DateTime.Now);
        //    if (labelTargetPing01.Text == MsgStrings(0) && labelTargetPing02.Text == MsgStrings(0) && labelTargetPing03.Text == MsgStrings(0))
        //        Logger.WriteFailLog(MsgStrings(0));
        //    if (File.Exists(Logger.failLogFullPath))
        //        return;
        //    notifyIconMain.BalloonTipTitle = balloonTipTitle;
        //    notifyIconMain.BalloonTipText = balloonTipText + " " + str;
        //    notifyIconMain.ShowBalloonTip(timeframe);
        //}

        #region Selection

        private void CheckBoxActivate01_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActivate01.Checked)
            {
                textBoxTargetIp01.Enabled = true;
                textBoxTargetDesc01.Enabled = true;
            }
            else
            {
                textBoxTargetIp01.Enabled = false;
                textBoxTargetDesc01.Enabled = false;
            }
        }

        private void CheckBoxActivate02_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActivate02.Checked)
            {
                textBoxTargetIp02.Enabled = true;
                textBoxTargetDesc02.Enabled = true;
            }
            else
            {
                textBoxTargetIp02.Enabled = false;
                textBoxTargetDesc02.Enabled = false;
            }
        }

        private void CheckBoxActivate03_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActivate03.Checked)
            {
                textBoxTargetIp03.Enabled = true;
                textBoxTargetDesc03.Enabled = true;
            }
            else
            {
                textBoxTargetIp03.Enabled = false;
                textBoxTargetDesc03.Enabled = false;
            }
        }

        private void CheckBoxTargetsAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTargetsAll.Checked)
            {
                checkBoxActivate01.Checked = true;
                checkBoxActivate02.Checked = true;
                checkBoxActivate03.Checked = true;
            }
            else
            {
                checkBoxActivate01.Checked = false;
                checkBoxActivate02.Checked = false;
                checkBoxActivate03.Checked = false;
            }
        }

        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartMonitoring();

        }

        private void StartMonitoring()
        {
            if (!checkBoxActivate01.Checked && !checkBoxActivate02.Checked && !checkBoxActivate03.Checked)
            {
                MessageBox.Show("Nothing selected.\n\nPlease check at least one target.", Application.ProductName);
                return;
            }

            logger.fileNameMainLog = string.Format("{0:yyyy-MM-dd_HH_mm_ss}", DateTime.Now) + ".txt";

            SetPingInterval();

            SetPingTimer(pingInterval);

            bWorker.RunWorkerAsync();

            string startText = String.Format("Monitoring started with interval of {0}ms.", pingInterval.ToString());

            richTextBoxLog.AppendText(startText + " Logging to " + logger.fileNameMainLog + "\n");
            logger.WriteLog(startText);

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            SetControls(false);

            SaveAllSettings();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void StopMonitoring()
        {
            StopTimer();
            bWorker.CancelAsync();

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            SetControls(true);

            richTextBoxLog.AppendText("Monitoring stopped.\n");
            logger.WriteLog("Monitoring stopped.");

            labelTargetPing01.Text = "-";
            labelTargetPing02.Text = "-";
            labelTargetPing03.Text = "-";

        }

        private void SetControls(bool state)
        {
            checkBoxActivate01.Enabled = state;
            checkBoxActivate02.Enabled = state;
            checkBoxActivate03.Enabled = state;
            textBoxTargetIp01.Enabled = state;
            textBoxTargetIp02.Enabled = state;
            textBoxTargetIp03.Enabled = state;
            textBoxTargetDesc01.Enabled = state;
            textBoxTargetDesc02.Enabled = state;
            textBoxTargetDesc03.Enabled = state;
            checkBoxTargetsAll.Enabled = state;
            numericUpDownInterval.Enabled = state;
        }

        private void ButtonSetLogDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            folderBrowserDialog.ShowDialog();
            string selectedPath = folderBrowserDialog.SelectedPath;
            Globals.logPath = selectedPath;
            textBoxLogPath.Text = selectedPath;
            SaveSetting("textBoxLogPath", selectedPath);
        }

        #region Settings

        private static void SaveSetting(string key, string value)
        {
            SettingsHandler.SaveSetting(key, value);
        }

        private static string ReadSetting(string key)
        {
            string setting;

            setting = SettingsHandler.ReadSetting(key);

            return setting;
        }

        private void SaveAllSettings()
        {
            SaveSetting("checkBoxActivate01", Convert.ToString(Convert.ToBoolean(checkBoxActivate01.CheckState)));
            SaveSetting("checkBoxActivate02", Convert.ToString(Convert.ToBoolean(checkBoxActivate02.CheckState)));
            SaveSetting("checkBoxActivate03", Convert.ToString(Convert.ToBoolean(checkBoxActivate03.CheckState)));

            SaveSetting("textBoxTargetIp01", textBoxTargetIp01.Text);
            SaveSetting("textBoxTargetIp02", textBoxTargetIp02.Text);
            SaveSetting("textBoxTargetIp03", textBoxTargetIp03.Text);

            SaveSetting("textBoxTargetDesc01", textBoxTargetDesc01.Text);
            SaveSetting("textBoxTargetDesc02", textBoxTargetDesc02.Text);
            SaveSetting("textBoxTargetDesc03", textBoxTargetDesc03.Text);

            SaveSetting("textBoxInterval", numericUpDownInterval.Text);

            SaveSetting("textBoxLogPath", textBoxLogPath.Text);

            SaveSetting("comboBoxLogLevel", comboBoxLogLevel.Text);
        }

        private void ReadAllSettings()
        {
            checkBoxActivate01.Checked = Convert.ToBoolean(ReadSetting("checkBoxActivate01"));
            checkBoxActivate02.Checked = Convert.ToBoolean(ReadSetting("checkBoxActivate02"));
            checkBoxActivate03.Checked = Convert.ToBoolean(ReadSetting("checkBoxActivate03"));

            textBoxTargetIp01.Text = ReadSetting("textBoxTargetIp01");
            textBoxTargetIp02.Text = ReadSetting("textBoxTargetIp02");
            textBoxTargetIp03.Text = ReadSetting("textBoxTargetIp03");

            textBoxTargetDesc01.Text = ReadSetting("textBoxTargetDesc01");
            textBoxTargetDesc02.Text = ReadSetting("textBoxTargetDesc02");
            textBoxTargetDesc03.Text = ReadSetting("textBoxTargetDesc03");

            numericUpDownInterval.Text = ReadSetting("textBoxInterval");

            string logPath = ReadSetting("textBoxLogPath");

            textBoxLogPath.Text = logPath;
            Globals.logPath = logPath;

            comboBoxLogLevel.SelectedItem = ReadSetting("comboBoxLogLevel");
        }

        #endregion

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            StartMonitoring();
        }

        private void ToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void ToolStripMenuItemMaximize_Click(object sender, EventArgs e)
        {
            FormMain_Resize(toolStripMenuItemMaximize, e);
        }

        void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = true;
                Hide();
                notifyIconMain.Visible = true;
            }
        }

        private void NotifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconMain.Visible = false;
        }

        void FormMain_Show(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            ShowInTaskbar = true;
            Show();
            Focus();
            notifyIconMain.Visible = false;
        }

        private void ButtonOpenLogDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", Globals.logPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open log directory.\n\n" + ex.Message, Application.ProductName + "- ERROR");
            }
        }
    }
}