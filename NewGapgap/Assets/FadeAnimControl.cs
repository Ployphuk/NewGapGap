using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnimControl : MonoBehaviour
{
    [SerializeField] Animator transition;
    [SerializeField] GameObject canvasToDeactivate; // Assign your canvas in the Inspector

    // This method will be triggered when the button is pressed
    public void StartFade()
    {
        transition.SetTrigger("Start");
        OnFadeComplete();
    }

    // This method will be called by the Animation Event when the fade animation ends
    public void OnFadeComplete()
    {
        canvasToDeactivate.SetActive(false); // Deactivate the canvas
    }
}
