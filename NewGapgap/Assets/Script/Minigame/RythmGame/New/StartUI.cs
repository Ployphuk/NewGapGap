using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    public GameObject startUI; // Assign your UI canvas here.
    private bool isUIActive = true; // Tracks if the UI is currently active.

    void Start()
    {
        if (startUI != null)
        {
            startUI.SetActive(true); // Show the UI at the start.
            Time.timeScale = 0f;    // Pause the game.
        }
    }

    // Function to close the UI and resume the game.
    public void CloseUI()
    {
        if (startUI != null)
        {
            startUI.SetActive(false); // Hide the UI.
            Time.timeScale = 1f;      // Ensure time resumes.
            isUIActive = false;       // Update the UI state.
            Debug.Log("Ui close");
        }
    }
}
