using UnityEngine;
using System.Collections;

public class Arrow_right : MonoBehaviour {
    bool stop = false;
    int speed = 10;
    // Use this for initialization
    void Start()
    {
        transform.tag = "Arrow";
        stop = false;
        speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!stop)
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

    void Break()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           other.SendMessage("Death");
        }
    }
}
