using UnityEngine;
using System.Collections;

public class nextScene : MonoBehaviour {
    public int num;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            other.SendMessage("NextScene",num);
    }
}
