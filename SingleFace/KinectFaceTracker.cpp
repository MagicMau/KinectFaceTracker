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
			int len = img->GetBufferSize();
			array<Byte>^ buf = gcnew array<Byte>(len);
			Marshal::Copy(IntPtr((void*)img->GetBuffer()), buf, 0, len);
			
			MemoryStream^ stream = gcnew MemoryStream(buf);
			try {
				return Image::FromStream(stream);
			}
			finally {
				stream->Close();
			}
		}
		return nullptr;
	}

	bool TiltCamera(int angleDelta) {
		return app->TiltCamera(angleDelta) != 0;
	}

private:
	SingleFaceNoWindow* app;
};

