using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    public int speed = 5;
    public bool stop = false;
    public Transform player;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(player.position.x - 5, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!stop)
            transform.Translate(speed * Time.deltaTime, 0, 0);
        else if (Mathf.Abs(transform.position.x - player.position.x) > 5) 
            transform.position = new Vector3(player.position.x - 5, transform.position.y, transform.position.z);
	}

    void Stop()
    {
        if (stop)
            stop = false;
        else
        {
            stop = true;
        }
    }
}
