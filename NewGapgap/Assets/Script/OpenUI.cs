using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    // Reference to the canvases
    [SerializeField] private GameObject Closecanvas;
    [SerializeField] private GameObject Opencanvas;

    // Method to be called when the button is clicked
    public void ShowCanvas2()
    {
        // Deactivate the first canvas and activate the second one
        Closecanvas.SetActive(false);
        Opencanvas.SetActive(true);
    }
}
