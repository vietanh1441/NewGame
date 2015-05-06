using UnityEngine;
using System.Collections;

public class ghost : MonoBehaviour {
    public GameObject prefab;
    bool stop = true;
    bool done = false;
    GameObject clone;
	// Use this for initialization
	void Start () {
        transform.tag = "Dark";
    }
	
	// Update is called once per frame
	void Update () {
	    if(stop == false && done == false)
        {
            
            clone = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y,-5), Quaternion.identity) as GameObject ;
            clone.transform.parent = transform;
            done = true;
        }
        if(stop == true && done == true)
        {
            Destroy(clone);
            done = false;
        }
	}


    void Stop()
    {
        stop = false;
    }

    void Go()
    {
        stop = true;
    }
}
