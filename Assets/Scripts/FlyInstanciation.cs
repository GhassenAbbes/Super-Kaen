using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyInstanciation : MonoBehaviour {

    public GameObject fly;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Fly", 2f, 4f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Fly()
    {
        Instantiate(fly, transform.position, transform.rotation);
    }
}
