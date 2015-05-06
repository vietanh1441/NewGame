using UnityEngine;
using System.Collections;

public class Loose : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.transform.name);
        if (other.transform.tag == "Enemy")
        {
            Debug.Log("ok");
            other.SendMessage("Perm_Stop");
        }

       
    }
}
