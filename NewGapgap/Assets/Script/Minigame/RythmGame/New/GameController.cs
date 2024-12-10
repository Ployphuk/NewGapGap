using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Import to load scenes

public class GameController : MonoBehaviour
{
    public Transform hitLine; // The line where notes need to be hit
    public float hitThreshold = 0.5f; // How close the note needs to be to the line to count as a hit
    private int score = 0;
    private int missCount = 0; // Track number of misses

    public TextMeshProUGUI scoreText; // Reference to the Score Text
    public TextMeshProUGUI missText; // Reference to the Miss Text
    public GameObject gameOverScreen; // Reference to the Game Over UI screen

    void Start()
    {
        UpdateScoreText(); // Initialize the score display
        UpdateMissText();  // Initialize the miss display
        gameOverScreen.SetActive(false); // Hide the game over screen initially
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckHit();
        }

        CheckMiss();
    }

    void CheckHit()
    {
        // Find the nearest note to the hit line
        GameObject[] notes = GameObject.FindGameObjectsWithTag("Note");

        foreach (GameObject note in notes)
        {
            float distance = Mathf.Abs(note.transform.position.y - hitLine.position.y);

            if (distance <= hitThreshold)
            {
                // Update score and remove note
                score++;
                Debug.Log("Hit! Score: " + score);

                Destroy(note);
                UpdateScoreText(); // Update the displayed score
                return;
            }
        }
    }

    void CheckMiss()
    {
        // Check if any note has passed the hit line without being hit
        GameObject[] notes = GameObject.FindGameObjectsWithTag("Note");

        foreach (GameObject note in notes)
        {
            if (note.transform.position.y < hitLine.position.y)
            {
                missCount++;
                Debug.Log("Miss! Note passed the line without being hit");

                Destroy(note); // Optional: Remove the note from the scene if it passes the line
                UpdateMissText(); // Update the displayed miss count

                if (missCount >= 5)
                {
                    GameOver();
                }
            }
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Update the text
    }

    void UpdateMissText()
    {
        missText.text = "Misses: " + missCount; // Update the text
    }

    void GameOver()
    {
        gameOverScreen.SetActive(true); // Show the game over UI
        Time.timeScale = 0; // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // Resume the game
        missCount = 0;
        score = 0;
        UpdateScoreText();
        UpdateMissText();
        gameOverScreen.SetActive(false); // Hide the game over UI
    }
}
