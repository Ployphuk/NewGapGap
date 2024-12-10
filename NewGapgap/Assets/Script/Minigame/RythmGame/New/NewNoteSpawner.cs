using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNoteSpawner : MonoBehaviour
{

    public GameObject notePrefab; // Assign your note prefab
    public float spawnInterval = 1f; // Time between spawns
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnNote();
            timer = 0f;
        }
    }

    void SpawnNote()
    {
        Instantiate(notePrefab, transform.position, Quaternion.identity);
    }
}
