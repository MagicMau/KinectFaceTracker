using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreePIE.Core.Contracts;

namespace Kinect.FreePIE
{
    [GlobalType(Type = typeof(KinectPluginGlobal))]
    public class KinectPlugin : IPlugin
    {
        private KinectFaceTracker tracker;
        internal double x;
        internal double y;
        internal double z;
        internal double yaw;
        internal double pitch;
        internal double roll;

        public string FriendlyName
        {
            get { return "Kinect Xbox 360"; }
        }

        public event EventHandler Started;

        public object CreateGlobal()
        {
            return new KinectPluginGlobal(this);
        }

        public bool GetProperty(int index, IPluginProperty property)
        {
            return false;
        }

        public bool SetProperties(Dictionary<string, object> properties)
        {
            return true;
        }

        public Action Start()
        {
            tracker = new KinectFaceTracker();
            tracker.OnReceiveData += Tracker_OnReceiveData;
            tracker.StartWithCallback(5550);
            return null;
        }

        private void Tracker_OnReceiveData(double x, double y, double z, double yaw, double pitch, double roll)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.yaw = yaw;
            this.pitch = pitch;
            this.roll = roll;
        }

        public void DoBeforeNextExecute()
        {
            
        }

        public void Stop()
        {
            tracker.Stop();
        }
    }

    [Global(Name = "Kinect")]
    public class KinectPluginGlobal
    {
        private readonly KinectPlugin plugin;

        public KinectPluginGlobal(KinectPlugin plugin)
        {
            this.plugin = plugin;
        }

        public double x {  get { return this.plugin.x; } }
        public double y { get { return this.plugin.y; } }
        public double z { get { return this.plugin.z; } }
        public double yaw { get { return this.plugin.yaw; } }
        public double roll { get { return this.plugin.roll; } }
        public double pitch { get { return this.plugin.pitch; } }
    }
}
