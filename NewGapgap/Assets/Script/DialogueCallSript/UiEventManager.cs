using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiEventManager : MonoBehaviour
{
    [SerializeField] GameObject tutorialsUi;

    public void Activate()
    {

        Debug.Log("Enable Ui");
        tutorialsUi.SetActive(true);
    }
}
