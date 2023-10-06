namespace NetPulseCheck
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControlMain = new TabControl();
            tabPageControls = new TabPage();
            groupBoxControls = new GroupBox();
            numericUpDownInterval = new NumericUpDown();
            buttonOpenLogDir = new Button();
            labelInterval = new Label();
            buttonStop = new Button();
            buttonStart = new Button();
            labelTargetPing03 = new Label();
            labelTargetPing02 = new Label();
            labelTargetPing01 = new Label();
            textBoxTargetIp03 = new TextBox();
            textBoxTargetIp02 = new TextBox();
            textBoxTargetDesc03 = new TextBox();
            textBoxTargetDesc02 = new TextBox();
            textBoxTargetDesc01 = new TextBox();
            textBoxTargetIp01 = new TextBox();
            labelTargetPing = new Label();
            labelTargetDNS = new Label();
            labelTargetIp = new Label();
            checkBoxTargetsAll = new CheckBox();
            checkBoxActivate03 = new CheckBox();
            checkBoxActivate02 = new CheckBox();
            checkBoxActivate01 = new CheckBox();
            richTextBoxLog = new RichTextBox();
            tabPageOptions = new TabPage();
            groupBoxOptionsApp = new GroupBox();
            checkBoxStartMini = new CheckBox();
            checkBoxMonitorStart = new CheckBox();
            checkBoxStartWin = new CheckBox();
            groupBoxLogging = new GroupBox();
            comboBoxCSVSeparator = new ComboBox();
            labelCSVSeparator = new Label();
            labelLogDirPath = new Label();
            comboBoxLogLevel = new ComboBox();
            label1 = new Label();
            buttonSetLogDir = new Button();
            textBoxLogPath = new TextBox();
            notifyIconMain = new NotifyIcon(components);
            contextMenuStripMain = new ContextMenuStrip(components);
            toolStripMenuItemMaximize = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemStart = new ToolStripMenuItem();
            toolStripMenuItemStop = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemExit = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            tabPageControls.SuspendLayout();
            groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).BeginInit();
            tabPageOptions.SuspendLayout();
            groupBoxOptionsApp.SuspendLayout();
            groupBoxLogging.SuspendLayout();
            contextMenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageControls);
            tabControlMain.Controls.Add(tabPageOptions);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(710, 548);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageControls
            // 
            tabPageControls.Controls.Add(groupBoxControls);
            tabPageControls.Controls.Add(richTextBoxLog);
            tabPageControls.Location = new Point(4, 24);
            tabPageControls.Name = "tabPageControls";
            tabPageControls.Padding = new Padding(3);
            tabPageControls.Size = new Size(702, 520);
            tabPageControls.TabIndex = 0;
            tabPageControls.Text = "Controls";
            tabPageControls.UseVisualStyleBackColor = true;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(numericUpDownInterval);
            groupBoxControls.Controls.Add(buttonOpenLogDir);
            groupBoxControls.Controls.Add(labelInterval);
            groupBoxControls.Controls.Add(buttonStop);
            groupBoxControls.Controls.Add(buttonStart);
            groupBoxControls.Controls.Add(labelTargetPing03);
            groupBoxControls.Controls.Add(labelTargetPing02);
            groupBoxControls.Controls.Add(labelTargetPing01);
            groupBoxControls.Controls.Add(textBoxTargetIp03);
            groupBoxControls.Controls.Add(textBoxTargetIp02);
            groupBoxControls.Controls.Add(textBoxTargetDesc03);
            groupBoxControls.Controls.Add(textBoxTargetDesc02);
            groupBoxControls.Controls.Add(textBoxTargetDesc01);
            groupBoxControls.Controls.Add(textBoxTargetIp01);
            groupBoxControls.Controls.Add(labelTargetPing);
            groupBoxControls.Controls.Add(labelTargetDNS);
            groupBoxControls.Controls.Add(labelTargetIp);
            groupBoxControls.Controls.Add(checkBoxTargetsAll);
            groupBoxControls.Controls.Add(checkBoxActivate03);
            groupBoxControls.Controls.Add(checkBoxActivate02);
            groupBoxControls.Controls.Add(checkBoxActivate01);
            groupBoxControls.Location = new Point(6, 6);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(690, 247);
            groupBoxControls.TabIndex = 0;
            groupBoxControls.TabStop = false;
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownInterval.Location = new Point(334, 154);
            numericUpDownInterval.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            numericUpDownInterval.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new Size(120, 23);
            numericUpDownInterval.TabIndex = 10;
            numericUpDownInterval.TextAlign = HorizontalAlignment.Right;
            numericUpDownInterval.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // buttonOpenLogDir
            // 
            buttonOpenLogDir.Location = new Point(613, 186);
            buttonOpenLogDir.Name = "buttonOpenLogDir";
            buttonOpenLogDir.Size = new Size(71, 55);
            buttonOpenLogDir.TabIndex = 9;
            buttonOpenLogDir.Text = "Open log folder";
            buttonOpenLogDir.UseVisualStyleBackColor = true;
            buttonOpenLogDir.Click += ButtonOpenLogDir_Click;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new Point(207, 156);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(121, 15);
            labelInterval.TabIndex = 8;
            labelInterval.Text = "Request interval (ms):";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(6, 186);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(601, 23);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += ButtonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(6, 211);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(601, 30);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // labelTargetPing03
            // 
            labelTargetPing03.AutoSize = true;
            labelTargetPing03.Location = new Point(520, 108);
            labelTargetPing03.Name = "labelTargetPing03";
            labelTargetPing03.Size = new Size(12, 15);
            labelTargetPing03.TabIndex = 4;
            labelTargetPing03.Text = "-";
            // 
            // labelTargetPing02
            // 
            labelTargetPing02.AutoSize = true;
            labelTargetPing02.Location = new Point(520, 83);
            labelTargetPing02.Name = "labelTargetPing02";
            labelTargetPing02.Size = new Size(12, 15);
            labelTargetPing02.TabIndex = 4;
            labelTargetPing02.Text = "-";
            // 
            // labelTargetPing01
            // 
            labelTargetPing01.AutoSize = true;
            labelTargetPing01.Location = new Point(520, 58);
            labelTargetPing01.Name = "labelTargetPing01";
            labelTargetPing01.Size = new Size(12, 15);
            labelTargetPing01.TabIndex = 4;
            labelTargetPing01.Text = "-";
            // 
            // textBoxTargetIp03
            // 
            textBoxTargetIp03.Location = new Point(52, 105);
            textBoxTargetIp03.Name = "textBoxTargetIp03";
            textBoxTargetIp03.Size = new Size(149, 23);
            textBoxTargetIp03.TabIndex = 3;
            // 
            // textBoxTargetIp02
            // 
            textBoxTargetIp02.Location = new Point(52, 80);
            textBoxTargetIp02.Name = "textBoxTargetIp02";
            textBoxTargetIp02.Size = new Size(149, 23);
            textBoxTargetIp02.TabIndex = 3;
            // 
            // textBoxTargetDesc03
            // 
            textBoxTargetDesc03.Location = new Point(207, 105);
            textBoxTargetDesc03.Name = "textBoxTargetDesc03";
            textBoxTargetDesc03.Size = new Size(243, 23);
            textBoxTargetDesc03.TabIndex = 3;
            // 
            // textBoxTargetDesc02
            // 
            textBoxTargetDesc02.Location = new Point(207, 80);
            textBoxTargetDesc02.Name = "textBoxTargetDesc02";
            textBoxTargetDesc02.Size = new Size(243, 23);
            textBoxTargetDesc02.TabIndex = 3;
            // 
            // textBoxTargetDesc01
            // 
            textBoxTargetDesc01.Location = new Point(207, 55);
            textBoxTargetDesc01.Name = "textBoxTargetDesc01";
            textBoxTargetDesc01.Size = new Size(243, 23);
            textBoxTargetDesc01.TabIndex = 3;
            // 
            // textBoxTargetIp01
            // 
            textBoxTargetIp01.Location = new Point(52, 55);
            textBoxTargetIp01.Name = "textBoxTargetIp01";
            textBoxTargetIp01.Size = new Size(149, 23);
            textBoxTargetIp01.TabIndex = 3;
            // 
            // labelTargetPing
            // 
            labelTargetPing.AutoSize = true;
            labelTargetPing.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTargetPing.Location = new Point(458, 28);
            labelTargetPing.Name = "labelTargetPing";
            labelTargetPing.Size = new Size(149, 20);
            labelTargetPing.TabIndex = 2;
            labelTargetPing.Text = "Response time (ms)";
            // 
            // labelTargetDNS
            // 
            labelTargetDNS.AutoSize = true;
            labelTargetDNS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTargetDNS.Location = new Point(242, 28);
            labelTargetDNS.Name = "labelTargetDNS";
            labelTargetDNS.Size = new Size(136, 20);
            labelTargetDNS.TabIndex = 2;
            labelTargetDNS.Text = "Target description";
            // 
            // labelTargetIp
            // 
            labelTargetIp.AutoSize = true;
            labelTargetIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTargetIp.Location = new Point(73, 28);
            labelTargetIp.Name = "labelTargetIp";
            labelTargetIp.Size = new Size(110, 20);
            labelTargetIp.TabIndex = 2;
            labelTargetIp.Text = "Target IP/DNS";
            // 
            // checkBoxTargetsAll
            // 
            checkBoxTargetsAll.AutoSize = true;
            checkBoxTargetsAll.Location = new Point(20, 155);
            checkBoxTargetsAll.Name = "checkBoxTargetsAll";
            checkBoxTargetsAll.Size = new Size(110, 19);
            checkBoxTargetsAll.TabIndex = 1;
            checkBoxTargetsAll.Text = "Select all / none";
            checkBoxTargetsAll.UseVisualStyleBackColor = true;
            checkBoxTargetsAll.CheckedChanged += CheckBoxTargetsAll_CheckedChanged;
            // 
            // checkBoxActivate03
            // 
            checkBoxActivate03.AutoSize = true;
            checkBoxActivate03.Location = new Point(20, 109);
            checkBoxActivate03.Name = "checkBoxActivate03";
            checkBoxActivate03.Size = new Size(15, 14);
            checkBoxActivate03.TabIndex = 0;
            checkBoxActivate03.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivate02
            // 
            checkBoxActivate02.AutoSize = true;
            checkBoxActivate02.Location = new Point(20, 84);
            checkBoxActivate02.Name = "checkBoxActivate02";
            checkBoxActivate02.Size = new Size(15, 14);
            checkBoxActivate02.TabIndex = 0;
            checkBoxActivate02.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivate01
            // 
            checkBoxActivate01.AutoSize = true;
            checkBoxActivate01.Location = new Point(20, 59);
            checkBoxActivate01.Name = "checkBoxActivate01";
            checkBoxActivate01.Size = new Size(15, 14);
            checkBoxActivate01.TabIndex = 0;
            checkBoxActivate01.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Location = new Point(6, 259);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(690, 255);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "";
            // 
            // tabPageOptions
            // 
            tabPageOptions.Controls.Add(groupBoxOptionsApp);
            tabPageOptions.Controls.Add(groupBoxLogging);
            tabPageOptions.Location = new Point(4, 24);
            tabPageOptions.Name = "tabPageOptions";
            tabPageOptions.Padding = new Padding(3);
            tabPageOptions.Size = new Size(702, 520);
            tabPageOptions.TabIndex = 1;
            tabPageOptions.Text = "Options";
            tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptionsApp
            // 
            groupBoxOptionsApp.Controls.Add(checkBoxStartMini);
            groupBoxOptionsApp.Controls.Add(checkBoxMonitorStart);
            groupBoxOptionsApp.Controls.Add(checkBoxStartWin);
            groupBoxOptionsApp.Location = new Point(6, 163);
            groupBoxOptionsApp.Name = "groupBoxOptionsApp";
            groupBoxOptionsApp.Size = new Size(690, 350);
            groupBoxOptionsApp.TabIndex = 5;
            groupBoxOptionsApp.TabStop = false;
            groupBoxOptionsApp.Text = "Application";
            // 
            // checkBoxStartMini
            // 
            checkBoxStartMini.AutoSize = true;
            checkBoxStartMini.Location = new Point(22, 95);
            checkBoxStartMini.Name = "checkBoxStartMini";
            checkBoxStartMini.Size = new Size(86, 19);
            checkBoxStartMini.TabIndex = 2;
            checkBoxStartMini.Text = "Start in tray";
            checkBoxStartMini.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonitorStart
            // 
            checkBoxMonitorStart.AutoSize = true;
            checkBoxMonitorStart.Location = new Point(22, 70);
            checkBoxMonitorStart.Name = "checkBoxMonitorStart";
            checkBoxMonitorStart.Size = new Size(170, 19);
            checkBoxMonitorStart.TabIndex = 1;
            checkBoxMonitorStart.Text = "Start monitoring on startup";
            checkBoxMonitorStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartWin
            // 
            checkBoxStartWin.AutoSize = true;
            checkBoxStartWin.Location = new Point(22, 45);
            checkBoxStartWin.Name = "checkBoxStartWin";
            checkBoxStartWin.Size = new Size(128, 19);
            checkBoxStartWin.TabIndex = 0;
            checkBoxStartWin.Text = "Start with Windows";
            checkBoxStartWin.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogging
            // 
            groupBoxLogging.Controls.Add(comboBoxCSVSeparator);
            groupBoxLogging.Controls.Add(labelCSVSeparator);
            groupBoxLogging.Controls.Add(labelLogDirPath);
            groupBoxLogging.Controls.Add(comboBoxLogLevel);
            groupBoxLogging.Controls.Add(label1);
            groupBoxLogging.Controls.Add(buttonSetLogDir);
            groupBoxLogging.Controls.Add(textBoxLogPath);
            groupBoxLogging.Location = new Point(6, 6);
            groupBoxLogging.Name = "groupBoxLogging";
            groupBoxLogging.Size = new Size(690, 151);
            groupBoxLogging.TabIndex = 4;
            groupBoxLogging.TabStop = false;
            groupBoxLogging.Text = "Logging";
            // 
            // comboBoxCSVSeparator
            // 
            comboBoxCSVSeparator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCSVSeparator.FormattingEnabled = true;
            comboBoxCSVSeparator.Items.AddRange(new object[] { ";", ",", "Tab" });
            comboBoxCSVSeparator.Location = new Point(121, 109);
            comboBoxCSVSeparator.Name = "comboBoxCSVSeparator";
            comboBoxCSVSeparator.Size = new Size(285, 23);
            comboBoxCSVSeparator.TabIndex = 5;
            comboBoxCSVSeparator.Visible = false;
            // 
            // labelCSVSeparator
            // 
            labelCSVSeparator.AutoSize = true;
            labelCSVSeparator.Location = new Point(6, 112);
            labelCSVSeparator.Name = "labelCSVSeparator";
            labelCSVSeparator.Size = new Size(83, 15);
            labelCSVSeparator.TabIndex = 4;
            labelCSVSeparator.Text = "CSV separator:";
            labelCSVSeparator.Visible = false;
            // 
            // labelLogDirPath
            // 
            labelLogDirPath.AutoSize = true;
            labelLogDirPath.Location = new Point(6, 19);
            labelLogDirPath.Name = "labelLogDirPath";
            labelLogDirPath.Size = new Size(99, 15);
            labelLogDirPath.TabIndex = 0;
            labelLogDirPath.Text = "Log file directory:";
            // 
            // comboBoxLogLevel
            // 
            comboBoxLogLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLogLevel.FormattingEnabled = true;
            comboBoxLogLevel.Items.AddRange(new object[] { "ERROR", "DEBUG", "TRACE" });
            comboBoxLogLevel.Location = new Point(121, 63);
            comboBoxLogLevel.Name = "comboBoxLogLevel";
            comboBoxLogLevel.Size = new Size(285, 23);
            comboBoxLogLevel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Log level:";
            // 
            // buttonSetLogDir
            // 
            buttonSetLogDir.Location = new Point(412, 15);
            buttonSetLogDir.Name = "buttonSetLogDir";
            buttonSetLogDir.Size = new Size(75, 23);
            buttonSetLogDir.TabIndex = 2;
            buttonSetLogDir.Text = "Browse";
            buttonSetLogDir.UseVisualStyleBackColor = true;
            buttonSetLogDir.Click += ButtonSetLogDir_Click;
            // 
            // textBoxLogPath
            // 
            textBoxLogPath.Location = new Point(121, 16);
            textBoxLogPath.Name = "textBoxLogPath";
            textBoxLogPath.Size = new Size(285, 23);
            textBoxLogPath.TabIndex = 1;
            // 
            // notifyIconMain
            // 
            notifyIconMain.ContextMenuStrip = contextMenuStripMain;
            notifyIconMain.Icon = (Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "NetPulseCheck";
            notifyIconMain.Visible = true;
            notifyIconMain.MouseDoubleClick += NotifyIconMain_MouseDoubleClick;
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMaximize, toolStripSeparator2, toolStripMenuItemStart, toolStripMenuItemStop, toolStripSeparator1, toolStripMenuItemExit });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new Size(187, 104);
            // 
            // toolStripMenuItemMaximize
            // 
            toolStripMenuItemMaximize.Name = "toolStripMenuItemMaximize";
            toolStripMenuItemMaximize.Size = new Size(186, 22);
            toolStripMenuItemMaximize.Text = "Open NetPulseCheck";
            toolStripMenuItemMaximize.Click += ToolStripMenuItemMaximize_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // toolStripMenuItemStart
            // 
            toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            toolStripMenuItemStart.Size = new Size(186, 22);
            toolStripMenuItemStart.Text = "Start monitoring";
            toolStripMenuItemStart.Click += ToolStripMenuItemStart_Click;
            // 
            // toolStripMenuItemStop
            // 
            toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            toolStripMenuItemStop.Size = new Size(186, 22);
            toolStripMenuItemStop.Text = "Stop monitoring";
            toolStripMenuItemStop.Click += ToolStripMenuItemStop_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(183, 6);
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(186, 22);
            toolStripMenuItemExit.Text = "Exit application";
            toolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(tabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(750, 750);
            MinimumSize = new Size(750, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NetPulseCheck";
            MouseDoubleClick += NotifyIconMain_MouseDoubleClick;
            Resize += FormMain_Resize;
            tabControlMain.ResumeLayout(false);
            tabPageControls.ResumeLayout(false);
            groupBoxControls.ResumeLayout(false);
            groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).EndInit();
            tabPageOptions.ResumeLayout(false);
            groupBoxOptionsApp.ResumeLayout(false);
            groupBoxOptionsApp.PerformLayout();
            groupBoxLogging.ResumeLayout(false);
            groupBoxLogging.PerformLayout();
            contextMenuStripMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageControls;
        private TabPage tabPageOptions;
        private GroupBox groupBoxControls;
        private CheckBox checkBoxActivate03;
        private CheckBox checkBoxActivate02;
        private CheckBox checkBoxActivate01;
        private CheckBox checkBoxTargetsAll;
        private Label labelTargetIp;
        private TextBox textBoxTargetIp03;
        private TextBox textBoxTargetIp02;
        private TextBox textBoxTargetIp01;
        private Label labelTargetDNS;
        private TextBox textBoxTargetDesc01;
        private TextBox textBoxTargetDesc02;
        private TextBox textBoxTargetDesc03;
        private Label labelTargetPing;
        private Label labelTargetPing01;
        private Label labelTargetPing03;
        private Label labelTargetPing02;
        private Button buttonStart;
        private Button buttonStop;
        private NotifyIcon notifyIconMain;
        private Label labelLogDirPath;
        private TextBox textBoxLogPath;
        private Button buttonSetLogDir;
        private ComboBox comboBoxLogLevel;
        private Label label1;
        private Label labelInterval;
        private GroupBox groupBoxLogging;
        private GroupBox groupBoxOptionsApp;
        private ContextMenuStrip contextMenuStripMain;
        private ToolStripMenuItem toolStripMenuItemStart;
        private ToolStripMenuItem toolStripMenuItemStop;
        private ToolStripMenuItem toolStripMenuItemMaximize;
        private RichTextBox richTextBoxLog;
        private Button buttonOpenLogDir;
        private NumericUpDown numericUpDownInterval;
        private Label labelCSVSeparator;
        private ComboBox comboBoxCSVSeparator;
        private CheckBox checkBoxStartWin;
        private CheckBox checkBoxMonitorStart;
        private CheckBox checkBoxStartMini;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
    }
}