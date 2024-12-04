using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    public float rotationAngle = 90f;
    // Correct angle for winning condition
    public float correctRotationAngle = 0f;

    void OnMouseDown()
    {
        // Rotate the sprite by the specified angle
        transform.Rotate(0, 0, rotationAngle);

        // Check if the sprite is at the correct rotation
        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        // Normalize the rotation to a range of 0-360 degrees
        float zRotation = transform.eulerAngles.z % 360;

        // If the current rotation matches the correct rotation, print a message
        if (Mathf.Approximately(zRotation, correctRotationAngle))
        {
            Debug.Log("Correct rotation!");
        }
    }
}
