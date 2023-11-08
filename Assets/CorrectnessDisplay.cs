using UnityEngine.UI;
using UnityEngine;

public class CorrectnessDisplay : MonoBehaviour
{
    public Text CorrectnessDisplayText;

    // Update is called once per frame
    void Update()
    {
        if (SelectChoice.selectedChoice == SelectChoice.CorrectChoice && (SelectChoice.IsAFilledIn || SelectChoice.IsBFilledIn || SelectChoice.IsCFilledIn))
        {
            CorrectnessDisplayText.text = "CORRECT";

        }
        else if(SelectChoice.selectedChoice != SelectChoice.CorrectChoice && (SelectChoice.IsAFilledIn || SelectChoice.IsBFilledIn || SelectChoice.IsCFilledIn))
        {
            CorrectnessDisplayText.text = "INCORRECT";
        }
        else
        {
            CorrectnessDisplayText.text = "";
        }
    }
}

