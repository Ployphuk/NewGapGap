using UnityEngine;
using UnityEngine.Video;

public class VideoEndHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer
    public GameObject videoUI;      // Reference to the UI Panel or RawImage
    public GameObject dialogue;

    void Start()
    {
        // Subscribe to the loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Hide the video UI when the video ends
        videoUI.SetActive(false);
        dialogue.SetActive(true);
    }

    void OnDestroy()
    {
        // Unsubscribe from the event to prevent memory leaks
        videoPlayer.loopPointReached -= OnVideoEnd;
    }
}
