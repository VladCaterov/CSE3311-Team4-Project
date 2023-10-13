using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class PlayerMovement : MonoBehaviour
{
   public Rigidbody2D rb;
   public Transform groundCheck;
   public LayerMask groundLayer;
   private float horizontal;
   private float speed = 5f;
   private float jumpingPower = 10f;
   private bool isFacingRight = true;

   void Update()
   {
      rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
      if(!isFacingRight && horizontal > 0f)
      {
         flip();
      }
      else if(isFacingRight && horizontal < 0f)
      {
         flip();
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
      horizontal = context.ReadValue<Vector2>().x;
   }


   public void Jump(InputAction.CallbackContext context)
   {
      if(context.performed && IsGrounded())
      {
         rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
      }
      //This is used to make the jump shorter or longer depending on how long the button is held
      if(context.canceled && rb.velocity.y > 0f)
      {
         rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
      }
   }

}
