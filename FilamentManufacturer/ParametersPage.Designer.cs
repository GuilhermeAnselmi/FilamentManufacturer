namespace FilamentManufacturer
{
    partial class ParametersPage
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
            panel1 = new Panel();
            btnDone = new Button();
            btnSave = new Button();
            txtEngineRPM = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTemperature = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnDone);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtEngineRPM);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTemperature);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 153);
            panel1.TabIndex = 0;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDone.ForeColor = Color.Black;
            btnDone.Location = new Point(3, 116);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(104, 34);
            btnDone.TabIndex = 6;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += Done;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(199, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save;
            // 
            // txtEngineRPM
            // 
            txtEngineRPM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEngineRPM.Location = new Point(164, 65);
            txtEngineRPM.Name = "txtEngineRPM";
            txtEngineRPM.Size = new Size(139, 23);
            txtEngineRPM.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(164, 41);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 3;
            label3.Text = "Engine RPM";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(104, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 2;
            label2.Text = "Parameters";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(3, 65);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(139, 23);
            txtTemperature.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Temperature";
            // 
            // ParametersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(330, 177);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametersPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Define Parameters";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtTemperature;
        private Label label2;
        private TextBox txtEngineRPM;
        private Label label3;
        private Button btnDone;
        private Button btnSave;
    }
}