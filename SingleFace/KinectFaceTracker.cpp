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
	// wrapper functions go here
	bool Start(int port) {
		return app->Start(port) != 0;
	}

	void Stop() {
		app->Stop();
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
};

