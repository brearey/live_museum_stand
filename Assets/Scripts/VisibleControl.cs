using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleControl : MonoBehaviour
{
	public GameObject[] allImgs;
	private bool isVisible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ChangeVisible() {
    	isVisible = !isVisible;
    }
}
