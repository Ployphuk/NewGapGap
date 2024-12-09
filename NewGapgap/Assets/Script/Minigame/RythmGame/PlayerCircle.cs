using UnityEngine;
using UnityEngine.UI;

public class PlayerCircle : MonoBehaviour
{
    public float radius = 0.5f;  // The radius to check for hits
    public LayerMask noteLayer;  // The layer where notes are located
    //public Text scoreText;  // Reference to the UI text displaying the score

    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Check for left mouse button press
        {
            CheckHit();
        }
    }

    void CheckHit()
    {
        // Create a ray from the player circle position towards the screen
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, noteLayer);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("RhythmNote"))
            {
                Destroy(hit.collider.gameObject);  // Destroy the note
                score++;  // Increase score
                UpdateScoreText();  // Update UI
            }
        }
    }

    void UpdateScoreText()
    {
        //scoreText.text = "Score: " + score;
    }
}
