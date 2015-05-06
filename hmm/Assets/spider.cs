using UnityEngine;
using System.Collections;

public class spider : MonoBehaviour {
    GameObject player;
    public bool stop;
    public float distance = 15;
    float limit_up, limit_down;
    float y;
    // Use this for initialization
    void Start()
    {
        limit_up = transform.position.y + 2;
        limit_down = transform.position.y - 2;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        
        if (!stop)
        {
            if (transform.position.x - player.transform.position.x < distance)
            {
                y = player.transform.position.y;
                if(player.transform.position.y > limit_up)
                y = limit_up;
                if(player.transform.position.y < limit_down)
                y = limit_down;
                transform.position = new Vector3(transform.position.x,y, -1);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && stop == false)
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
