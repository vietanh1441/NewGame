using UnityEngine;
using System.Collections;

public class Downdoor : MonoBehaviour {
    GameObject player;
    public bool stop;
    private int counter = 0;
    public float distance = 15;
    float speed = 1.5f;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	void Update()
    {
        if(counter > 100)
        {
            stop = true;
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
        if (!stop)
        {
            if (transform.position.x - player.transform.position.x < distance)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
                counter++;
            }
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
