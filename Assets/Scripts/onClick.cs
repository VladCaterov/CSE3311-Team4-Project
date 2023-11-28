using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update

    public void SceneLoadOnClick(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void StartGame(ToggleGroup starterToggleGroup, ToggleGroup scheduleToggleGroup)
    {
        print(starterToggleGroup);
        print(scheduleToggleGroup);

    }
}
