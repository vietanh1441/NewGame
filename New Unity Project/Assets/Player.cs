﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public bool facingRight = true;
    public bool jump = false, run = true;
    public Transform groundCheck;
    public float moveForce = 200f;
    public float maxSpeed = 5f;
    public float jumpForce = 500f;
    private bool grounded = false;
    public float speed = 5;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

         if (Input.GetButton("Jump") && grounded)
        {
            jump = true;
            
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("HIT");
        if (other.tag == "Stone")
            StartCoroutine("Strip");

    }
 
    void FixedUpdate()
    {
        if(run)
            transform.Translate(speed * Time.deltaTime, 0, 0);

        if (jump)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    IEnumerator Strip()
    {

        run = false;
        transform.Translate(1, 0, 0);
        yield return new WaitForSeconds(.5f);
        run = true;

    }
}
