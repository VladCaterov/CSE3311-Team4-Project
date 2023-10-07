using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCreator : MonoBehaviour
{
    public GameObject starters;
    public GameObject schedule;

    // Use this for initialization
    void Start()
    {
        starters = GameObject.Find("Starter Toggles");
        schedule = GameObject.Find("Classes Toggles");
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void BeginAdventure()
    {
        print("Hello");
        print(starters);

        float randLocationSceneID = Random.Range(5, 7);
        //SceneManager.LoadScene((int)randLocationSceneID);
        SceneManager.LoadScene("Start");
    }
}
