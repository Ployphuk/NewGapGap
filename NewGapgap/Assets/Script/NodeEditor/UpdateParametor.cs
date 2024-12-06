using UnityEngine;
using DialogueEditor;

public class UpdateParametor : MonoBehaviour
{
    public void OnDialogueEnd()
    {
        // Check if the ConversationManager instance is available
        if (ConversationManager.Instance != null)
        {
            // Get the "HasCompletedDialogue" parameter to see if it's true
            bool hasCompletedDialogue = ConversationManager.Instance.GetBool("HasCompletedDialogue");

            // Log the message if the condition is met
            if (hasCompletedDialogue)
            {
                Debug.Log("The dialogue has ended, and the condition is met.");
            }
        }
        else
        {
            Debug.LogError("ConversationManager.Instance is not available.");
        }
    }
}
