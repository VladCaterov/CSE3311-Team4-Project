using UnityEngine.UI;
using UnityEngine;

public class ScoredisplayChem : MonoBehaviour
{
    public GameObject Score1;
    public GameObject Score2;
    public PlayerMovement Points1;
    public MoveLeftRight Points2;
    public Text ScoreDisplayText1;
    public Text ScoreDisplayText2;

    void Start()
    {
        // Assign the components in the Start method
        Points1 = Score1.GetComponent<PlayerMovement>();
        Points2 = Score2.GetComponent<MoveLeftRight>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplayText1.text = "Player: " + (Points1 != null ? Points1.ScoreLeft.ToString() : "N/A");
        ScoreDisplayText2.text = "Boss: " + (Points2 != null ? Points2.questions.ToString() : "N/A");
    }
}

