using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

    private PlayerController theplayer;
    public GameObject PauseUI;
    private bool pause;
	// Use this for initialization
	void Start () {
        theplayer = FindObjectOfType<PlayerController>();
        pause = false;
	}
	
	public void LeftArrow() {
        theplayer.Movement(-1);
    }
    public void RightArrow()
    {
        theplayer.Movement(1);
    }
    public void ResetMove()
    {
        theplayer.Movement(0);
    }
    public void Jump()
    {
        theplayer.Jumping();
    }

    public void Fire()
    {
        theplayer.Fire();
    }

    public void Restart()

    {
        onPause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void onPause()
    {
        pause = !pause;
        
        if (!pause)
        {
            PauseUI.SetActive(pause);
            Time.timeScale = 1;
        }else
        {
            PauseUI.SetActive(pause);
            Time.timeScale = 0;
        }
    }
}
