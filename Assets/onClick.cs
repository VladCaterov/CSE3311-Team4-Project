using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick1 : MonoBehaviour
{
    // Start is called before the first frame update

    public void NewGameSceneOnClick(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
