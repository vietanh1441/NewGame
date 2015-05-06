using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceUI : MonoBehaviour {
    public Text text;
    public float distance;
   

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "Distance: 0";
        transform.tag = "DistanceUI";
	}
	
	// Update is called once per frame
	void Update () {
      //  distance = player.GetComponent<Player>().distance;
        text.text = "Distance: " + distance;
	}
}
