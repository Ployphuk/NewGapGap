using UnityEngine;

public class TargetLine : MonoBehaviour
{
    public KeyCode targetKey = KeyCode.Space; 
    public int score = 0; 

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Object in trigger: " + collision.gameObject.name);

        if (collision.CompareTag("Note"))
        {
            if (Input.GetKeyDown(targetKey))
            {
                score++; // Increment score
                Debug.Log("Hit! Score: " + score);
                Destroy(collision.gameObject);
            }
        }
    }

    
}
