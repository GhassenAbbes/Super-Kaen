using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {


    public LevelManager levelmanager;
    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelmanager.currentCheckpoint = gameObject;
        }
    }
}
