using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class englishBoss : MonoBehaviour
{
    private CharacterController controller;
    private float initialPosition; 
    private Vector2 direction = Vector2.left;
    private float bossSpeed = 2.0f;
    private int rotations = 0;
    private int allowedRotations = 5;
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        initialPosition = transform.position.x;
        transform.Translate(bossSpeed * Time.deltaTime * direction);
    }

    // Update is called once per frame
    void Update()
    {
        if(!RotationComplete())
        {
            transform.Translate(bossSpeed * Time.deltaTime * direction);
        }
        if (transform.position.x <= -9)
        {
            direction = Vector2.right;
        }
        else if (transform.position.x >= 9)
        {
            direction = Vector2.left;
            if (RotationComplete())
            {
                bossSpeed = 0f;
                direction = Vector2.zero;
                transform.Translate(bossSpeed * Time.deltaTime * direction);
            }
        }   
    }

    bool RotationComplete()
    {
        if (direction == Vector2.left)
        {
            if (0 <= transform.position.x && transform.position.x <= 0.5)
            {
                Debug.Log("Rotation Completed");
                return true;
            }
        }
        return false;
    }
}
