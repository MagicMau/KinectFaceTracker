# KinectFaceTracker
C++ solution to have a DLL that provides head tracking info from an Xbox360 Kinect to OpenTrack

This is a simple implementation, based on a Kinect SDK sample, but it does the job. 
There is still some leftover code from the example, pardon the mess :)

KinectFaceTracker.dll exposes a couple methods:

* `Start(int port)` - this starts the tracker and sends output on the specified UDP port. This allows OpenTrack to receive the data with the "UDP sender" input.
* `Stop()` - stops the tracker
* `TiltCamera(int angleDelta)` - allows you to tilt the camera up or down to give it a proper view of your head
* `IsReceivingData()` - tells you if the tracker is tracking a head (returns a bool)

I have tried to tweak the app to use as minimum resources as possible while still providing a smooth head tracking experience.
My C++ skills are limited though, so if you can improve, I'm all for it.

In order to run the app you will also need the FaceTrack dlls that are in the dependencies folder. 
Those DLLs come from the Kinect 1.8 SDK Developer Toolkit and perform the actual magic of head tracking. 
