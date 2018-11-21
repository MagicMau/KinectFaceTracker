namespace KinectHeadtracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCameraUp = new System.Windows.Forms.Button();
            this.btnCameraDown = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picLiveVideo = new System.Windows.Forms.PictureBox();
            this.cbxLiveVideo = new System.Windows.Forms.CheckBox();
            this.cbxEnabled = new System.Windows.Forms.CheckBox();
            this.cbxReceivingData = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCameraUp
            // 
            this.btnCameraUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCameraUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnCameraUp.Location = new System.Drawing.Point(12, 146);
            this.btnCameraUp.Name = "btnCameraUp";
            this.btnCameraUp.Size = new System.Drawing.Size(106, 23);
            this.btnCameraUp.TabIndex = 0;
            this.btnCameraUp.Text = "Camera UP";
            this.btnCameraUp.UseVisualStyleBackColor = false;
            this.btnCameraUp.Click += new System.EventHandler(this.BtnCameraUp_Click);
            // 
            // btnCameraDown
            // 
            this.btnCameraDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCameraDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnCameraDown.Location = new System.Drawing.Point(12, 175);
            this.btnCameraDown.Name = "btnCameraDown";
            this.btnCameraDown.Size = new System.Drawing.Size(106, 23);
            this.btnCameraDown.TabIndex = 0;
            this.btnCameraDown.Text = "Camera DOWN";
            this.btnCameraDown.UseVisualStyleBackColor = false;
            this.btnCameraDown.Click += new System.EventHandler(this.BtnCameraDown_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MagicMau\'s Kinect Headtracker";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::KinectHeadtracker.Properties.Resources.Kinect;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(64, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // picLiveVideo
            // 
            this.picLiveVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.picLiveVideo.Location = new System.Drawing.Point(248, 202);
            this.picLiveVideo.Name = "picLiveVideo";
            this.picLiveVideo.Size = new System.Drawing.Size(320, 240);
            this.picLiveVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLiveVideo.TabIndex = 3;
            this.picLiveVideo.TabStop = false;
            // 
            // cbxLiveVideo
            // 
            this.cbxLiveVideo.AutoSize = true;
            this.cbxLiveVideo.Location = new System.Drawing.Point(248, 179);
            this.cbxLiveVideo.Name = "cbxLiveVideo";
            this.cbxLiveVideo.Size = new System.Drawing.Size(106, 17);
            this.cbxLiveVideo.TabIndex = 4;
            this.cbxLiveVideo.Text = "Show Live Video";
            this.cbxLiveVideo.UseVisualStyleBackColor = true;
            this.cbxLiveVideo.CheckedChanged += new System.EventHandler(this.cbxLiveVideo_CheckedChanged);
            // 
            // cbxEnabled
            // 
            this.cbxEnabled.AutoSize = true;
            this.cbxEnabled.Checked = true;
            this.cbxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEnabled.Location = new System.Drawing.Point(12, 233);
            this.cbxEnabled.Name = "cbxEnabled";
            this.cbxEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbxEnabled.TabIndex = 5;
            this.cbxEnabled.Text = "Enabled";
            this.cbxEnabled.UseVisualStyleBackColor = true;
            this.cbxEnabled.CheckedChanged += new System.EventHandler(this.CbxEnabled_CheckedChanged);
            // 
            // cbxReceivingData
            // 
            this.cbxReceivingData.AutoCheck = false;
            this.cbxReceivingData.AutoSize = true;
            this.cbxReceivingData.Location = new System.Drawing.Point(248, 156);
            this.cbxReceivingData.Name = "cbxReceivingData";
            this.cbxReceivingData.Size = new System.Drawing.Size(98, 17);
            this.cbxReceivingData.TabIndex = 4;
            this.cbxReceivingData.Text = "Receiving data";
            this.cbxReceivingData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(59, 305);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(59, 329);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 13);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Z:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(59, 353);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(13, 13);
            this.lblZ.TabIndex = 6;
            this.lblZ.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yaw:";
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Location = new System.Drawing.Point(59, 377);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(13, 13);
            this.lblYaw.TabIndex = 6;
            this.lblYaw.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pitch:";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(59, 401);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(13, 13);
            this.lblPitch.TabIndex = 6;
            this.lblPitch.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Roll:";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(59, 425);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(13, 13);
            this.lblRoll.TabIndex = 6;
            this.lblRoll.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(580, 461);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblYaw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEnabled);
            this.Controls.Add(this.cbxReceivingData);
            this.Controls.Add(this.cbxLiveVideo);
            this.Controls.Add(this.picLiveVideo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCameraDown);
            this.Controls.Add(this.btnCameraUp);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(596, 500);
            this.MinimumSize = new System.Drawing.Size(596, 500);
            this.Name = "MainForm";
            this.Text = "MagicMau\'s Kinect Headtracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCameraUp;
        private System.Windows.Forms.Button btnCameraDown;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picLiveVideo;
        private System.Windows.Forms.CheckBox cbxLiveVideo;
        private System.Windows.Forms.CheckBox cbxEnabled;
        private System.Windows.Forms.CheckBox cbxReceivingData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}