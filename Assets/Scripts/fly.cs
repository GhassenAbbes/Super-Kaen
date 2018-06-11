using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

    private Rigidbody2D rb;
    public GameObject flydead;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-1f, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fire"))
        {
            Destroy(other.gameObject);
            Instantiate(flydead, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
