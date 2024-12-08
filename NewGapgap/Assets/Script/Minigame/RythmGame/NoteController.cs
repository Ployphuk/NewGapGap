using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public float fallSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        // Destroy the note if it goes below the screen
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
