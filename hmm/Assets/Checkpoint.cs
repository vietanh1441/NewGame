using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        
        text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0)
        {
            text.text = "Restart From CheckPoint";
        }
        else
            text.text = "";
	}

   
}
