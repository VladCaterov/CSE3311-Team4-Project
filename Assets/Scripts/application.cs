using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class application : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void Update()
    {
       
            Application.Quit();
    }
}
