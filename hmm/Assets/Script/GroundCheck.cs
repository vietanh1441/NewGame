using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Move")
        {
            gameObject.transform.parent.parent = other.transform;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Move")
        {
            gameObject.transform.parent.parent = null;
        }

    }
}
