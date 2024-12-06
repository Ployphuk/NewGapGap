using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDialogue : MonoBehaviour
{
    [SerializeField] private GameObject objectToActivate; // Assign the object to activate in the Inspector

    private void OnEnable()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true); // Activate the specified object
        }
    }
}
