using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to the character's Transform
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Offset for camera position
    public Vector2 minPosition = new Vector2(0f, 0f); // Minimum camera position
    public Vector2 maxPosition = new Vector2(0f, 0f);  // Maximum camera position

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;

            // Clamp the camera's position within the defined limits
            desiredPosition.x = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
            desiredPosition.y = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);
        }
    }
}
