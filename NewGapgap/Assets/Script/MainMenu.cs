using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Animator transition;
    public GameObject SceneObject;
  
    public void Awake()
    {
        SceneObject.SetActive(false);
    }

    public void StartGame()
    {
        SceneObject.SetActive (true);
        
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel()  // Fixed return type and method name
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        transition.SetTrigger("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
