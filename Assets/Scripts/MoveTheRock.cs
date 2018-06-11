using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheRock : MonoBehaviour {

    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(-1f, rb.velocity.y);
        transform.Rotate(0f, 0f, 100 * Time.deltaTime);

    }
}
