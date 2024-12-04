using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCheck : MonoBehaviour
{
    void Start()
    {
        Debug.Log("UiEventManager is attached to: " + gameObject.name);
    }
}
