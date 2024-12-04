using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractButton : MonoBehaviour
{
    public GameObject uiElement;  // Reference to the UI element

    // This method is called when another collider enters the trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(true);  // Activate the UI element
            
        }
    }

    // This method is called when another collider exits the trigger
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);  // Deactivate the UI element
        }
    }
}
