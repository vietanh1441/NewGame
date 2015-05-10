using UnityEngine;
using System.Collections;

public class game_trig : MonoBehaviour {
    public Transform scene;
    Transform player;
	// Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Transform clone;
            clone = Instantiate(scene, new Vector3(player.transform.position.x + 20, 1.5f, 0), Quaternion.identity) as Transform;
        }
    }

    void Update()
    {
        if(player.transform.position.x - transform.position.x > 30)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
