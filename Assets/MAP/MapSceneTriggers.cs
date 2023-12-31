using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneTriggers : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "chemistry")
        {
            SceneManager.LoadScene("ChemistryBoss");
        }
        else if (collision.gameObject.name == "utaMap")
        {
            SceneManager.LoadScene("uta-map");
        }
        else if (collision.gameObject.name == "physic")
        {
            SceneManager.LoadScene("Physics Boss");
        }
        else if (collision.gameObject.name == "library")
        {
            SceneManager.LoadScene("LibraryMiniGame");
        }
        else if (collision.gameObject.name == "WestHall")
        {
            SceneManager.LoadScene("Dorm-westHall");
        }
        else if (collision.gameObject.name == "exitgame")
        {
            SceneManager.LoadScene("uta-map");
        }
    }
}