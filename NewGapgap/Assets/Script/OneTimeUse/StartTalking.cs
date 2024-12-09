using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTalking : MonoBehaviour
{
    [SerializeField] private GameObject dialogueCanvas;
    private bool playerInRange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueCanvas.SetActive(true);
        }
    }
}
