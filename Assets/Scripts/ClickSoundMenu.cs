using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Button))]

public class ClickSoundMenu : MonoBehaviour {
    //public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Use this for initialization
    void Start () {
        //gameObject.AddComponent<AudioSource>();
        //source.clip = sound;
        //source.playOnAwake = false;
        //button.onClick.AddListener(() => PlaySound());
	}

    public  void PlaySound()
    {
        Debug.Log("button return");

        source.Play();
    }
}
