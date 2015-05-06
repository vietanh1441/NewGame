using UnityEngine;
using System.Collections;

public class temp_music : MonoBehaviour {
    public AudioSource audio1;
    public AudioSource audio2;
    bool stop;
    int fill = 500;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(stop)
        {
            audio1.volume = fill * 0.002f;
            audio2.volume = fill * 0.0005f;
            fill--;
        }
	}

    void Stop()
    {
        stop = true;
    }
}
