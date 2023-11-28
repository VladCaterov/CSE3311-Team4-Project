using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_PLayer : MonoBehaviour
{
    public int ScoreLeft = 100; //Student's Test Score

    public GameObject EndGameUI;

    public void markWrong(int SubtractScore) //Mark question "wrong" on student
    {
        ScoreLeft -= SubtractScore;
        if (ScoreLeft <= 0)
        {
            Fail();
        }
    }

    void Fail()
    {
        EndGameUI.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject); //BAIHHH JOSH
    }
}
