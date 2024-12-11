using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenToggle : MonoBehaviour
{
    public void SetFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
