using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera_NET;
using DirectShowLib;
using SerialCommunication;

namespace LineLaserMapping {
	public partial class MainForm : Form {

		private CameraChoice cameraChoice = new CameraChoice();
		private SerialCommunicator sCom = new SerialCommunicator();

		public MainForm() {
			InitializeComponent();
			FillCameraList();
			FillResolutionList();
			FillPortList();
			UpdateForm();
		}

		private void FillPortList() {
			SerialPortInfo[] portInfos = sCom.GetPortNames();
			comboBoxPort.Items.Clear();
			comboBoxPort.Items.AddRange(portInfos);
			SerialPortInfo arduinoPort = portInfos.FirstOrDefault(p => p.Name.Contains("Arduino"));
			if (arduinoPort != null) {
				comboBoxPort.SelectedItem = arduinoPort;
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			cameraControl.CloseCamera();
			sCom.Disconnect();
		}

		#region Camera_Internal
		private void comboBoxCameraList_SelectedIndexChanged(object sender, EventArgs e) {
			if (comboBoxCameraList.SelectedIndex < 0) {
				cameraControl.CloseCamera();
			} else {
				cameraControl.SetCamera(cameraChoice.Devices[comboBoxCameraList.SelectedIndex].Mon, null);
			}
			FillResolutionList();
		}

		private void comboBoxResolutionList_SelectedIndexChanged(object sender, EventArgs e) {
			if (!cameraControl.CameraCreated) {
				return;
			}

			int comboBoxResolutionIndex = comboBoxResolutionList.SelectedIndex;
			if (comboBoxResolutionIndex < 0) {
				return;
			}
			ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

			if (resolutions == null || comboBoxResolutionIndex >= resolutions.Count() || resolutions[comboBoxResolutionIndex].CompareTo(cameraControl.Resolution) == 0) {
				return;
			}
			cameraControl.SetCamera(cameraControl.Moniker, resolutions[comboBoxResolutionIndex]);
		}

		private void FillCameraList() {
			comboBoxCameraList.Items.Clear();
			cameraChoice.UpdateDeviceList();
			foreach (var camera_device in cameraChoice.Devices) {
				comboBoxCameraList.Items.Add(camera_device.Name);
			}
			if (comboBoxCameraList.Items.Count > 0) {
				comboBoxCameraList.SelectedIndex = 0;
			}
		}

		private void FillResolutionList() {
			comboBoxResolutionList.Items.Clear();

			if (!cameraControl.CameraCreated) {
				return;
			}

			ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

			if (resolutions == null) {
				return;
			}

			cameraControl.SetCamera(cameraControl.Moniker, resolutions[0]);
			int index_to_select = -1;

			for (int index = 0; index < resolutions.Count; index++) {
				comboBoxResolutionList.Items.Add(resolutions[index].ToString());

				if (resolutions[index].CompareTo(cameraControl.Resolution) == 0) {
					index_to_select = index;
				}
			}

			if (index_to_select >= 0) {
				comboBoxResolutionList.SelectedIndex = index_to_select;
			}
		}
		#endregion

		private Bitmap GetSnapshot() {
			Bitmap bitmap = null;
			try {
				bitmap = cameraControl.SnapshotSourceImage();
			} catch {
				Console.WriteLine("Error while catching next SourceImage");
			}
			return bitmap;
		}

		private void UpdateForm() {
			buttonConnect.Text = sCom.Connected ? "Disconnect" : "Connect";
		}

		private void ReceiveMessage(string str) {

		}

		private void buttonSnapshot_Click(object sender, EventArgs e) {
			pictureBox1.Image = GetSnapshot();
		}

		private void buttonConnect_Click(object sender, EventArgs e) {
			if (sCom.Connected) {
				sCom.Disconnect();
			} else {
				sCom.Connect(this, ReceiveMessage, ((SerialPortInfo)comboBoxPort.SelectedItem).DeviceID);
			}
			UpdateForm();
		}
	}
}
