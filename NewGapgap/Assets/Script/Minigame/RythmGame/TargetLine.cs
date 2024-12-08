using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLine : MonoBehaviour
{
    public KeyCode targetKey = KeyCode.Space; // Key to press for this line
    public int score = 0;

    void OnTriggerStay2D(Collider2D collision)
    {
        // Check if the collided object is tagged as "Note"
        if (collision.CompareTag("Notes"))
        {
            // If the player presses the key
            if (Input.GetKeyDown(targetKey))
            {
                // Increase the score
                score++;
                Debug.Log("Hit! Score: " + score);

                // Destroy the note
                Destroy(collision.gameObject);
            }
        }
    }
}
