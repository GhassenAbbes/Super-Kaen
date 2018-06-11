using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour {


    public Transform laserPoint;
    public GameObject laser;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 2f, 3f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Fire()
    {
        Instantiate(laser, laserPoint.position, laserPoint.rotation);
    }
}
