using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public AudioClip playerdeath;
    public GameObject currentCheckpoint;
    private PlayerController player;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        LiveManager.leavelive();
        Debug.Log("Player Respawn");
        
        //AudioSource aus = new AudioSource();
        //aus.PlayOneShot(playerdeath);
        player.transform.position = currentCheckpoint.transform.position;
        

    }
}
