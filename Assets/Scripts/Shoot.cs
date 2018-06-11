using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    private Rigidbody2D rb;
    public float movementSpeed;
    
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(rb.velocity.x, -movementSpeed);
    }
}
