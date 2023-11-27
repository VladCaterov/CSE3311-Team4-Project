using UnityEngine.UI;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
   static public GameObject Score1;
   static public GameObject Score2;
    public PlayerMovement Points1 = Score1.GetComponent <PlayerMovement>();
   public PlayerMovement Points2 = Score2.GetComponent <PlayerMovement>();
   public Text ScoreDisplayText1;
   public Text ScoreDisplayText2;
  
    // Update is called once per frame
    void Update()
    {
      ScoreDisplayText1.text = "Player: " + Points1.ScoreLeft;
      ScoreDisplayText2.text = "Boss: " + Points2.ScoreLeft;
    }
}
