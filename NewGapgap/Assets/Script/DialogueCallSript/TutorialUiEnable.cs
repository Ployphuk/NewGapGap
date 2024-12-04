using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUiEnable : MonoBehaviour
{
    [SerializeField] GameObject TutorialsUI;

    public void OnActivate()
    {
        TutorialsUI.SetActive(true);
    }
}
