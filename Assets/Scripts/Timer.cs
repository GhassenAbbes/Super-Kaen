using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    Text text;
    private float startTimer;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        startTimer = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - startTimer;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        if (minutes == "0") {
            text.text = "" + seconds;
        }
        else { 
            text.text = minutes + ":" + seconds;
        }
    }
}
