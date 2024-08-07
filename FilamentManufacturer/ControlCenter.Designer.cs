namespace FilamentManufacturer
{
    partial class ControlCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTemperatureTitle = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnDisableAll = new Button();
            btnDisableEngine = new Button();
            btnEnableHotend = new Button();
            btnEnableEngine = new Button();
            btnDisableHotend = new Button();
            lblSerialPortConnection = new Label();
            grpInfo = new GroupBox();
            lblHotendStatusTitle = new Label();
            lblHotendStatus = new Label();
            lblEngineStatusTitle = new Label();
            lblEngineStatus = new Label();
            lblEngineRPMTitle = new Label();
            lblEngineRPM = new Label();
            lblThermistor = new Label();
            lblTitle = new Label();
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grpInfo.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTemperatureTitle
            // 
            lblTemperatureTitle.AutoSize = true;
            lblTemperatureTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTemperatureTitle.Location = new Point(6, 19);
            lblTemperatureTitle.Name = "lblTemperatureTitle";
            lblTemperatureTitle.Size = new Size(111, 21);
            lblTemperatureTitle.TabIndex = 0;
            lblTemperatureTitle.Text = "Temperature:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblSerialPortConnection);
            panel1.Controls.Add(grpInfo);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 298);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDisableAll);
            groupBox1.Controls.Add(btnDisableEngine);
            groupBox1.Controls.Add(btnEnableHotend);
            groupBox1.Controls.Add(btnEnableEngine);
            groupBox1.Controls.Add(btnDisableHotend);
            groupBox1.Location = new Point(3, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 109);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // btnDisableAll
            // 
            btnDisableAll.BackColor = Color.FromArgb(64, 64, 64);
            btnDisableAll.Enabled = false;
            btnDisableAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDisableAll.ForeColor = Color.Black;
            btnDisableAll.Location = new Point(177, 61);
            btnDisableAll.Name = "btnDisableAll";
            btnDisableAll.Size = new Size(151, 33);
            btnDisableAll.TabIndex = 11;
            btnDisableAll.Text = "Disable All";
            btnDisableAll.UseVisualStyleBackColor = true;
            // 
            // btnDisableEngine
            // 
            btnDisableEngine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisableEngine.BackColor = Color.FromArgb(64, 64, 64);
            btnDisableEngine.Enabled = false;
            btnDisableEngine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDisableEngine.ForeColor = Color.Black;
            btnDisableEngine.Location = new Point(344, 61);
            btnDisableEngine.Name = "btnDisableEngine";
            btnDisableEngine.Size = new Size(151, 33);
            btnDisableEngine.TabIndex = 10;
            btnDisableEngine.Text = "Disable Engine";
            btnDisableEngine.UseVisualStyleBackColor = true;
            // 
            // btnEnableHotend
            // 
            btnEnableHotend.BackColor = Color.FromArgb(64, 64, 64);
            btnEnableHotend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEnableHotend.ForeColor = Color.Black;
            btnEnableHotend.Location = new Point(6, 22);
            btnEnableHotend.Name = "btnEnableHotend";
            btnEnableHotend.Size = new Size(151, 33);
            btnEnableHotend.TabIndex = 7;
            btnEnableHotend.Text = "Enable Hotend";
            btnEnableHotend.UseVisualStyleBackColor = true;
            // 
            // btnEnableEngine
            // 
            btnEnableEngine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnableEngine.BackColor = Color.White;
            btnEnableEngine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEnableEngine.ForeColor = Color.Black;
            btnEnableEngine.Location = new Point(344, 22);
            btnEnableEngine.Name = "btnEnableEngine";
            btnEnableEngine.Size = new Size(151, 33);
            btnEnableEngine.TabIndex = 9;
            btnEnableEngine.Text = "Enable Engine";
            btnEnableEngine.UseVisualStyleBackColor = true;
            // 
            // btnDisableHotend
            // 
            btnDisableHotend.BackColor = Color.FromArgb(64, 64, 64);
            btnDisableHotend.Enabled = false;
            btnDisableHotend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDisableHotend.ForeColor = Color.Black;
            btnDisableHotend.Location = new Point(6, 61);
            btnDisableHotend.Name = "btnDisableHotend";
            btnDisableHotend.Size = new Size(151, 33);
            btnDisableHotend.TabIndex = 8;
            btnDisableHotend.Text = "Disable Hotend";
            btnDisableHotend.UseVisualStyleBackColor = true;
            // 
            // lblSerialPortConnection
            // 
            lblSerialPortConnection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSerialPortConnection.AutoSize = true;
            lblSerialPortConnection.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSerialPortConnection.ForeColor = Color.Yellow;
            lblSerialPortConnection.Location = new Point(264, 60);
            lblSerialPortConnection.Name = "lblSerialPortConnection";
            lblSerialPortConnection.Size = new Size(225, 28);
            lblSerialPortConnection.TabIndex = 6;
            lblSerialPortConnection.Text = "Searching Serial Port...";
            lblSerialPortConnection.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblHotendStatusTitle);
            grpInfo.Controls.Add(lblHotendStatus);
            grpInfo.Controls.Add(lblEngineStatusTitle);
            grpInfo.Controls.Add(lblEngineStatus);
            grpInfo.Controls.Add(lblEngineRPMTitle);
            grpInfo.Controls.Add(lblEngineRPM);
            grpInfo.Controls.Add(lblTemperatureTitle);
            grpInfo.Controls.Add(lblThermistor);
            grpInfo.Location = new Point(3, 31);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(255, 143);
            grpInfo.TabIndex = 5;
            grpInfo.TabStop = false;
            grpInfo.Text = "Informations";
            // 
            // lblHotendStatusTitle
            // 
            lblHotendStatusTitle.AutoSize = true;
            lblHotendStatusTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHotendStatusTitle.Location = new Point(6, 112);
            lblHotendStatusTitle.Name = "lblHotendStatusTitle";
            lblHotendStatusTitle.Size = new Size(122, 21);
            lblHotendStatusTitle.TabIndex = 7;
            lblHotendStatusTitle.Text = "Hotend Status:";
            // 
            // lblHotendStatus
            // 
            lblHotendStatus.AutoSize = true;
            lblHotendStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHotendStatus.ForeColor = Color.Red;
            lblHotendStatus.Location = new Point(134, 112);
            lblHotendStatus.Name = "lblHotendStatus";
            lblHotendStatus.Size = new Size(74, 21);
            lblHotendStatus.TabIndex = 8;
            lblHotendStatus.Text = "Stopped";
            // 
            // lblEngineStatusTitle
            // 
            lblEngineStatusTitle.AutoSize = true;
            lblEngineStatusTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEngineStatusTitle.Location = new Point(6, 81);
            lblEngineStatusTitle.Name = "lblEngineStatusTitle";
            lblEngineStatusTitle.Size = new Size(118, 21);
            lblEngineStatusTitle.TabIndex = 5;
            lblEngineStatusTitle.Text = "Engine Status:";
            // 
            // lblEngineStatus
            // 
            lblEngineStatus.AutoSize = true;
            lblEngineStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEngineStatus.ForeColor = Color.Red;
            lblEngineStatus.Location = new Point(130, 81);
            lblEngineStatus.Name = "lblEngineStatus";
            lblEngineStatus.Size = new Size(74, 21);
            lblEngineStatus.TabIndex = 6;
            lblEngineStatus.Text = "Stopped";
            // 
            // lblEngineRPMTitle
            // 
            lblEngineRPMTitle.AutoSize = true;
            lblEngineRPMTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEngineRPMTitle.Location = new Point(6, 50);
            lblEngineRPMTitle.Name = "lblEngineRPMTitle";
            lblEngineRPMTitle.Size = new Size(106, 21);
            lblEngineRPMTitle.TabIndex = 3;
            lblEngineRPMTitle.Text = "Engine RPM:";
            // 
            // lblEngineRPM
            // 
            lblEngineRPM.AutoSize = true;
            lblEngineRPM.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEngineRPM.Location = new Point(123, 50);
            lblEngineRPM.Name = "lblEngineRPM";
            lblEngineRPM.Size = new Size(19, 21);
            lblEngineRPM.TabIndex = 4;
            lblEngineRPM.Text = "0";
            // 
            // lblThermistor
            // 
            lblThermistor.AutoSize = true;
            lblThermistor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThermistor.Location = new Point(123, 19);
            lblThermistor.Name = "lblThermistor";
            lblThermistor.Size = new Size(83, 21);
            lblThermistor.TabIndex = 2;
            lblThermistor.Text = "0 °C / 0 °C";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.Location = new Point(174, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Control Center";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(150, 150, 150);
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(531, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "mnuOptions";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem1 });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(170, 22);
            exitToolStripMenuItem.Text = "Define Parameters";
            exitToolStripMenuItem.Click += OpenParameters;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(170, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // ControlCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(531, 348);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "ControlCenter";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3D PET Filament Manufaturer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperatureTitle;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private Label lblTitle;
        private Label lblThermistor;
        private Label lblEngineRPM;
        private Label lblEngineRPMTitle;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpInfo;
        private Label lblSerialPortConnection;
        private Button btnEnableHotend;
        private Button btnDisableEngine;
        private Button btnEnableEngine;
        private Button btnDisableHotend;
        private GroupBox groupBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Button btnDisableAll;
        private Label lblHotendStatusTitle;
        private Label lblHotendStatus;
        private Label lblEngineStatusTitle;
        private Label lblEngineStatus;
    }
}