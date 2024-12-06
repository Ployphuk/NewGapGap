using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    public int points = 0; // Points to add per click
    public int totalPoints = 0; // Cumulative total points
    public UiPointManager uiPointManager; // Reference to UIManager

    void Start()
    {
        Debug.Log("Initial Points Value: " + points);
    }

    public void PlusPoint()
    {
        totalPoints += points; // Add points to totalPoints
        Debug.Log("Total Points: " + totalPoints);

        if (uiPointManager != null)
        {
            uiPointManager.UpdatePointsDisplay(); // Update the UI
        }
        else
        {
            Debug.LogError("UIManager reference is missing.");
        }
    }
}
