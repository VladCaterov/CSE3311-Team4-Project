using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInstructions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ENG_boss_InfoUI;
    void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        ENG_boss_InfoUI.SetActive(false);
        Time.timeScale = 1f;
    }

    //switch scenes
    public void RetryButton()
    {
        SceneManager.LoadScene("EnglishBoss");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Dorm-westHall");
    }
}
