using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractButton : MonoBehaviour
{
    public GameObject uiElement;  

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(true);  
            
        }
    }

  
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);  
        }
    }
}
