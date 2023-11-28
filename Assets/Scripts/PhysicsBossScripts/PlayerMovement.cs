using UnityEngine;
using UnityEngine.InputSystem;
using ETouch = UnityEngine.InputSystem.EnhancedTouch;
using UnityEditor;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private float horizontal,vertical;
    private float speed = 5f;
    private float jumpingPower = 10f;
    private bool isFacingRight = true;
    public Animator animator;

    public GameObject GameStatusIndicator;
    public GameObject GameOverIndicator;
    public GameObject PassedExamIndicator;
    public GameObject EndGameUI;
    public SceneAsset Scene;
    

    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal)); //takes horizontal movement speed and updates/trigger animation for running
        animator.SetFloat("VertSpeed", vertical);
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (IsGrounded())
        {
            animator.SetBool("IsJumping", false);
        }
        if (rb.velocity.y > 0.01 && Scene.name == "Physics Boss")  //Only allow jumping in Physics boss level
        {
            animator.SetBool("IsJumping", true);
        }

        if (!isFacingRight && horizontal > 0f)
        {
            flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            flip();
        }

        if(GameStatusIndicator == null)
        {
            animator.SetBool("CanCelebrateNow", true);
            PassedExamIndicator.SetActive(true);
        }

        
    }

    //Used to check if the player is on the ground, will be used for determining if another jump is allowed
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }
    //flip function used to flip the direction of the player
    private void flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        if(GameStatusIndicator != null)
        {
            horizontal = context.ReadValue<Vector2>().x; //condition to allow player to move and stop upon win
            vertical = context.ReadValue<Vector2>().y;
            if(vertical>0)
            {
                rb.velocity = new Vector2(rb.velocity.x, vertical * speed * .6f);
            }
            if (vertical < 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, vertical * speed * .6f);
            }
            if(context.canceled)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0); //Makes sure player doesn't float into the universe

            }
        }
    }

    
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            if(GameStatusIndicator != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower); //condition to allow player to Jump and stop upon win
            }
        }
        //This is used to make the jump shorter or longer depending on how long the button is held
        if (context.canceled && rb.velocity.y > 0f)
        {
            if (GameStatusIndicator != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            }
                
        }
    }

    //Health System
    public int ScoreLeft = 100; 

    public void markPoints(int SubtractScore)
    {
        ScoreLeft -= SubtractScore;
        if (ScoreLeft <= 0)
        {
            Fail();
            GameOverIndicator.SetActive(true);
        }
    }

    void Fail()
    {
        //EndGameUI.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }


}
