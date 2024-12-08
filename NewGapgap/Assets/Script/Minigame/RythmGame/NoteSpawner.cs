using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnNote", 0f, spawnInterval);
    }

    void SpawnNote()
    {
        Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
    }
}
