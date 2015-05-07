using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class Right_screen : MonoBehaviour
    {
        GameObject player;
        Platformer2DUserControl script;
        // Use this for initialization
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            script = player.GetComponent<Platformer2DUserControl>();
        }

        // Update is called once per frame
        void Update() {
	    
	    }

        void OnMouseDown()
        {
            script.m_Jump = true;
            
        }
    }
}