#pragma once
#include "Resource.h"
#include "FTHelper.h"
#include <FaceTrackLib.h>


#ifdef KINECT_EXPORTS
#define KINECT_API __declspec(dllexport)
#else
#define KINECT_API __declspec(dllimport)
#endif



class SingleFaceNoWindow
{
public:
	SingleFaceNoWindow()
		: m_depthType(NUI_IMAGE_TYPE_DEPTH)
		, m_colorType(NUI_IMAGE_TYPE_COLOR)
		, m_depthRes(NUI_IMAGE_RESOLUTION_320x240)
		, m_colorRes(NUI_IMAGE_RESOLUTION_640x480)
		, m_bNearMode(FALSE)
		, m_bSeatedSkeletonMode(FALSE)
	{}

	BOOL Start(int port);
	void Stop();
	BOOL TiltCamera(int angleDelta);
	IFTImage* GetImage();

protected:
	static void                 FTHelperCallingBack(LPVOID lpParam);
	static int const            MaxLoadStringChars = 100;

	FTHelper                    m_FTHelper;

	NUI_IMAGE_TYPE              m_depthType;
	NUI_IMAGE_TYPE              m_colorType;
	NUI_IMAGE_RESOLUTION        m_depthRes;
	NUI_IMAGE_RESOLUTION        m_colorRes;
	BOOL                        m_bNearMode;
	BOOL                        m_bSeatedSkeletonMode;
};