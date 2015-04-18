using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
}
