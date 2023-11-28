using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject MapUI;

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;

    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;

    }
    //changing scenes 
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void displayMap()
    {
        MapUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void GoBack()
    {
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

