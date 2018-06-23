using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinectHeadtracker
{
    public partial class MainForm : Form
    {
        private const int UDP_PORT = 5550;
        private KinectFaceTracker tracker;

        public MainForm()
        {
            InitializeComponent();
            tracker = new KinectFaceTracker();
            tracker.OnReceiveData += Tracker_OnReceiveData;
        }

        private void Tracker_OnReceiveData(double x, double y, double z, double yaw, double pitch, double roll)
        {
            if (IsDisposed || !Visible || WindowState == FormWindowState.Minimized)
                return;

            Invoke(new Action(() =>
            {
                cbxReceivingData.Checked = true;

                lblX.Text = x.ToString();
                lblY.Text = y.ToString();
                lblZ.Text = z.ToString();
                lblYaw.Text = yaw.ToString();
                lblPitch.Text = pitch.ToString();
                lblRoll.Text = roll.ToString();

                if (cbxLiveVideo.Checked)
                {
                    picLiveVideo.Image = tracker.GetImage();
                }
                else
                {
                    picLiveVideo.Image = null;
                }
            }));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tracker.StartWithCallback(UDP_PORT);
        }

        private void CbxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEnabled.Checked)
                tracker.StartWithCallback(UDP_PORT);
            else
                tracker.Stop();
        }

        private void BtnCameraUp_Click(object sender, EventArgs e)
        {
            tracker.TiltCamera(5);
        }

        private void BtnCameraDown_Click(object sender, EventArgs e)
        {
            tracker.TiltCamera(-5);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tracker.OnReceiveData -= Tracker_OnReceiveData;
            tracker.Stop();
        }
    }
}
