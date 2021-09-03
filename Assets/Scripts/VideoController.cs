using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoController : MonoBehaviour
{
	public GameObject planeVideo;
	public GameObject noSound;

	void Start() {
		var videoPlayer = planeVideo.GetComponent<UnityEngine.Video.VideoPlayer>();
		videoPlayer.SetDirectAudioMute(0, true);
		noSound.SetActive(true);
	}

    void OnMouseUp(){
        var videoPlayer = planeVideo.GetComponent<UnityEngine.Video.VideoPlayer>();
     	
     	videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0));
     	if (videoPlayer.GetDirectAudioMute(0)) {
     		noSound.SetActive(true);
     	}
     	else {
     		noSound.SetActive(false);
     	}
  	}
}
