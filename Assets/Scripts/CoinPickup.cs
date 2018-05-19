using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {
    public int pointsToAdd;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
    }
}
