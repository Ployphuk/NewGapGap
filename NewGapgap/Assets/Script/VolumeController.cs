using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your audio source (e.g., background music)
    public Slider volumeSlider; // The slider in the UI

    private void Start()
    {
        // Set initial slider value
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f); // Get saved volume or default to 1
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        // Set the audio volume
        audioSource.volume = volume;
        // Save the volume setting
        PlayerPrefs.SetFloat("Volume", volume);
    }

    private void OnDestroy()
    {
        // Save the volume setting when the object is destroyed (e.g., when changing scenes)
        PlayerPrefs.SetFloat("Volume", audioSource.volume);
    }
}
