using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadGameScreen : MonoBehaviour
{
    public Button backButton;
    public Button inventoryDemo;
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
        backButton.onClick.AddListener(delegate { SceneManager.LoadScene("start"); });
        inventoryDemo.onClick.AddListener(delegate { SceneManager.LoadScene("uta-map"); });

    }
}
