using UnityEngine;

public class application : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void Update()
    {

        Application.Quit();
    }
}
