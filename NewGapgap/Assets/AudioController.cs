using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Awake()
    {
        // Ensure there's only one MusicController instance
        if (FindObjectsOfType<AudioController>().Length > 1)
        {
            Destroy(gameObject); // Destroy extra instances to maintain one persistent music controller
        }
        else
        {
            DontDestroyOnLoad(gameObject); // Keep the MusicController when changing scenes
            audioSource.Play(); // Play the music when the scene starts
        }
    }

    // Optionally, stop the music when exiting the game (useful in the main menu)
    void OnDestroy()
    {
        audioSource.Stop();
    }
}
