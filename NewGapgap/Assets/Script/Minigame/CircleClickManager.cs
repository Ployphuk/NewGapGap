using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleClickManager : MonoBehaviour
{
    public int points = 0;
    public int pointsToWin = 10;
    public Text pointsText;
    public SpawnCircle spawnCircle;

    public GameObject startButton;
    public GameObject gameUI;
    public GameObject gameOverPanel;
    public GameObject WinUI;

    private GameObject currentCircle;
    private bool gameStarted = false;

    void Start()
    {
        startButton.SetActive(true);
        gameUI.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        gameUI.SetActive(true);
        gameOverPanel.SetActive(false);
        gameStarted = true;
        points = 0;
        pointsText.text = "Points: " + points;
        SpawnNewCircle();
    }

    public void CircleClicked()
    {
        if (!gameStarted) return;

        points++;
        pointsText.text = "Points: " + points;

        if (currentCircle != null)
        {
            Destroy(currentCircle);
        }

        if (points >= pointsToWin)
        {
            WinGame();
        }
        else
        {
            SpawnNewCircle(); // Spawn a new circle
        }
    }

    public void SpawnNewCircle()
    {
        if (currentCircle != null)
        {
            Destroy(currentCircle);
        }

        currentCircle = spawnCircle.CircleSpawner();
        Button circleButton = currentCircle.GetComponent<Button>();
        circleButton.onClick.RemoveAllListeners(); // Remove any previous listeners
        circleButton.onClick.AddListener(CircleClicked);
    }

    public void WinGame()
    {
        Debug.Log("Win");

        gameOverPanel.SetActive(true);
        Debug.Log("gameOverPanel Active Status: " + gameOverPanel.activeSelf);

        //gameUI.SetActive(false);
        gameStarted = false;
    }
}
