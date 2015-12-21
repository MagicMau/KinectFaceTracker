#include "stdafx.h"
#include "KinectFaceTracker.h"
#include "SingleFaceNoWindow.h"

#include <Windows.h>
#include <vcclr.h>
#using <System.dll>

using namespace System;
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

	bool TiltCamera(int angleDelta) {
		return app->TiltCamera(angleDelta) != 0;
	}

private:
	SingleFaceNoWindow* app;
};

