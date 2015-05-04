using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
    public bool facingRight = true;
    bool death = false;
    public bool jump = false, run = true;
   // public Transform groundCheck;
    /*public float moveForce = 200f;
    public float maxSpeed = 5f;
    public float jumpForce = 500f;*/
    private bool grounded = false;
    public float speed = 5;
    private Rigidbody2D rb2d;
    public float distance;
    GameObject screen;
    List<string> scene_list = new List<string>();
    string scene;

    
	// Use this for initialization
	void Start () {
        distance = 0;
        screen = GameObject.FindGameObjectWithTag("Screen");
        rb2d = GetComponent<Rigidbody2D>();
        GameObject D_UI = GameObject.FindGameObjectWithTag("DistanceUI");
        DistanceUI DUI = D_UI.GetComponent<DistanceUI>();
        scene_list.Add("1ststage");
        scene_list.Add("2stage");
        scene_list.Add("3stage");
        scene = scene_list[0];

    }
	
	// Update is called once per frame
	void Update () {
        /*grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        
         if (Input.GetButton("Jump") && grounded)
        {
            jump = true;
            
        }*/

	}

    void OnTriggerEnter2D(Collider2D other)
    {

       // Debug.Log("HIT");
        if (other.tag == "Stone")
            StartCoroutine("Strip");
        else if (other.tag == "Death")
            Death();
       

    }
 
    void FixedUpdate()
    {

        if (run)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            distance++;
        }
        if(death)
        {
            run = false;
            Death();
        }
        /*
        if (jump)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
        */
    }

    void Death()
    {

        screen.SendMessage("Death");
        
        
    }

    

    void Restart_from_checkpoint()
    {
        Time.timeScale = 1;
        Application.LoadLevel(scene);
    }
   /* void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }*/

    IEnumerator Strip()
    {

        run = false;
        transform.Translate(1, 0, 0);
        yield return new WaitForSeconds(.5f);
        run = true;

    }

    void NextScene(int num)
    {
        scene = scene_list[num];
    }
}
