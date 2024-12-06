using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNpc : MonoBehaviour
{
    [SerializeField] GameObject npc;
   public void SetEnable()
    {
        npc.SetActive(true);
    }
}
