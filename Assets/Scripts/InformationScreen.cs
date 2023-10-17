using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InformationScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Button backButton;
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
        backButton.onClick.AddListener(delegate
        {
            SceneManager.LoadScene(1);
        });
    }
}
