using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    // List the scenes where music should NOT play
    public List<string> scenesWithoutMusic = new List<string> { "RotateGame", "RythmGame"};

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
        }
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to the sceneLoaded event
        UpdateMusicStatus(SceneManager.GetActiveScene().name); // Check the current scene
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from the event to avoid memory leaks
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateMusicStatus(scene.name);
    }

    void UpdateMusicStatus(string sceneName)
    {
        if (scenesWithoutMusic.Contains(sceneName))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
        else
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
