using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckActivate : MonoBehaviour
{
    [SerializeField] private GameObject objectToCheck; // The object to check if it's active
    [SerializeField] private GameObject objectToActivate; // The object to activate if the first is not active

    private const string activationKey = "ObjectAActivated"; // Key for PlayerPrefs

    void Start()
    {
        // Check if the action has already been executed by reading the PlayerPrefs
        if (!PlayerPrefs.HasKey(activationKey))
        {
            // If not, proceed with the activation
            ActivateObject();
        }
    }

    void ActivateObject()
    {
        // If the first object is not active
        if (!objectToCheck.activeInHierarchy)
        {
            // Activate the second object
            objectToActivate.SetActive(true);
            Debug.Log($"{objectToActivate.name} has been activated.");

            // Save the state to PlayerPrefs so it doesn't happen again
            PlayerPrefs.SetInt(activationKey, 1);
            PlayerPrefs.Save(); // Make sure it's saved
        }
    }
}
