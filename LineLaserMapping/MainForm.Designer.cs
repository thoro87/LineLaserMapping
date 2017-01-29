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
			this.SuspendLayout();
			// 
			// cameraControl
			// 
			this.cameraControl.DirectShowLogFilepath = "";
			this.cameraControl.Location = new System.Drawing.Point(12, 12);
			this.cameraControl.Name = "cameraControl";
			this.cameraControl.Size = new System.Drawing.Size(297, 243);
			this.cameraControl.TabIndex = 0;
			// 
			// comboBoxCameraList
			// 
			this.comboBoxCameraList.FormattingEnabled = true;
			this.comboBoxCameraList.Location = new System.Drawing.Point(81, 338);
			this.comboBoxCameraList.Name = "comboBoxCameraList";
			this.comboBoxCameraList.Size = new System.Drawing.Size(268, 21);
			this.comboBoxCameraList.TabIndex = 1;
			this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
			// 
			// comboBoxResolutionList
			// 
			this.comboBoxResolutionList.FormattingEnabled = true;
			this.comboBoxResolutionList.Location = new System.Drawing.Point(355, 338);
			this.comboBoxResolutionList.Name = "comboBoxResolutionList";
			this.comboBoxResolutionList.Size = new System.Drawing.Size(125, 21);
			this.comboBoxResolutionList.TabIndex = 2;
			this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 493);
			this.Controls.Add(this.comboBoxResolutionList);
			this.Controls.Add(this.comboBoxCameraList);
			this.Controls.Add(this.cameraControl);
			this.Name = "MainForm";
			this.Text = "LineLaserMapping";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ResumeLayout(false);
		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Camera_NET.CameraControl cameraControl;
		private System.Windows.Forms.ComboBox comboBoxCameraList;
		private System.Windows.Forms.ComboBox comboBoxResolutionList;
	}
}

