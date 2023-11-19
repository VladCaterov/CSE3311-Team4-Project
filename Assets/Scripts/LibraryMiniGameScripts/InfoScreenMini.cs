using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScreenMini : MonoBehaviour
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
        StartGame();
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Dorm-westHall");
    }
}
