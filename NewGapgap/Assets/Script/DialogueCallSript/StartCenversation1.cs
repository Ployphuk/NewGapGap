using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCenversation1 : MonoBehaviour
{
    [SerializeField] GameObject Tutorials;

    public void OnEnable()
    {
        Tutorials.SetActive(true);
    }
}
