using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TimingBar : MonoBehaviour
{
    public Slider slider;
    public float IncrementValue = 0.5f;
   // private int multiplier = 10;
    private bool LetsIncrease = false, LetsDecrease = false;
    public RectTransform UpperBound;
    public RectTransform LowerBound;
    private static float LowerBoundLine;
    private static float UpperBoundLine;
    private float selectedPoint;
    private int ChoicesMade = 0, CorrectChoices = 0;
    public float BoundChangeValue = 5;

    // Start is called before the first frame update

    void Start()
    {
        LowerBoundLine = 71;
        UpperBoundLine = 97;
    }
    
    // Update is called once per frame
    void Update()
    {
        //set flags for decrease and increasing based on the reaching min & max slider boundaries
        if(slider.value <= slider.minValue)
        {
            LetsIncrease = true;
            LetsDecrease = false;
        }
        else if(slider.value >= slider.maxValue)
        {
            LetsDecrease = true;
            LetsIncrease = false;
        }
        
        //Make the slider go up and down
        if(LetsIncrease == true)
        {
            IncreaseSlider();
        }
        else if(LetsDecrease == true)
        {
            DecreaseSlider();
        }
        
        //Check if player has made 10 selections to end minigame
        if (ChoicesMade == 10)
        {
            //pop up splash screen
            //reward player
            switch (CorrectChoices)
            {
                case 8:
                    //some reward
                    break;
                case 9:
                    //some reward
                    break;
                case 10:
                    //some reward
                    break;
            }
            //endgame
        }
    }
    /*
    public void ShrinkZone()
    {
        //Shrink the upper and lower limits of acceptable values for the slider.value
        //also increase the multiplier which will affect the speed of increasing and decreasing
        UpperBoundLine -= BoundChangeValue;
        LowerBoundLine += BoundChangeValue;
        Debug.Log("New UpperBound: " + UpperBoundLine);
        Debug.Log("New LowerBound: " + LowerBoundLine);

        //Change the actual position in UI
        UpperBound.rect.Set(UpperBound.anchoredPosition.x, UpperBoundLine, UpperBound.rect.width, (UpperBoundLine - UpperBound.rect.yMin)); //may need to fix this height variable 
        LowerBound.rect.Set(LowerBound.rect.x, LowerBoundLine, LowerBound.rect.width, LowerBound.rect.height);
        Debug.Log("The zone has been shrunk");
    }
    */
    private void DecreaseSlider()
    {
        slider.value -= IncrementValue;
        //Debug.Log(slider.fillRect.rect.y);
    }

    private void IncreaseSlider()
    {
        slider.value += IncrementValue;
        //Debug.Log(slider.fillRect.rect.y);
    }


    public void PickPoint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
           // Debug.Log("Upper bound: " + UpperBoundLine);
            //Debug.Log("Lower bound: " + LowerBoundLine);
            Debug.Log("Point Picked");
            selectedPoint = slider.value; //Used absolute value since the values are coming out negative hmmmmm...
            Debug.Log("Selected Point: " + selectedPoint);
            //Check for acceptable choice (check if within bounds)
            
            if ((selectedPoint >= LowerBoundLine) && (selectedPoint <= UpperBoundLine))
            {
                Debug.Log("Point Picked in bounds");
                //ShrinkZone();
                ChoicesMade++;
                CorrectChoices++;
                Debug.Log("Choices Made: " + ChoicesMade);
                Debug.Log("Correct Choices: " + CorrectChoices);
            }
            else
            {
                Debug.Log("It's just not your day");
                ChoicesMade++;
                Debug.Log("Choices Made: " + ChoicesMade);
            }
            
        }
    }
}
