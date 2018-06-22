#include "stdafx.h"
#include "KinectFaceTracker.h"
#include "SingleFaceNoWindow.h"

#include <Windows.h>
#include <vcclr.h>
#using <System.dll>

using namespace System;
using namespace System::Drawing;
using namespace System::IO;
using namespace System::Runtime::InteropServices;

#pragma unmanaged
#pragma managed

public delegate void ReceiveKinectData(double x, double y, double z, double yaw, double pitch, double roll);

public ref class KinectFaceTracker
{
public:
	KinectFaceTracker() : app(new SingleFaceNoWindow()) {}

	~KinectFaceTracker() {
		delete app;
	}

protected:
	!KinectFaceTracker() {
		delete app;
	}

public:
	event ReceiveKinectData^ OnReceiveData;

	// wrapper functions go here
	bool Start(int port) {
		return app->Start(port) != 0;
	}

	bool StartWithCallback(int port) {
		receiveKinectDataCallback = gcnew ReceiveKinectData(this, &KinectFaceTracker::ReceiveData);
		IntPtr ptr = Marshal::GetFunctionPointerForDelegate(receiveKinectDataCallback);
		KINECTFACETRACKERCB cb = static_cast<KINECTFACETRACKERCB>(ptr.ToPointer());

		return app->StartWithCallback(port, cb);
	}

	void Stop() {
		app->Stop();
		if (receiveKinectDataCallback)
			delete receiveKinectDataCallback;
	}

	Image^ GetImage() {
		IFTImage* img = app->GetImage();
		if (img) {
			Bitmap^ bmp = gcnew Bitmap((int)img->GetWidth(), (int)img->GetHeight(), (int)img->GetStride(), System::Drawing::Imaging::PixelFormat::Format32bppRgb, IntPtr(img->GetBuffer()));

			return bmp;
		}
		return nullptr;
	}

	bool TiltCamera(int angleDelta) {
		return app->TiltCamera(angleDelta) != 0;
	}

	bool IsReceivingData() {
		return app->IsReceivingData() != 0;
	}

private:
	SingleFaceNoWindow* app;
	ReceiveKinectData^ receiveKinectDataCallback;

	void ReceiveData(double x, double y, double z, double yaw, double pitch, double roll)
	{
		OnReceiveData(x, y, z, yaw, pitch, roll);
	}
};

