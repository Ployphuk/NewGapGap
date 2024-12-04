using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    public GameObject circlePrefab;
    public RectTransform canvasRect;
    public float circleLifetime = 10f; // Time in seconds before the circle is destroyed


    public GameObject CircleSpawner()
    {
        RectTransform circleRect = circlePrefab.GetComponent<RectTransform>();
        Vector2 circleSize = circleRect.sizeDelta;

        // Calculate the bounds for spawning positions
        Vector2 minBounds = canvasRect.rect.min + circleSize / 2;
        Vector2 maxBounds = canvasRect.rect.max - circleSize / 2;

        // Random position within the bounds
        Vector2 randomPosition = new Vector2(
            Random.Range(minBounds.x, maxBounds.x),
            Random.Range(minBounds.y, maxBounds.y)
        );

        // Instantiate the circle
        GameObject newCircle = Instantiate(circlePrefab, canvasRect);
        newCircle.GetComponent<RectTransform>().anchoredPosition = randomPosition;

        // Start a coroutine to destroy the circle after a set time
        StartCoroutine(DestroyAfterTime(newCircle, circleLifetime));

        return newCircle;
    }

    private System.Collections.IEnumerator DestroyAfterTime(GameObject circle, float time)
    {
        yield return new WaitForSeconds(time);
        if (circle != null)
        {
            Destroy(circle);
            // Notify the GameManager to spawn a new circle
            CircleClickManager circleClickManager = FindObjectOfType<CircleClickManager>();
            if (circleClickManager != null)
            {
                circleClickManager.SpawnNewCircle(); // Ensure GameManager spawns a new circle
            }
        }
    }

}
