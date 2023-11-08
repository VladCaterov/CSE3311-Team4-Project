using System.Collections.Generic;
using UnityEngine;

public class SelectChoice : MonoBehaviour
{
    static public bool IsAFilledIn = false;
    static public bool IsBFilledIn = false;
    static public bool IsCFilledIn = false;
    static public choice selectedChoice = (choice)5;
    static public choice CorrectChoice;
    public Rigidbody2D rb;
    public Animator animator;
    public int PointsRight;
    static public GameObject Boss;
    public PlayerMovement BossLife = Boss.GetComponent<PlayerMovement>();
    public List<BoxCollider2D> BocColliderList = new List<BoxCollider2D>();
    private float PlatformTimer = 0f;
    public float MaxPlatformTimer = 30f;
    private bool TimerOn = false;

    //Random choice generation
    public enum choice { A, B, C };
    static choice[] values = (choice[])System.Enum.GetValues(typeof(choice));
    static System.Random random = new System.Random();
    
    /// Finish the enum and switch statement for randomizing the "Correct choice"

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CorrectChoice = (choice)random.Next(0, values.Length);
    }

    //Detects collision and sets selection
    private void OnCollisionEnter2D(Collision2D c)
    {

        if (c.otherCollider.name == "Choice A" && c.collider.tag == "Player")
        {
            IsAFilledIn = true;
            selectedChoice = choice.A;
        }
        else if (c.otherCollider.name == "Choice B" && c.collider.tag == "Player")
        {
            IsBFilledIn = true;
            selectedChoice = choice.B;
        }
        else if (c.otherCollider.name == "Choice C" && c.collider.tag == "Player")
        {
            IsCFilledIn = true;
            selectedChoice = choice.C;
        }
        
        // Check if player made the correct choice
        if (selectedChoice == CorrectChoice)
        {
            Debug.Log("Player selected correct choice");

            if (BossLife != null)
            {
                Debug.Log("boss found");
                BossLife.markPoints(PointsRight);
                //selectedChoice = (choice)5; //reset the selected choice so it can't damage
            }

            DisableAllBoxColliders();
            TimerOn = true;
        }
        else
        {
            DisableAllBoxColliders();
            TimerOn = true;
        }
    }



    private void Update()
    {
        Debug.Log(CorrectChoice);

        //random correct choice generated, put after damage applied

        //Handles the selection animation and limits others from being selected while selection made
        if (IsAFilledIn == true && IsBFilledIn == false && IsCFilledIn == false)
        {
            animator.SetBool("IsAFilledIn", true);
            Debug.Log("A Selected");
        }
        else if(IsBFilledIn == true && IsAFilledIn == false && IsCFilledIn == false)
        {
            animator.SetBool("IsBFilledIn", true);
            Debug.Log("B Selected");
        }
        else if(IsCFilledIn == true && IsBFilledIn == false && IsAFilledIn == false)
        {
            animator.SetBool("IsCFilledIn", true);
            Debug.Log("C Selected");
        }

        if (TimerOn)
        {
            PlatformTimer += Time.deltaTime; //increase timer
        }
        if (PlatformTimer >= MaxPlatformTimer) //Reset settings
        {
            TimerOn = false;
            EnableAllBoxColliders();
            IsAFilledIn = false;
            IsBFilledIn = false;
            IsCFilledIn = false;
            animator.SetBool("IsAFilledIn", false);
            animator.SetBool("IsBFilledIn", false);
            animator.SetBool("IsCFilledIn", false);
            CorrectChoice = (choice)random.Next(0, values.Length); //change correct choice
            selectedChoice = (choice)5; //reset the selected choice so it can't damage
            Debug.Log(CorrectChoice);
            PlatformTimer = 0f;

        }

    }

    // Function to disable all the Box Colliders in the list
    public void DisableAllBoxColliders()
    {
        foreach (var boxCollider in BocColliderList)
        {
            if (boxCollider != null)
            {
                boxCollider.enabled = false;
            }
        }
    }

    public void EnableAllBoxColliders()
    {
        foreach (var boxCollider in BocColliderList)
        {
            if (boxCollider != null)
            {
                boxCollider.enabled = true;
            }
        }
    }

    /*
     * TODO
     * Make the desks box colliders disable randomly when the platforms disable
     * to provide the player with cover to avoid the projectiles and keep the game interesting.
     * 
     * PLAN
     * 1. Make a list to contain all of the desk colliders
     * 2. Create randomization variable and make it select one of the desks randomly to keep the box collider for
     * 3. Attach the Platform timer to this
     * 4. Reenable these desks
     * 5. Also add a color to indicate which desk is the cover
     * 6. Make a timer to switch desk cover
    */
}


