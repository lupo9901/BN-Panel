namespace BoxComm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refDriveButton = new System.Windows.Forms.Button();
            this.sollWinkel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driveStartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.winkelSlider = new System.Windows.Forms.TrackBar();
            this.sollSliderVal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.offsetButton = new System.Windows.Forms.Button();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.receivedTextBox = new System.Windows.Forms.RichTextBox();
            this.currentAngle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.onlineStatus = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.systemInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winkelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(19, 59);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(106, 40);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(19, 105);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(106, 24);
            this.portComboBox.TabIndex = 3;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(215, 89);
            this.sendText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(533, 23);
            this.sendText.TabIndex = 4;
            this.sendText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendText_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(753, 89);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(64, 30);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(311, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Boxenneiger Control Panel";
            // 
            // refDriveButton
            // 
            this.refDriveButton.Location = new System.Drawing.Point(19, 244);
            this.refDriveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refDriveButton.Name = "refDriveButton";
            this.refDriveButton.Size = new System.Drawing.Size(131, 58);
            this.refDriveButton.TabIndex = 7;
            this.refDriveButton.Text = "Referenz";
            this.refDriveButton.UseVisualStyleBackColor = true;
            this.refDriveButton.Click += new System.EventHandler(this.refDriveButton_Click);
            // 
            // sollWinkel
            // 
            this.sollWinkel.Location = new System.Drawing.Point(215, 219);
            this.sollWinkel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sollWinkel.Name = "sollWinkel";
            this.sollWinkel.Size = new System.Drawing.Size(123, 23);
            this.sollWinkel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sollwinkel:";
            // 
            // driveStartButton
            // 
            this.driveStartButton.Location = new System.Drawing.Point(215, 247);
            this.driveStartButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.driveStartButton.Name = "driveStartButton";
            this.driveStartButton.Size = new System.Drawing.Size(123, 55);
            this.driveStartButton.TabIndex = 10;
            this.driveStartButton.Text = "Start!";
            this.driveStartButton.UseVisualStyleBackColor = true;
            this.driveStartButton.Click += new System.EventHandler(this.driveStartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Grad";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(19, 135);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 29);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // winkelSlider
            // 
            this.winkelSlider.Location = new System.Drawing.Point(19, 308);
            this.winkelSlider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.winkelSlider.Maximum = 50;
            this.winkelSlider.Name = "winkelSlider";
            this.winkelSlider.Size = new System.Drawing.Size(910, 56);
            this.winkelSlider.TabIndex = 13;
            this.winkelSlider.TickFrequency = 2;
            this.winkelSlider.ValueChanged += new System.EventHandler(this.winkelSlider_ValueChanged);
            // 
            // sollSliderVal
            // 
            this.sollSliderVal.AutoSize = true;
            this.sollSliderVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sollSliderVal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sollSliderVal.Location = new System.Drawing.Point(126, 3);
            this.sollSliderVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sollSliderVal.Name = "sollSliderVal";
            this.sollSliderVal.Size = new System.Drawing.Size(36, 39);
            this.sollSliderVal.TabIndex = 14;
            this.sollSliderVal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soll:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(218, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grad";
            // 
            // offsetButton
            // 
            this.offsetButton.Location = new System.Drawing.Point(420, 247);
            this.offsetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.offsetButton.Name = "offsetButton";
            this.offsetButton.Size = new System.Drawing.Size(123, 55);
            this.offsetButton.TabIndex = 19;
            this.offsetButton.Text = "Set";
            this.offsetButton.UseVisualStyleBackColor = true;
            this.offsetButton.Click += new System.EventHandler(this.offsetButton_Click);
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(420, 219);
            this.offsetTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(123, 23);
            this.offsetTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Offset:";
            // 
            // receivedTextBox
            // 
            this.receivedTextBox.Location = new System.Drawing.Point(215, 117);
            this.receivedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.receivedTextBox.Name = "receivedTextBox";
            this.receivedTextBox.Size = new System.Drawing.Size(533, 70);
            this.receivedTextBox.TabIndex = 23;
            this.receivedTextBox.Text = "";
            this.receivedTextBox.TextChanged += new System.EventHandler(this.receivedTextBox_TextChanged);
            // 
            // currentAngle
            // 
            this.currentAngle.AutoSize = true;
            this.currentAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currentAngle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.currentAngle.Location = new System.Drawing.Point(126, 47);
            this.currentAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAngle.Name = "currentAngle";
            this.currentAngle.Size = new System.Drawing.Size(36, 39);
            this.currentAngle.TabIndex = 24;
            this.currentAngle.Text = "0";
            this.currentAngle.TextChanged += new System.EventHandler(this.currentAngle_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(218, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 39);
            this.label8.TabIndex = 25;
            this.label8.Text = "Grad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(24, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ist:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // onlineStatus
            // 
            this.onlineStatus.BackColor = System.Drawing.Color.Red;
            this.onlineStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onlineStatus.Location = new System.Drawing.Point(19, 18);
            this.onlineStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onlineStatus.Name = "onlineStatus";
            this.onlineStatus.Size = new System.Drawing.Size(106, 29);
            this.onlineStatus.TabIndex = 0;
            this.onlineStatus.Text = "OFFLINE";
            this.onlineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(16, 367);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(32, 17);
            this.aboutLabel.TabIndex = 27;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "Info";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoxComm.Properties.Resources.imageonline_co_whitebackgroundremoved;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Grad";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sollSliderVal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.currentAngle);
            this.panel1.Location = new System.Drawing.Point(600, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 102);
            this.panel1.TabIndex = 30;
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(753, 164);
            this.progressBar1.Maximum = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 31;
            // 
            // systemInfo
            // 
            this.systemInfo.AutoSize = true;
            this.systemInfo.Location = new System.Drawing.Point(81, 367);
            this.systemInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemInfo.Name = "systemInfo";
            this.systemInfo.Size = new System.Drawing.Size(69, 17);
            this.systemInfo.TabIndex = 32;
            this.systemInfo.Text = "Sollwinkel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(964, 402);
            this.Controls.Add(this.systemInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.onlineStatus);
            this.Controls.Add(this.receivedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.offsetButton);
            this.Controls.Add(this.winkelSlider);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.driveStartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sollWinkel);
            this.Controls.Add(this.refDriveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.winkelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refDriveButton;
        private System.Windows.Forms.TextBox sollWinkel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button driveStartButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TrackBar winkelSlider;
        private System.Windows.Forms.Label sollSliderVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button offsetButton;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox receivedTextBox;
        private System.Windows.Forms.Label currentAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label onlineStatus;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label systemInfo;
    }
}

