using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroControl : MonoBehaviour
{	
	void Start() {
		var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
		vp.loopPointReached += EndReached;
	}

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
