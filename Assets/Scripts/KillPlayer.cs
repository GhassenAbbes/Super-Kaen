using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
    //public AudioSource playerdeath;
    private LevelManager levelmanager;
	// Use this for initialization
	void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
           
            levelmanager.RespawnPlayer();
            //playerdeath.Play();
        }
    }
}
