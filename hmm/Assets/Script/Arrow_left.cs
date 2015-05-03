using UnityEngine;
using System.Collections;

public class Arrow_left : MonoBehaviour {
    bool stop = false;
    int speed = -7;
	// Use this for initialization
	void Start () {
        transform.tag = "Enemy";
        stop = false;
        speed = -7;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(!stop)
        transform.Translate(speed * Time.deltaTime, 0, 0);
	}

    void Stop()
    {
        stop = true;
    }

    void Go()
    {
        stop = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage("Death");
        }
    }
}
