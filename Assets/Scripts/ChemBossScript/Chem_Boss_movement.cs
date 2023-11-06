using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 0.5f;
    public float distance = 7f;
    //check if the question button is pressed
    private bool pressed = false;

    public Animator anim; //for animation
    public GameObject Character; //for Boss character 
    public GameObject EndMessageUI; //To display end of message Canvas at the end 

    private int questions = 30; //number of questions
    private Vector3 startPosition; //for boss left right movement 
    private bool movingRight = true; //check if player is moving right 

    void Start()
    {
        startPosition = transform.position; //gets the start position and animator component
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //finds the position it needs to move to using math.sin function 
        float newPosition = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPosition + transform.right * newPosition; //transforms position
        //flips the character if the posiiton is about to be equal to the distance 
        if ((newPosition >= (distance - 0.1) && movingRight) || (newPosition <= (-distance + 0.1) && !movingRight))
        {
            FlipCharacter();
        }
        //plays animation if the space bar or the Question button is pressed 
        if (Input.GetKeyDown(KeyCode.Space) || pressed)
        {
            anim.SetBool("Bossthrow", true);
            questions = questions - 1;
            pressed = false;
        }
        else
        {
            anim.SetBool("Bossthrow", false);
        }
        if (questions == 0)
        {
            /*if the count goes to zero then destroy the chracter and invoke the end of screen canvas 30 sec after last projectile */
            Destroy(Character,30.01f);
            Invoke(nameof(End_Message), 30.0f);
        }
    }

    void FlipCharacter()
    {
        //flips the chracter along the X axis
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        movingRight = !movingRight;//change boolean expression
    }
    void End_Message()
    {
        //opens the canvas for end of game 
        EndMessageUI.SetActive(true);
        Time.timeScale = 0f;    
    }
    public void continueButton()
    {
        //closes the end of game canvas 
        EndMessageUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void QuestionButtonAnim()
    {
        //the question fireing button is pressed 
        pressed = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the player touches boss gets 100 points taken off 
        if (collision.gameObject.TryGetComponent<Movement_PLayer>(out Movement_PLayer Josh))
        {
            Josh.markWrong(100);
        }

    }
}
