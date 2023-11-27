using UnityEngine.UI;
using UnityEngine;
public class ScoredisplayChem : MonoBehaviour
{
    private GameObject Score1;
    private GameObject Score2;
    public Movement_PLayer Points1;
    public MoveLeftRight Points2;
    public Text ScoreDisplayText1;
    public Text ScoreDisplayText2;

    void Start()
    {
        // Assign the components in the Start method
        Points1 = Score1.GetComponent<Movement_PLayer>();
        Points2 = Score2.GetComponent<MoveLeftRight>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplayText1.text = "Player: " + Points1.ScoreLeft;
        ScoreDisplayText2.text = "Boss: " + Points2.questions;
    }
}
