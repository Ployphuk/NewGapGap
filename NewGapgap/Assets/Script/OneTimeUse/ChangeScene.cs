using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int SceneNumber; // Index of the scene to load

    public void ChangeNewScene()
    {
        if (SceneNumber >= 0 && SceneNumber < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneNumber); // Load the scene directly using the specified index
        }
        else
        {
            Debug.LogError("Invalid scene number. Ensure the scene is added to the Build Settings and the number is correct.");
        }
    }
}
