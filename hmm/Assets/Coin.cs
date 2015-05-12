using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    GameObject central;
    private Animator m_Anim;
    private Collider2D m_collider;
	// Use this for initialization
	void Start () {
        central = GameObject.FindGameObjectWithTag("Central");
        m_Anim = GetComponent<Animator>();
        m_collider = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Taken();
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("?");
            Taken();
        }
    }

    void Taken()
    {
        central.SendMessage("Increment");
        m_collider.enabled = false;
       
       // transform.Translate(0, 1, 0);
        m_Anim.SetBool("get", true);
        StartCoroutine("Spin");
        Destroy(gameObject);
    }

    IEnumerator Spin()
    {
        transform.Translate(0,10*Time.deltaTime, 0);
        yield return new  WaitForSeconds(0.5f);
        //m_Anim.SetBool("get", true);
        

    }
}
