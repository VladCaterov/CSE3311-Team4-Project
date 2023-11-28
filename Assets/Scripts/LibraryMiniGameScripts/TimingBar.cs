using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TimingBar : MonoBehaviour
{
    public Slider slider;
    public float IncrementValue = 0.5f;
    private bool LetsIncrease = false, LetsDecrease = false;
    private static float LowerBoundLine;
    private static float UpperBoundLine;
    private bool CanSelect = false;
    private float selectedPoint;
    private int ChoicesMade = 0, CorrectChoices = 0;
    public float BoundChangeValue = 5;
    public Text CorrectChoicesText;
    public Animator BlazeAnimation;
    public Animator BookAnimation;
    public GameObject GameDoneIndicator;
    public Text EndScreenCCDisplay;

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
            CanSelect = true;  //Allow ability to pickpoint
            LetsIncrease = true;
            LetsDecrease = false;
            BlazeAnimation.SetBool("CorrectlyAnswered", false);
            BookAnimation.SetBool("CorrectlyAnswered", false);

        }
        else if(slider.value >= slider.maxValue)
        {
            CanSelect = false; //Don't allow ability to pickpoint while decreasing
            LetsDecrease = true;
            LetsIncrease = false;
        }
        
        //Make the slider go up and down
        if(LetsIncrease)
        {
            IncreaseSlider();
        }
        else if(LetsDecrease)
        {
            DecreaseSlider();
        }

        //Check if player has made 10 selections to end minigame
        if (ChoicesMade == 10)
        {
            //pop up splash screen
            //Stop the shenanigans
            //reward player
            switch (CorrectChoices)
            {
                case 8:
                    //some reward
                    GameDoneIndicator.SetActive(true);
                    EndScreenCCDisplay.text = "Correct Choices: " + CorrectChoices;
                    LetsDecrease = false;
                    LetsIncrease = false;
                    CanSelect = false;
                    break;
                case 9:
                    //some reward
                    GameDoneIndicator.SetActive(true);
                    EndScreenCCDisplay.text = "Correct Choices: " + CorrectChoices;
                    LetsDecrease = false;
                    LetsIncrease = false;
                    CanSelect = false;
                    break;
                case 10:
                    //some reward
                    GameDoneIndicator.SetActive(true);
                    EndScreenCCDisplay.text = "Correct Choices: " + CorrectChoices;
                    LetsDecrease = false;
                    LetsIncrease = false;
                    CanSelect = false;
                    break;
                default:
                    GameDoneIndicator.SetActive(true);
                    EndScreenCCDisplay.text = "Correct Choices: " + CorrectChoices;
                    LetsDecrease = false;
                    LetsIncrease = false;
                    CanSelect = false;
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
        if (context.performed && (CanSelect))
        {
            CanSelect = false; //If we pick a point don't allow picking of points until we reach min again
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
                IncrementValue += 0.1f; //Up the speed of the slider
                CorrectChoicesText.text = CorrectChoices + "/10";
                BlazeAnimation.SetBool("CorrectlyAnswered", true);
                BookAnimation.SetBool("CorrectlyAnswered", true);
                Debug.Log("Choice " + ChoicesMade + " Correct");
                Debug.Log("Correct Choices: " + CorrectChoices);
            }
            else
            {
                Debug.Log("Out of Bounds");
                ChoicesMade++;
                Debug.Log("Choice " + ChoicesMade + " Incorrect");
            }
            
        }
    }
}
