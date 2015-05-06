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
        if(other.transform.tag == "StopTile")
        {
            gameObject.transform.parent.SendMessage("Stop");
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Move")
        {
            gameObject.transform.parent.parent = null;
        }
        if (other.transform.tag == "StopTile")
        {
            gameObject.transform.parent.SendMessage("Go");
        }

    }
}
