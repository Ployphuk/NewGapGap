using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartOnAwake : MonoBehaviour
{
    [SerializeField] public NPCConversation dialogue;
    public GameObject ConversationPrefab;

    private static bool hasAwoken = false;

    void Awake()
    {
        if (!hasAwoken)
        {
            hasAwoken = true;
            // Your Awake logic here
            Debug.Log("Awake is called for the first time.");
        }
        else
        {
            Debug.Log("Awake is skipped.");
        }
    }

    private void OnEnable()
    {
        ConversationPrefab.SetActive(true);  // Enable the conversation prefab when the object is activated

        if (ConversationManager.Instance == null)
        {
            Debug.LogError("ConversationManager.Instance is null!");
        }
        else if (dialogue == null)
        {
            Debug.LogError("Dialogue is not assigned!");
        }
        else
        {
            ConversationManager.Instance.StartConversation(dialogue);  // Start the conversation
        }
    }
}
