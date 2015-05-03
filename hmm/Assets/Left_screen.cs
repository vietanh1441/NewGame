using UnityEngine;
using System.Collections;

public class Left_screen : MonoBehaviour {
    GameObject screen;
	// Use this for initialization
	void Start () {
        screen = GameObject.FindGameObjectWithTag("Screen");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("WTF");
        screen.SendMessage("Start_Fade");
    }
}
