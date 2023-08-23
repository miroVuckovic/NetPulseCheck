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
            labelInterval = new Label();
            textBoxInterval = new TextBox();
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
            tabPageOptions = new TabPage();
            comboBoxLogLevel = new ComboBox();
            buttonSetLogDir = new Button();
            textBoxLogPath = new TextBox();
            label1 = new Label();
            labelLogDirPath = new Label();
            notifyIconMain = new NotifyIcon(components);
            tabControlMain.SuspendLayout();
            tabPageControls.SuspendLayout();
            groupBoxControls.SuspendLayout();
            tabPageOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageControls);
            tabControlMain.Controls.Add(tabPageOptions);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(710, 287);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageControls
            // 
            tabPageControls.Controls.Add(groupBoxControls);
            tabPageControls.Location = new Point(4, 24);
            tabPageControls.Name = "tabPageControls";
            tabPageControls.Padding = new Padding(3);
            tabPageControls.Size = new Size(702, 259);
            tabPageControls.TabIndex = 0;
            tabPageControls.Text = "Controls";
            tabPageControls.UseVisualStyleBackColor = true;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(labelInterval);
            groupBoxControls.Controls.Add(textBoxInterval);
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
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new Point(207, 156);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(121, 15);
            labelInterval.TabIndex = 8;
            labelInterval.Text = "Request interval (ms):";
            // 
            // textBoxInterval
            // 
            textBoxInterval.Location = new Point(334, 151);
            textBoxInterval.Name = "textBoxInterval";
            textBoxInterval.Size = new Size(116, 23);
            textBoxInterval.TabIndex = 7;
            textBoxInterval.Text = "5000";
            textBoxInterval.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(6, 186);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(678, 23);
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
            buttonStart.Size = new Size(678, 30);
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
            // tabPageOptions
            // 
            tabPageOptions.Controls.Add(comboBoxLogLevel);
            tabPageOptions.Controls.Add(buttonSetLogDir);
            tabPageOptions.Controls.Add(textBoxLogPath);
            tabPageOptions.Controls.Add(label1);
            tabPageOptions.Controls.Add(labelLogDirPath);
            tabPageOptions.Location = new Point(4, 24);
            tabPageOptions.Name = "tabPageOptions";
            tabPageOptions.Padding = new Padding(3);
            tabPageOptions.Size = new Size(702, 259);
            tabPageOptions.TabIndex = 1;
            tabPageOptions.Text = "Options";
            tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // comboBoxLogLevel
            // 
            comboBoxLogLevel.FormattingEnabled = true;
            comboBoxLogLevel.Items.AddRange(new object[] { "ERROR", "DEBUG", "TRACE" });
            comboBoxLogLevel.Location = new Point(121, 76);
            comboBoxLogLevel.Name = "comboBoxLogLevel";
            comboBoxLogLevel.Size = new Size(285, 23);
            comboBoxLogLevel.TabIndex = 3;
            // 
            // buttonSetLogDir
            // 
            buttonSetLogDir.Location = new Point(412, 29);
            buttonSetLogDir.Name = "buttonSetLogDir";
            buttonSetLogDir.Size = new Size(75, 23);
            buttonSetLogDir.TabIndex = 2;
            buttonSetLogDir.Text = "Browse";
            buttonSetLogDir.UseVisualStyleBackColor = true;
            buttonSetLogDir.Click += ButtonSetLogDir_Click;
            // 
            // textBoxLogPath
            // 
            textBoxLogPath.Location = new Point(121, 30);
            textBoxLogPath.Name = "textBoxLogPath";
            textBoxLogPath.Size = new Size(285, 23);
            textBoxLogPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Log level:";
            // 
            // labelLogDirPath
            // 
            labelLogDirPath.AutoSize = true;
            labelLogDirPath.Location = new Point(6, 33);
            labelLogDirPath.Name = "labelLogDirPath";
            labelLogDirPath.Size = new Size(99, 15);
            labelLogDirPath.TabIndex = 0;
            labelLogDirPath.Text = "Log file directory:";
            // 
            // notifyIconMain
            // 
            notifyIconMain.Icon = (Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "notifyIconMain";
            notifyIconMain.Visible = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 311);
            Controls.Add(tabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(750, 350);
            MinimumSize = new Size(750, 350);
            Name = "FormMain";
            Text = "NetPulseCheck";
            tabControlMain.ResumeLayout(false);
            tabPageControls.ResumeLayout(false);
            groupBoxControls.ResumeLayout(false);
            groupBoxControls.PerformLayout();
            tabPageOptions.ResumeLayout(false);
            tabPageOptions.PerformLayout();
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
        private TextBox textBoxInterval;
        private Label labelInterval;
    }
}