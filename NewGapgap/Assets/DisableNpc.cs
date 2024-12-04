using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableNpc : MonoBehaviour
{
    [SerializeField] GameObject npc;
    public void SetEnable()
    {
        npc.SetActive(false);
    }
}
