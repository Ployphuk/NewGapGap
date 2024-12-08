using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameManager : MonoBehaviour
{
    public RotateOnClick[] rotatingPictures; // Assign all 12 sprites here
    public GameObject WinUI; // Optional UI for winning

    void Update()
    {
        // Check if all pictures are in the correct position
        if (CheckAllPicturesCorrect())
        {
            Debug.Log("You Win!");
            if (WinUI != null)
            {
                WinUI.SetActive(true); // Show a win UI if assigned
            }
        }
    }

    bool CheckAllPicturesCorrect()
    {
        foreach (var picture in rotatingPictures)
        {
            // Normalize rotation and check against the correct angle
            float zRotation = picture.transform.eulerAngles.z % 360;
            if (!Mathf.Approximately(zRotation, picture.correctRotationAngle))
            {
                return false; // Return false if any picture is incorrect
            }
        }
        return true; // All pictures are correct
    }
}
