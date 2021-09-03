using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBrowser : MonoBehaviour
{
	public string Url = "https://youtu.be/YnvU6REJ050";
    // Start is called before the first frame update
    void OnMouseDown() {
    	Application.OpenURL(Url);
    }
}
