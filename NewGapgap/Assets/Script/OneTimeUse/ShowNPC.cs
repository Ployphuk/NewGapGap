using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNPC : MonoBehaviour
{
    [SerializeField] GameObject Npc;

    public void OnEnable()
    {
        Npc.SetActive(true);
    }
}
