using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDialogue : MonoBehaviour
{
    [SerializeField] GameObject Dialogue;
   public void DisActivate()
    {
       Dialogue.SetActive(false);
    }
}
