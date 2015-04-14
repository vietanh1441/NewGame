using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public bool facingRight = true;
    public bool jump = false;
    public Transform groundCheck;
    public float moveForce = 200f;
    public float maxSpeed = 5f;
    public float jumpForce = 500f;
    private bool grounded = false;
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

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

       

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

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

}
