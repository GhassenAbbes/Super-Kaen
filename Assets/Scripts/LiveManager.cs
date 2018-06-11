using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveManager : MonoBehaviour {

    public static int live;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        live = 0;
    }

    void Update()
    {
        if (live < 0)
            live = 0;

        text.text = "" + live;
    }

    public static void leavelive ()
    {
        live = live+1;
    }

    public static void Reset()
    {
        live = 0;
    }
}
