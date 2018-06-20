#include "stdafx.h"
#include "SingleFaceNoWindow.h"


static char* SERVER = "127.0.0.1";
static int	 PORT = 5550;

struct sockaddr_in si_other;
int si_other_len = sizeof(si_other);
WSADATA wsa;
int udp_socket;
double FTData[6];
int FTData_len = sizeof(FTData);

// Run the SingleFace application.
int SingleFaceNoWindow::Start(int port)
{
	////Get Server Settings from INI file
	//char myServer[20];
	//GetPrivateProfileStringA("ServerSettings", "SERVER", "127.0.0.1", myServer, 20, "./SingleFace.ini");
	//SERVER = myServer;
	//char myPort[10];
	//GetPrivateProfileStringA("ServerSettings", "PORT", "5550", myPort, 10, "./SingleFace.ini");
	//PORT = atoi(myPort);

	PORT = port;

	// SEND UDP Data thru Socket to  FaceTrackNOIR
	WCHAR szDebugText[1024];

	//Initialise winsock
	swprintf_s(szDebugText, L"\nInitialising UDP socket for %s:%d...\n", L"127.0.0.1", PORT);
	OutputDebugString(szDebugText);

	if (WSAStartup(MAKEWORD(2, 2), &wsa) != 0)
	{
		swprintf_s(szDebugText, L"Failed. Error Code : %d\n", WSAGetLastError());
		OutputDebugString(szDebugText);
		return false;
	}

	//create socket
	if ((udp_socket = socket(AF_INET, SOCK_DGRAM, IPPROTO_UDP)) == SOCKET_ERROR)
	{
		swprintf_s(szDebugText, L"socket() failed with error code : %d\n", WSAGetLastError());
		OutputDebugString(szDebugText);
		return false;
	}

	//setup address structure
	memset((char *)&si_other, 0, si_other_len);
	si_other.sin_family = AF_INET;
	si_other.sin_port = htons(PORT);
	//si_other.sin_port = htons(5550);
	si_other.sin_addr.S_un.S_addr = inet_addr(SERVER);
	//si_other.sin_addr.S_un.S_addr = inet_addr("127.0.0.1");

	// send test message
	int err_send = sendto(udp_socket, (const char *)FTData, FTData_len, 0, (struct sockaddr *) &si_other, si_other_len);
	if (err_send == SOCKET_ERROR)
	{
		swprintf_s(szDebugText, L"sendto() failed with error code : %d\n", WSAGetLastError());
		OutputDebugString(szDebugText);
		return false;
	}

	swprintf_s(szDebugText, L"Initialised.\n");
	OutputDebugString(szDebugText);

	return SUCCEEDED(m_FTHelper.Init(NULL,
		FTHelperCallingBack,
		this,
		m_depthType,
		m_depthRes,
		m_bNearMode,
		TRUE, // if near mode doesn't work, fall back to default mode
		m_colorType,
		m_colorRes,
		m_bSeatedSkeletonMode));
}

int SingleFaceNoWindow::Stop()
{
	// Clean up the memory allocated for Face Tracking and rendering.
	m_FTHelper.Stop();

	//// zero out the final location and send it 5 times
	//FTData[0] = FTData[1] = FTData[2] = FTData[3] = FTData[4] = FTData[5] = 0;

	//int i;
	//for (i = 0; i < 5; i++)
	//{
	//	int err_send;
	//	//send the message
	//	err_send = sendto(udp_socket, (const char *)FTData, FTData_len, 0, (struct sockaddr *) &si_other, si_other_len);
	//	if (err_send == SOCKET_ERROR)
	//	{
	//		printf("sendto() failed with error code : %d", WSAGetLastError());
	//		return false;
	//	}
	//}

	// close UDP
	closesocket(udp_socket);
	WSACleanup();

	return true;
}

BOOL SingleFaceNoWindow::IsReceivingData()
{
	return m_FTHelper.IsReceivingData();
}


BOOL SingleFaceNoWindow::TiltCamera(int angleDelta)
{
	BOOL ret = TRUE;
	LONG angle;
	NuiCameraElevationGetAngle(&angle);

	angle += angleDelta;
	if (angle > NUI_CAMERA_ELEVATION_MINIMUM & angle < NUI_CAMERA_ELEVATION_MAXIMUM)
		NuiCameraElevationSetAngle(angle);

	return ret;
}

IFTImage* SingleFaceNoWindow::GetImage()
{
	IFTImage* img = m_FTHelper.GetColorImage();
	return img;
}

/*
* The "Face Tracker" helper class is generic. It will call back this function
* after a face has been successfully tracked. The code in the call back passes the parameters
* to the Egg Avatar, so it can be animated.
*/
void SingleFaceNoWindow::FTHelperCallingBack(PVOID pVoid)
{
	SingleFaceNoWindow* pApp = reinterpret_cast<SingleFaceNoWindow*>(pVoid);
	if (pApp)
	{
		IFTResult* pResult = pApp->m_FTHelper.GetResult();
		if (pResult && SUCCEEDED(pResult->GetStatus()))
		{
			//FLOAT* pAU = NULL;
			//UINT numAU;
			//pResult->GetAUCoefficients(&pAU, &numAU);
			FLOAT scale;
			FLOAT rotationXYZ[6];
			FLOAT translationXYZ[3];
			pResult->Get3DPose(&scale, rotationXYZ, translationXYZ);

			// Send across UDP channel for OpenTrack

			//Translation XYZ
			FTData[0] = (double)(translationXYZ[0] * 100.0f);	// X (in cm)
			FTData[1] = (double)(translationXYZ[1] * 100.0f);	// Y (in cm)
			FTData[2] = (double)(translationXYZ[2] * 100.0f);	// Z (in cm)

													//Rotation
			FTData[3] = (double)rotationXYZ[1];	// Yaw
			FTData[4] = (double)rotationXYZ[0];	// Pitch
			FTData[5] = (double)rotationXYZ[2];	// Roll

			int err_send;
			//send the message
			err_send = sendto(udp_socket, (const char *)FTData, FTData_len, 0, (struct sockaddr *) &si_other, si_other_len);
			if (err_send == SOCKET_ERROR)
			{
				printf("sendto() failed with error code : %d", WSAGetLastError());
				exit(EXIT_FAILURE);
			}
		}
	}
}
