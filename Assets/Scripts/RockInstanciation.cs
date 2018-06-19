using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInstanciation : MonoBehaviour {

    public GameObject rock;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Rock", 2f, 4f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Rock()
    {
        Instantiate(rock, transform.position, transform.rotation);
    }
}
