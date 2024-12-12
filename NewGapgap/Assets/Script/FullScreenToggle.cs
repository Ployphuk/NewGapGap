using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenToggle : MonoBehaviour
{
    public Toggle FToggle;
    void Awake()
    {
        if (Screen.fullScreen == true)
        {
            FToggle.isOn = true;
        }
        else
        {
            FToggle.isOn = false;
        }
    }
    public void SetFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
