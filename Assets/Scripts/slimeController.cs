using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeController : MonoBehaviour {

    private Rigidbody2D rb;
    public float movementSpeed;
    public Transform groundCheck;
    public float groundcheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool moveRight;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Flip", 0.8f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundcheckRadius, whatIsGround);

        if (grounded)
            moveRight = !moveRight;
        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
        }

    }

    private void Flip()
    {
        moveRight = !moveRight;
    }
}
