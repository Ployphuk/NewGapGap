using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Include this if you're using legacy UI Text
using TMPro;

public class UiPointManager : MonoBehaviour
{
    public Text pointsText; // For legacy UI Text
    // public TextMeshProUGUI pointsText; // Uncomment this if you're using TextMeshPro

    private List<AddPoint> addPointScripts = new List<AddPoint>();

    public void Start()
    {
        // Find all AddPoint scripts in the scene
        addPointScripts.AddRange(FindObjectsOfType<AddPoint>());

        if (addPointScripts.Count == 0)
        {
            Debug.LogError("No AddPoint scripts found in the scene.");
        }
        else
        {
            UpdatePointsDisplay();
        }
    }

    public void UpdatePointsDisplay()
    {
        int totalPoints = 0;

        // Sum up the totalPoints from all AddPoint scripts
        foreach (var script in addPointScripts)
        {
            totalPoints += script.totalPoints;
        }

        if (pointsText != null)
        {
            pointsText.text = "Points: " + totalPoints.ToString();
        }
        else
        {
            Debug.LogError("Points Text reference is missing.");
        }
    }
}
