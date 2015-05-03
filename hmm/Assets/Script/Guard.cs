using UnityEngine;
using System.Collections;

public class Guard : MonoBehaviour {
    private bool stop = false;
	// Use this for initialization
	void Start () {
        stop = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && stop == false)
        {
            other.SendMessage("Death");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" && stop == false)
        {
            other.SendMessage("Death");
        }
    }

    void Stop()
    {
        stop = true;
    }

    void Go()
    {
        stop = false;
    }
}
