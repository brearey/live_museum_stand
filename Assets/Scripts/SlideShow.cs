//Attach this script to your GameObject (make sure it has a Renderer component)
//Click on the GameObject. Attach your own Textures in the GameObject’s Inspector.

//This script takes your GameObject’s material and changes its Normal Map, Albedo, and Metallic properties to the Textures you attach in the GameObject’s Inspector. This happens when you enter Play Mode

using UnityEngine;

public class SlideShow : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    AudioSource mAudio;
    public GameObject noSound;
    public int indexMaterial = 0;

    void Start() {
    	rend = GetComponent<Renderer>();
    	mAudio = GetComponent<AudioSource>();
    	mAudio.Pause();
    	InvokeRepeating("Slide", 0f, 3f);  //1s delay, repeat every 1s

    	noSound.SetActive(true);
    }

    void OnMouseDown() {
    	if (mAudio.isPlaying){
    		mAudio.Pause();
    		noSound.SetActive(true);
    	}
    	else {
    		mAudio.Play();
    		noSound.SetActive(false);
    	}
    }

    void Slide() {
    	indexMaterial++;
    	if (indexMaterial > 5) indexMaterial = 0;
    	rend.sharedMaterial = material[indexMaterial];
    }
}