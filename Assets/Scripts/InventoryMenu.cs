using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject inventoryMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void ResumeGame()
    {
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;

    }
    public void PauseGame()
    {
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;

    }
}