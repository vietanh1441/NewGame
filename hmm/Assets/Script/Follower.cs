using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    public int speed = 5;
    public bool stop = false;
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(player.transform.position.x - 5, transform.position.y, transform.position.z);
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!stop)
            transform.Translate(speed * Time.deltaTime, 0, 0);
        else if (Mathf.Abs(transform.position.x - player.transform.position.x) > 5) 
            transform.position = new Vector3(player.transform.position.x - 5, transform.position.y, transform.position.z);
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
}
