using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToDialogue : MonoBehaviour
{
    [SerializeField] GameObject Ui;

    public void DisenableUi()
    {
        Ui.SetActive(false);
    }
}
