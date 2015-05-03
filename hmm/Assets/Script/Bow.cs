using UnityEngine;
using System.Collections;

public class Bow : MonoBehaviour {
    public Transform arrow_right, arrow_left;
    GameObject player;
    private int counter;
    public int shoot = 10;
    public bool stop;
    public bool left;
    public float distance = 15;
    float speed = 1;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        counter = 0;
        if (!left)
            shoot = 200;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!stop)
        {
            if (transform.position.x - player.transform.position.x < distance)
            {
                counter++;
            }
        }
        if(counter == shoot )
        {
            Shoot_arrow();
        }
	}

    void Shoot_arrow()
    {
        if(left)
        {
            Transform clone;
            clone = Instantiate(arrow_left, transform.position, Quaternion.identity) as Transform;
        }
        else
        {
            Transform clone;
            clone = Instantiate(arrow_right, transform.position, Quaternion.identity) as Transform;
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
