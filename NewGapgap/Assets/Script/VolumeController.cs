using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // The slider in the UI
    private AudioSource audioSource;

    private void Start()
    {
        // Find the AudioController's AudioSource
        AudioController audioController = FindObjectOfType<AudioController>();
        if (audioController != null)
        {
            audioSource = audioController.audioSource;
        }

        // Set initial slider value
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f); // Get saved volume or default to 1
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            // Set the audio volume
            audioSource.volume = volume;
            // Save the volume setting
            PlayerPrefs.SetFloat("Volume", volume);
        }
    }

    private void OnDestroy()
    {
        if (audioSource != null)
        {
            // Save the volume setting when the object is destroyed
            PlayerPrefs.SetFloat("Volume", audioSource.volume);
        }
    }
}
