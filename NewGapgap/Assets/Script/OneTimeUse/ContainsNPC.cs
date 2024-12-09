using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainsNPC : MonoBehaviour
{
    public GameObject Npc1;
    public GameObject Npc2;

    public void OnEnable()
    {
        Npc1.SetActive(false);
        Npc2.SetActive(false);
    }
}
