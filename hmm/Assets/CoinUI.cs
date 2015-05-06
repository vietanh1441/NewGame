using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinUI : MonoBehaviour {
    
    public Text text;
    public GameObject central_obj;
    public int coin;
    central central_script;

    // Use this for initialization
    void Start()
    {
        central_obj = GameObject.FindGameObjectWithTag("Central");
        central_script = central_obj.GetComponent<central>();
        coin = 0;
        text = GetComponent<Text>();
        text.text = "X 0";
        transform.tag = "CoinUI";
    }

    // Update is called once per frame
    void Update()
    {
        //  distance = player.GetComponent<Player>().distance;
        text.text = "X " + central_script.coin;
    }

    
}
