using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;  // Reference to the RhythmNote prefab
    public float spawnInterval = 2f;  // Time interval between spawns

    void Start()
    {
        InvokeRepeating("SpawnNote", 2f, spawnInterval);  // Start spawning notes after 2 seconds, then repeat at intervals
    }

    void SpawnNote()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 6f, 0);  // Random horizontal position, fixed vertical position off-screen
        GameObject note = Instantiate(notePrefab, spawnPosition, Quaternion.identity);  // Instantiate a new note

        // Set random fall speed for the note
        note.GetComponent<NoteController>().fallSpeed = Random.Range(3f, 7f);
    }
}
