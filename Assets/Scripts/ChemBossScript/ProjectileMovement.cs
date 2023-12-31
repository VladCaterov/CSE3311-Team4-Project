using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 1.2f;
    private Rigidbody2D rb;
    private Vector2 lastVelocity;
    public int PointsOff = 17;
    private float destroyDelay = 30.0f; //wait time until destroyed 

    void Start()
    {
        //get rigidbody component 
        rb = GetComponent<Rigidbody2D>();
        //adds an intital force to the vector to make it move 
        rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        //destroyDelay it in 30 seconds 
        Destroy(gameObject, destroyDelay);
    }

    void Update()
    {
        //get the velocity of the object 
        lastVelocity = rb.velocity;
        //if it is slwoing down, make it go down again
        if (rb.velocity.magnitude < 0.5f)
        {
            rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //also check for speed of objects in collision 
        if (rb.velocity.magnitude < 0.5f)
        {
            rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        }
        //if the object collides with the player then take off points 
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement Josh))
        {
            Josh.markPoints(PointsOff);
        }
        //when it collides with something, reflect the direction that its going 
        speed = lastVelocity.magnitude;
        var direction = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
