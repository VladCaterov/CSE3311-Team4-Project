using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    public GameObject leftBound;
    public GameObject rightBound;

    private int screenWidth = Screen.width;
    private int screenHeight = Screen.height;

    Vector2 temporaryScale;
    Vector2 temporaryPosition;

    void Awake()
    {
        // Changing size of left and right bound
        temporaryScale = leftBound.transform.localScale;
        temporaryScale.y = 5f;
        leftBound.transform.localScale = temporaryScale;

        temporaryScale = rightBound.transform.localScale;
        temporaryScale.y = 5f;
        rightBound.transform.localScale = temporaryScale;


        // Changing position of left and right bound
        temporaryPosition = leftBound.transform.position;
        temporaryPosition.x = Screen.safeArea.x;
        leftBound.transform.position = temporaryPosition;
       
    }
}
