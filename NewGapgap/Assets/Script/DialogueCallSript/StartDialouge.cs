using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartDialouge : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogueTest;
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
            ConversationManager.Instance.StartConversation(dialogueTest);
        }
    }
}
