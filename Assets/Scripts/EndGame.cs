using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public int c;
    public int d;
    public int t;
    public string levelname;

    public GameObject Coins;
    public GameObject CoinsGet;
    public GameObject Death;
    public GameObject DeathGet;
    public GameObject Timer;
    public GameObject TimerGet;
    public GameObject Level;
    public GameObject Grade;
    public GameObject Next;
    public GameObject Restart;

    string adUnitId = "ca-app-pub-4640846911906598/1699292382";

    // Use this for initialization
    void Start () {

        GameOver();
        
        Time.timeScale = 0;
        Level.GetComponent<Text>().text = ""+levelname;
        bool success=true;
        if (Int32.Parse(CoinsGet.GetComponent<Text>().text.ToString()) < c)
            success = false;

        else if (Int32.Parse(DeathGet.GetComponent<Text>().text.ToString()) > d)
            success = false;

        else {
            String[] substrings = TimerGet.GetComponent<Text>().text.ToString().Split('.');
            if (substrings.Length == 3)
                success = false;
            else
            {
                if (Int32.Parse(substrings[0])>t)
                    success = false;
            }
        }

        if (success) {
            Grade.GetComponent<Text>().text = "Great";
            Next.SetActive(true);
        }
        else
        {
            Grade.GetComponent<Text>().text = "You can do better";
            Restart.SetActive(true);
        }

        Coins.GetComponent<Text>().text = CoinsGet.GetComponent<Text>().text + "/" + c;
        Death.GetComponent<Text>().text = DeathGet.GetComponent<Text>().text + "/" + d;
        Timer.GetComponent<Text>().text = TimerGet.GetComponent<Text>().text + "'s/" + t+"'s";
    }

    private void GameOver()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }

        // Initialize the Google Mobile Ads SDK.
        InterstitialAd interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
