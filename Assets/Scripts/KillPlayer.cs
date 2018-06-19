using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class KillPlayer : MonoBehaviour {
    private GameObject go;
    private AudioSource playerdeath;
    private LevelManager levelmanager;
	// Use this for initialization
	void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
        go = GameObject.Find("PlayerDeath");
        playerdeath = go.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player dead");
            playerdeath.Play();
            levelmanager.RespawnPlayer();
            //if (Advertisement.IsReady())
            //{
            //    Advertisement.Show();
            //}
           
        }
    }
}
