﻿using UnityEngine;
using System.Collections;

public class Wood_rl : MonoBehaviour {
    bool stop = false;
    public float max = 200;
    float fill = 0;
    public float speed = 10;
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
        if(fill == max)
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
