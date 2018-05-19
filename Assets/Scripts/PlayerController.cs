using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    private Rigidbody2D rb;
    private Animator animator;
    public float movementSpeed;
    public float jumpHight;
    public Transform groundCheck;
    public float groundcheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumper;
    private bool facingRight;
	// Use this for initialization
	void Start () {
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundcheckRadius, whatIsGround);
        if (grounded)
            doubleJumper = false;  
        float hz = Input.GetAxis("Horizontal");
        HandleMovement(hz);
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            Jumping();
        if (Input.GetKeyDown(KeyCode.UpArrow) && !grounded && !doubleJumper) { 
            Jumping();
            doubleJumper = true;
        }
        animator.SetBool("grounded", grounded);
        Flip(hz);
        
	}

    private void HandleMovement (float horizontal)
    {
        rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);
        animator.SetFloat("speedH", Mathf.Abs(horizontal));
    }

    private void Jumping ()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHight);
    }
    private void Flip (float horizontal)
    {
        if (horizontal>0 && !facingRight || horizontal<0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
