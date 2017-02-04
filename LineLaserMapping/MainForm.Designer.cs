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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
			this.comboBoxCameraList.Location = new System.Drawing.Point(12, 212);
			this.comboBoxCameraList.Name = "comboBoxCameraList";
			this.comboBoxCameraList.Size = new System.Drawing.Size(268, 21);
			this.comboBoxCameraList.TabIndex = 1;
			this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
			// 
			// comboBoxResolutionList
			// 
			this.comboBoxResolutionList.FormattingEnabled = true;
			this.comboBoxResolutionList.Location = new System.Drawing.Point(286, 212);
			this.comboBoxResolutionList.Name = "comboBoxResolutionList";
			this.comboBoxResolutionList.Size = new System.Drawing.Size(125, 21);
			this.comboBoxResolutionList.TabIndex = 2;
			this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
			// 
			// buttonSnapshot
			// 
			this.buttonSnapshot.Location = new System.Drawing.Point(417, 212);
			this.buttonSnapshot.Name = "buttonSnapshot";
			this.buttonSnapshot.Size = new System.Drawing.Size(75, 23);
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
			this.pictureBox1.Size = new System.Drawing.Size(320, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// comboBoxPort
			// 
			this.comboBoxPort.FormattingEnabled = true;
			this.comboBoxPort.Location = new System.Drawing.Point(266, 248);
			this.comboBoxPort.Name = "comboBoxPort";
			this.comboBoxPort.Size = new System.Drawing.Size(145, 21);
			this.comboBoxPort.TabIndex = 5;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(417, 248);
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
			this.pictureBox2.Location = new System.Drawing.Point(664, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(320, 180);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(664, 198);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(320, 180);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 493);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.comboBoxPort);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonSnapshot);
			this.Controls.Add(this.comboBoxResolutionList);
			this.Controls.Add(this.comboBoxCameraList);
			this.Controls.Add(this.cameraControl);
			this.Name = "MainForm";
			this.Text = "LineLaserMapping";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
	}
}

