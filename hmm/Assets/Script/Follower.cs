using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    public int speed = 5;
    public bool stop = false;
    public bool perm_stop = false;
    public GameObject player;
    private float distance = 5.5f;
	// Use this for initialization
	void Start () {
        distance = 6f;
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(player.transform.position.x - distance, transform.position.y, transform.position.z);
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!perm_stop)
        {
            if (!stop)
                transform.Translate(speed * Time.deltaTime, 0, 0);
            else if (Mathf.Abs(transform.position.x - player.transform.position.x) > distance)
                transform.position = new Vector3(player.transform.position.x - distance, transform.position.y, transform.position.z);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.SendMessage("Death");
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

    void Perm_Stop()
    {
        Debug.Log("Received");
        perm_stop = true;
    }
}
