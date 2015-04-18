using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x+5, transform.position.y,-10) ;
	}
}
