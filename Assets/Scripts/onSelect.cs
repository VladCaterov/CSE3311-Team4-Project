using UnityEngine;
using UnityEngine.SceneManagement;

public class onSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public void SceneLoadOnClick(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
