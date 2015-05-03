using UnityEngine;
using System.Collections;

public class temp_music : MonoBehaviour {
    public AudioSource audio1;
    public AudioSource audio2;
    bool stop;
    int fill = 200;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(stop)
        {
            audio1.volume = fill * 0.005f;
            audio2.volume = fill * 0.005f;
            fill--;
        }
	}

    void Stop()
    {
        stop = true;
    }
}
