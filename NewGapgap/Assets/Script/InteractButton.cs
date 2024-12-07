using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    public GameObject uiElement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (uiElement != null)
            {
                uiElement.SetActive(true); 
            }
            else
            {
                Debug.LogWarning("uiElement is null! Make sure it is assigned in the Inspector.");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (uiElement != null)
            {
                uiElement.SetActive(false);
            }
            else
            {
                Debug.LogWarning("uiElement is null! It might have been destroyed.");
            }
        }
    }
}
