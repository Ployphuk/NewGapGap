using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChoicePosition : MonoBehaviour
{
    // Reference to the UI element you want to move
    public RectTransform uiElement;

    // The new top and bottom positions
    public float newTop;
    public float newBottom;

    // Method to be called when the button is pressed
    public void MoveElement()
    {
        // Get the current offsetMin and offsetMax values
        Vector2 offsetMin = uiElement.offsetMin;
        Vector2 offsetMax = uiElement.offsetMax;

        // Set the new top and bottom positions
        offsetMin.y = newBottom;
        offsetMax.y = -newTop;

        // Apply the new offsets
        uiElement.offsetMin = offsetMin;
        uiElement.offsetMax = offsetMax;
    }
}
