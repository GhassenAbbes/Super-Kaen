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
    private float hz;
    public Transform laserPoint;
    public GameObject laser;
    //public AudioSource mvmntsound;
    public bool moving { get; set; }
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

        HandleMovement(hz);
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            Jumping();
        if (Input.GetKeyDown(KeyCode.UpArrow) && !grounded && !doubleJumper) { 
            Jumping();
            doubleJumper = true;
        }
        animator.SetBool("grounded", grounded);
        Flip(hz);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.54f, 102f), Mathf.Clamp(transform.position.y, -6f, 10f), Mathf.Clamp(transform.position.z, -0.039f, -0.039f));

        //if (moving)
        //{
        //    mvmntsound.play();
        //}
    }

    public void HandleMovement (float horizontal)
    {   
        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
        animator.SetFloat("speedH", Mathf.Abs(hz));
    }

    public void Movement(float horizontal)
    {
       
        hz = horizontal;
    }

    public void Jumping ()
    {
        GetComponent<AudioSource>().Play();

        if (grounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpHight);
        else if (!doubleJumper)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHight);
            doubleJumper = true;
        }
    }
    public void Fire()
    {
        Instantiate(laser, laserPoint.position, laserPoint.rotation);
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
