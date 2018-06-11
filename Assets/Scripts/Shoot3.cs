using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot3 : MonoBehaviour {

    private Rigidbody2D rb;
    public float movementSpeed;
    private PlayerController theplayer;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        theplayer = FindObjectOfType<PlayerController>();
        if (theplayer.transform.localScale.x < 0)
            movementSpeed = -movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
    }
}
