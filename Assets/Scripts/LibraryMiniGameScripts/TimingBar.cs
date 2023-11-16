using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TimingBar : MonoBehaviour
{
    public Slider slider;
    public float IncrementValue = .05f;
    private int multiplier = 10;
    private bool LetsIncrease = false, LetsDecrease = false;
    private float UpperBound = 95f, LowerBound = 60f;
    float selectedPoint;
    private int ChoicesMade = 0, CorrectChoices = 0;
    public float BoundChangeValue = 5;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        //We can probably assign the statement below to get the actual value of the bar as it fills in
        //*************************
        //slider.fillRect.rect.y; *
        //*************************

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
            Debug.Log("Increasing");
            Debug.Log(slider.fillRect.rect.y);
            IncreaseSlider();
        }
        else if(LetsDecrease == true)
        {
            Debug.Log("Decreasing");
            Debug.Log(slider.fillRect.rect.y);
            DecreaseSlider();
        }
        
        //Check if player has made 10 selections to end minigame
        if (ChoicesMade == 10)
        {
            //endgame
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
        }
    }

    public void ShrinkZone()
    {
        //Shrink the upper and lower limits of acceptable values for the slider.value
        //also increase the multiplier which will affect the speed of increasing and decreasing
        UpperBound -= BoundChangeValue;
        LowerBound += BoundChangeValue;
    }

    private void DecreaseSlider()
    {
        slider.value -= IncrementValue * multiplier;
    }

    private void IncreaseSlider()
    {
        slider.value += IncrementValue * multiplier;
    }


    public void PickPoint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            selectedPoint = slider.fillRect.rect.y;
            //Check for acceptable choice (check if within bounds)
            if ((selectedPoint >= LowerBound) && (selectedPoint <= UpperBound))
            {
                ShrinkZone();
                ChoicesMade++;
                CorrectChoices++;
            }
            else
            {
                ChoicesMade++;
            }
        }
    }
}
