using UnityEngine;
using System.Collections;

public class RightCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Player myParent = transform.parent.GetComponent<Player>();
            myParent.speed = 0;
        }

        if (other.tag == "Arrow")
        {
            other.SendMessage("Break");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Player myParent = transform.parent.GetComponent<Player>();
            myParent.speed = 5;
            Debug.Log("Work");
        }
       
    }
}
