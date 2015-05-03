using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
    public GameObject central;
    public GameObject player;
    
    void Start()
    {
        central = GameObject.FindGameObjectWithTag("Central");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(player.transform.position.x- transform.position.x > 50)
        {
            Destroy(transform.parent.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        central.SendMessage("NewScene");
    }
}
