using UnityEngine;
using System.Collections;

public class wolf : MonoBehaviour {
    GameObject player;
    public bool stop;
    public float distance = 15;
    float speed = 5f;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    void FixedUpdate()
    {
        if (!stop)
        {
            if (transform.position.x - player.transform.position.x < distance)
            {
                transform.Translate( -speed * Time.deltaTime,0, 0);
            }
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
