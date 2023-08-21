using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Timers;

namespace NetUptimeMonitor
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
        }



        #region backgroundWorker

        BackgroundWorker bWorker = new BackgroundWorker()
        {
            WorkerSupportsCancellation = true
        };

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            PingAllTargets();
            Logger.WriteLog("Process started.");
            if (bWorker.CancellationPending)
                return;
            e.Cancel = true;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
                return;
            Logger.WriteLog("Process stopped.");
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

        public void PingAllTargets()
        {
            PingTarget01("8.8.8.8", 2000);
            PingTarget02("1.1.1.1", 2000);
            PingTarget03("4.2.2.2", 2000);
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
            //Ping ping = new Ping();

            //try
            //{
            //    PingReply pingReply = ping.Send(hostname, timeout);
            //    if (pingReply.Status == IPStatus.Success)
            //    {
            //        if (File.Exists(Logger.failLogFullPath)) {
            //            File.Delete(Logger.failLogFullPath);
            //            Logger.WriteLog(hostname + " (" + dnsName + ") = " + pingReply.RoundtripTime.ToString() + "ms");
            //            return pingReply.RoundtripTime.ToString();
            //        }

            //    }
            //    Logger.WriteLog(MsgStrings(0) + " " + hostname + " (" + dnsName + ")");
            //    return MsgStrings(0);
            //}
            //catch (PingException ex)
            //{
            //    Logger.WriteLog(MsgStrings(0) + " " + hostname);
            //    return MsgStrings(0);
            //}

            Ping ping = new Ping();

            string logTextFail = MsgStrings(0) + " " + hostname + " (" + dnsName + ")";
            string notifTextFail = "Connection fail detected" + " for" + hostname + " (" + dnsName + ")";


            PingReply pingReply = ping.Send(hostname, timeout);

            string logTextSuccess = "Reached " + hostname + " (" + dnsName + ")" + " with roundtrip time of " + pingReply.RoundtripTime + "ms";

            try
            {
                switch (pingReply.Status)
                {
                    case IPStatus.DestinationHostUnreachable:
                        Logger.WriteLog(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination host unreachable", 2000, true);
                        return "Destination host unreachable";
                    case IPStatus.DestinationUnreachable:
                        Logger.WriteLog(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination unreachable", 2000, true);
                        return "Destination unreachable";
                    case IPStatus.TimedOut:
                        Logger.WriteLog(logTextFail);
                        //DisplayNotification(Application.ProductName, "Destination timed out", 2000, true);
                        return "Destination timed out";
                    default:
                        Logger.WriteLog(logTextSuccess);
                        //DisplayNotification(Application.ProductName, "Destination success", 2000, true);
                        return "" + pingReply.RoundtripTime;
                }
            }
            catch
            {
                Logger.WriteLog(logTextFail);
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

        private void SetTimerInterval(double interval)
        {
            pingTimer.Interval = interval;
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
            PingTarget01(textBoxTargetIp01.Text, 2000);
            PingTarget02(textBoxTargetIp02.Text, 2000);
            PingTarget03(textBoxTargetIp03.Text, 2000);
        }

        #endregion

        private void DisplayNotification(string balloonTipTitle, string balloonTipText, int timeframe)
        {
            string str = string.Format("{0:yyyy-MM-dd HH:mm:ss}", (object)DateTime.Now);
            if (labelTargetPing01.Text == MsgStrings(0) && labelTargetPing02.Text == MsgStrings(0) && labelTargetPing03.Text == MsgStrings(0))
                Logger.WriteFailLog(MsgStrings(0));
            if (File.Exists(Logger.failLogFullPath))
                return;
            notifyIconMain.BalloonTipTitle = balloonTipTitle;
            notifyIconMain.BalloonTipText = balloonTipText + " " + str;
            notifyIconMain.ShowBalloonTip(timeframe);
        }

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
            SetPingTimer(2000);
            bWorker.RunWorkerAsync();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            SetControls(false);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            StopTimer();
            bWorker.CancelAsync();

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            SetControls(true);
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
        }
    }
}