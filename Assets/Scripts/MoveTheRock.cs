using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheRock : MonoBehaviour {
    private GameObject go;
    private AudioSource playerdeath;
    private LevelManager levelmanager;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
        rb = GetComponent<Rigidbody2D>();
        go = GameObject.Find("PlayerDeath");
        playerdeath = go.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(-1f, rb.velocity.y);
        transform.Rotate(0f, 0f, 100 * Time.deltaTime);

    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            playerdeath.Play();
            levelmanager.RespawnPlayer();
        }
    }
}
