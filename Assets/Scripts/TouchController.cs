using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {
    public AudioSource sound;
    private PlayerController theplayer;
    public GameObject PauseUI;
    public string levelname;
    public GameObject ObjectifUI;
    private bool pause;
	// Use this for initialization
	void Start () {
        theplayer = FindObjectOfType<PlayerController>();
        pause = false;
        if (!SceneManager.GetActiveScene().name.Equals("MenuUI"))
          Time.timeScale = 0;
    }
	
	public void LeftArrow() {
        theplayer.moving = true;
        theplayer.Movement(-1);
    }
    public void RightArrow()
    {
        theplayer.moving = true;

        theplayer.Movement(1);
    }
    public void ResetMove()
    {
        theplayer.moving = false;

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

    public void CallLevel()
    {
        SceneManager.LoadScene(levelname);
    }

    public void CallMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuUI");
    }

    public void RestartE()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void onPause()
    {
        sound.Play();

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

    public void onPauseO()
    {
        ObjectifUI.SetActive(pause);
        Time.timeScale = 1;
    }
}
