using UnityEngine;
using System.Collections;

public class Wood_ud : MonoBehaviour {
    bool stop = false;
    float fill = 0;
    public float max = 200;
    public float speed = 10;
    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (!stop)
        {
            transform.Translate(0,speed * Time.deltaTime, 0);
            fill = fill + speed;
        }
        if (fill == 0)
        {
            speed = -speed;
        }
        if (fill == max)
        {
            speed = -speed;
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
