using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button startGameButton;
    public Button continueGameButton;
    public Button loadGameButton;
    public Button settingsButton;
    public Button informationButton;
    // Start is called before the first frame update
    void Start()
    {
        InitializeButtons();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InitializeButtons()
    {
        startGameButton.onClick.AddListener(delegate { SceneManager.LoadScene("CharacterCreation"); });
        continueGameButton.onClick.AddListener(delegate { SceneManager.LoadScene("SampleScene"); });
        loadGameButton.onClick.AddListener(delegate { SceneManager.LoadScene("LoadGameScreen"); });
        settingsButton.onClick.AddListener(delegate { SceneManager.LoadScene("SettingsScreen"); });
        informationButton.onClick.AddListener(delegate { SceneManager.LoadScene("information-screen"); });
    }

}
