using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScreen : MonoBehaviour
{
    /*at the start of the game, display an info screen and get rid of the screen after the user pressed start game*/ 
    public GameObject InfoUI; //our boss info canvas object, maybe use game object if canvas doesn't work

    void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        InfoUI.SetActive(false);
        Time.timeScale = 1f;
    }

    //switch scenes
    public void RetryButton()
    {
        SceneManager.LoadScene("Physics Boss");
        StartGame(); //may need to find alternative to this
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Dorm-westHall");
    }
}
