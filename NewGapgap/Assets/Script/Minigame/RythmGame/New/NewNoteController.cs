using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNoteController : MonoBehaviour
{
    public float speed = 5f; // Speed of the note falling

    void Update()
    {
        // Move the note downward
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Destroy the note if it goes out of bounds
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}