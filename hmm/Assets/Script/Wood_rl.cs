using UnityEngine;
using System.Collections;

public class Wood_rl : MonoBehaviour {
    bool stop = false;
    float fill = 0;
    public float speed = 20;
	// Use this for initialization
	void Start () {
        
	}
	
    void FixedUpdate()
    {
        if(!stop)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            fill = fill + speed;
        }
        if(fill == 0)
        {
            speed = -speed ;
        }
        if(fill == 100)
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
