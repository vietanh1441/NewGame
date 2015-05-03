using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tireness : MonoBehaviour {
    public GameObject b_screen;
    private Screen screen_script;
	// Use this for initialization
	void Start () {
        b_screen = GameObject.FindGameObjectWithTag("Screen");
        screen_script = b_screen.GetComponent<Screen>();
	}
	
	// Update is called once per frame
	void Update () {
        Image image = GetComponent<Image>();
        //Debug.Log((double)screen_script.tired / 200);
        image.fillAmount = (float)screen_script.tired / screen_script.max;
        if (image.fillAmount > .65f)
        { image.color = Color.red; }
        else
            image.color = Color.green;
	}
}
