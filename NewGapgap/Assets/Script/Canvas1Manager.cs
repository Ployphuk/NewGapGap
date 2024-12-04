using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas1Manager : MonoBehaviour
{
    [SerializeField] GameObject CutScene1;

    // Start is called before the first frame update

    public void OnEnable()
    {
        CutScene1.SetActive(false);
    }

}
