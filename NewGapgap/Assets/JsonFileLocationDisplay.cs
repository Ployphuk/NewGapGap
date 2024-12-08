using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonFileLocationDisplay : MonoBehaviour
{
    private string filePath;

    void Start()
    {
        // Get the location of the JSON file
        filePath = Application.persistentDataPath + "/pointsData.json";

        // Show the file path in the Text UI element
        Text filePathText = GetComponent<Text>();
        if (filePathText != null)
        {
            filePathText.text = "JSON file location: " + filePath;
        }
        else
        {
            Debug.LogError("Text component not found on the canvas!");
        }
    }
}
