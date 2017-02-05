namespace LineLaserMapping {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.cameraControl = new Camera_NET.CameraControl();
			this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
			this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
			this.buttonSnapshot = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBoxPort = new System.Windows.Forms.ComboBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelLeftPixel = new System.Windows.Forms.Label();
			this.labelLeftDist = new System.Windows.Forms.Label();
			this.labelCenterPixel = new System.Windows.Forms.Label();
			this.labelCenterDist = new System.Windows.Forms.Label();
			this.labelRightPixel = new System.Windows.Forms.Label();
			this.labelRightDist = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// cameraControl
			// 
			this.cameraControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cameraControl.DirectShowLogFilepath = "";
			this.cameraControl.Location = new System.Drawing.Point(12, 12);
			this.cameraControl.Name = "cameraControl";
			this.cameraControl.Size = new System.Drawing.Size(320, 180);
			this.cameraControl.TabIndex = 0;
			// 
			// comboBoxCameraList
			// 
			this.comboBoxCameraList.FormattingEnabled = true;
			this.comboBoxCameraList.Location = new System.Drawing.Point(6, 19);
			this.comboBoxCameraList.Name = "comboBoxCameraList";
			this.comboBoxCameraList.Size = new System.Drawing.Size(145, 21);
			this.comboBoxCameraList.TabIndex = 1;
			this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
			// 
			// comboBoxResolutionList
			// 
			this.comboBoxResolutionList.FormattingEnabled = true;
			this.comboBoxResolutionList.Location = new System.Drawing.Point(6, 49);
			this.comboBoxResolutionList.Name = "comboBoxResolutionList";
			this.comboBoxResolutionList.Size = new System.Drawing.Size(145, 21);
			this.comboBoxResolutionList.TabIndex = 2;
			this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
			// 
			// buttonSnapshot
			// 
			this.buttonSnapshot.Location = new System.Drawing.Point(157, 19);
			this.buttonSnapshot.Name = "buttonSnapshot";
			this.buttonSnapshot.Size = new System.Drawing.Size(92, 23);
			this.buttonSnapshot.TabIndex = 3;
			this.buttonSnapshot.Text = "Snapshot";
			this.buttonSnapshot.UseVisualStyleBackColor = true;
			this.buttonSnapshot.Click += new System.EventHandler(this.buttonSnapshot_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(338, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 88);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// comboBoxPort
			// 
			this.comboBoxPort.FormattingEnabled = true;
			this.comboBoxPort.Location = new System.Drawing.Point(6, 15);
			this.comboBoxPort.Name = "comboBoxPort";
			this.comboBoxPort.Size = new System.Drawing.Size(145, 21);
			this.comboBoxPort.TabIndex = 5;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(157, 15);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(92, 23);
			this.buttonConnect.TabIndex = 6;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(338, 104);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(159, 88);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(503, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(320, 180);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelLeftDist);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.labelLeftPixel);
			this.groupBox1.Location = new System.Drawing.Point(503, 198);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(103, 50);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Left";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelCenterDist);
			this.groupBox2.Controls.Add(this.labelCenterPixel);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(612, 196);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(100, 52);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Center";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelRightDist);
			this.groupBox3.Controls.Add(this.labelRightPixel);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(718, 196);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(105, 52);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Right";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Pixel:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Pixel:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Pixel:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Dist:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Dist:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Dist:";
			// 
			// labelLeftPixel
			// 
			this.labelLeftPixel.Location = new System.Drawing.Point(32, 14);
			this.labelLeftPixel.Name = "labelLeftPixel";
			this.labelLeftPixel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelLeftPixel.Size = new System.Drawing.Size(69, 13);
			this.labelLeftPixel.TabIndex = 14;
			this.labelLeftPixel.Text = "0 px";
			this.labelLeftPixel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelLeftDist
			// 
			this.labelLeftDist.Location = new System.Drawing.Point(36, 31);
			this.labelLeftDist.Name = "labelLeftDist";
			this.labelLeftDist.Size = new System.Drawing.Size(66, 13);
			this.labelLeftDist.TabIndex = 15;
			this.labelLeftDist.Text = "0,00 cm";
			this.labelLeftDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCenterPixel
			// 
			this.labelCenterPixel.Location = new System.Drawing.Point(28, 17);
			this.labelCenterPixel.Name = "labelCenterPixel";
			this.labelCenterPixel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelCenterPixel.Size = new System.Drawing.Size(69, 13);
			this.labelCenterPixel.TabIndex = 16;
			this.labelCenterPixel.Text = "0 px";
			this.labelCenterPixel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCenterDist
			// 
			this.labelCenterDist.Location = new System.Drawing.Point(33, 32);
			this.labelCenterDist.Name = "labelCenterDist";
			this.labelCenterDist.Size = new System.Drawing.Size(66, 13);
			this.labelCenterDist.TabIndex = 16;
			this.labelCenterDist.Text = "0,00 cm";
			this.labelCenterDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelRightPixel
			// 
			this.labelRightPixel.Location = new System.Drawing.Point(33, 16);
			this.labelRightPixel.Name = "labelRightPixel";
			this.labelRightPixel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelRightPixel.Size = new System.Drawing.Size(69, 13);
			this.labelRightPixel.TabIndex = 17;
			this.labelRightPixel.Text = "0 px";
			this.labelRightPixel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelRightDist
			// 
			this.labelRightDist.Location = new System.Drawing.Point(38, 32);
			this.labelRightDist.Name = "labelRightDist";
			this.labelRightDist.Size = new System.Drawing.Size(66, 13);
			this.labelRightDist.TabIndex = 17;
			this.labelRightDist.Text = "0,00 cm";
			this.labelRightDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboBoxPort);
			this.groupBox4.Controls.Add(this.buttonConnect);
			this.groupBox4.Location = new System.Drawing.Point(12, 198);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(258, 50);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Serial";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.comboBoxCameraList);
			this.groupBox5.Controls.Add(this.comboBoxResolutionList);
			this.groupBox5.Controls.Add(this.buttonSnapshot);
			this.groupBox5.Location = new System.Drawing.Point(12, 254);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(258, 82);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Camera";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 493);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cameraControl);
			this.Name = "MainForm";
			this.Text = "LineLaserMapping";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Camera_NET.CameraControl cameraControl;
		private System.Windows.Forms.ComboBox comboBoxCameraList;
		private System.Windows.Forms.ComboBox comboBoxResolutionList;
		private System.Windows.Forms.Button buttonSnapshot;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboBoxPort;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelLeftDist;
		private System.Windows.Forms.Label labelLeftPixel;
		private System.Windows.Forms.Label labelCenterDist;
		private System.Windows.Forms.Label labelCenterPixel;
		private System.Windows.Forms.Label labelRightDist;
		private System.Windows.Forms.Label labelRightPixel;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
	}
}

