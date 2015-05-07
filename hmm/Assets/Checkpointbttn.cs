using UnityEngine;
using System.Collections;

public class Checkpointbttn : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
    void OnMouseDown()
    {
        if(Time.timeScale == 0)
        { 
            player.SendMessage("Restart_from_checkpoint");
        }

    }
}
