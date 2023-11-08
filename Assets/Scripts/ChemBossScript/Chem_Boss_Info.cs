using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chem_Boss_Info : MonoBehaviour
{
    /*at the start of the game, display an info screen and get rid of the screen after the user pressed start game*/ 
    public GameObject Chem_boss_InfoUI;
    void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Chem_boss_InfoUI.SetActive(false);
        Time.timeScale = 1f;
    }

    //switch scenes
    public void RetryButton()
    {
        SceneManager.LoadScene("ChemistryBoss");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Dorm-westHall");
    }
}
