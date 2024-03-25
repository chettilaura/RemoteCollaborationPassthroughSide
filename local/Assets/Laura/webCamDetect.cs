using UnityEngine;
using System.Collections;



public class webCamDetect : MonoBehaviour
{
	public Renderer sphereRenderer;

	string camName;
 
	public int webCamIndex = 0;
	public int micIndex = 0;
	// Audio
	//public const int THETA_V_AUDIO_NUMBER = 0;   
	AudioSource audioSource;

	void SetupCameraStream()
	{
        Application.targetFrameRate = 100;

        WebCamDevice[] devices = WebCamTexture.devices;
 
		// Print out all device names
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log(i + " " + devices[i].name);
        }


        camName = devices[webCamIndex].name;
		
		// Print out name of the one I'm using
        Debug.Log("I am using the webcam named " + camName);

		// Create the web cam texture
        WebCamTexture mycam = new WebCamTexture();
        mycam.deviceName = camName;

		// Stream web cam
        mycam.Play();

		// Put the texture onto the sphere
        sphereRenderer.material.SetTexture("_MainTex", mycam);


        // Audio 

        //audioSource = gameObject.AddComponent<AudioSource>();
        //string[] audioDevices = Microphone.devices;

        //for (int i = 0; i < audioDevices.Length; i++)
        //{
        //    Debug.Log(i + " " + audioDevices[i]);
        //}
        //audioSource.clip = Microphone.Start(audioDevices[micIndex], true, 10, 44100);
        //audioSource.loop = true;
        //while (!(Microphone.GetPosition(null) > 0)) { }
        //audioSource.Play();

    }
    void Start()
	{
		SetupCameraStream();
		//// audio
		//// this section working with HTC Vive, but have not 
		//// verified spatial audio. Maybe try STEAM AUDIO?
		//// https://valvesoftware.github.io/steam-audio/downloads.html
		//// It's good enough for telepresence demo right now, but
		//// I would like to tune the spatial audio
		////


	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
		{
			SetupCameraStream();	
		}
    }
}
