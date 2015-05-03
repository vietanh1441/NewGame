using UnityEngine;
using System.Collections;

public class start_button : MonoBehaviour {
    public GameObject narrator2;
    public GameObject music;
    public GameObject narrator1;
    GameObject music_main;
    public GameObject temp;
    public Transform pic;
    bool ok = false;

	// Use this for initialization
	void Start () {
        music_main = GameObject.FindGameObjectWithTag("Music");
	}
	
	// Update is called once per frame
	void Update () {
	   if(ok)
           pic.Translate(0, -1 * Time.deltaTime, 0);
	}

    void OnMouseDown()
    {
        temp.SendMessage("Stop");
        ok = true;
       
        //narrator2.GetComponent<AudioSource>().Play();
        StartCoroutine("Go");
    }

    IEnumerator Go()
    {
        yield return new WaitForSeconds(10);
        music.GetComponent<AudioSource>().Play();
        narrator1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(45);
        music.GetComponent<AudioSource>().Pause();
        narrator1.GetComponent<AudioSource>().Pause();
        narrator2.GetComponent<AudioSource>().Play();
        music_main.SendMessage("Play");
        //Application.LoadLevel("1ststage");
        StartCoroutine("Gomore");
    }
    IEnumerator Gomore()
    {
        yield return new WaitForSeconds(23);
        

        Application.LoadLevel("1ststage");
    }
}
