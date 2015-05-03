using UnityEngine;
using System.Collections;

public class NextSong : MonoBehaviour {
    GameObject music;
	// Use this for initialization
	void Start () {
        music = GameObject.FindGameObjectWithTag("Music");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            music.SendMessage("Lower");
    }
}
