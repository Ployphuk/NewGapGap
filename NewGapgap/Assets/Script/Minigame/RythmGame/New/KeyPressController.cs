using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressController : MonoBehaviour
{
    public KeyCode keyA = KeyCode.A;
    public KeyCode keyS = KeyCode.S;
    public KeyCode keyJ = KeyCode.J;
    public KeyCode keyK = KeyCode.K;

    public Transform targetA, targetS, targetJ, targetK; // Positions to detect overlap
    public LayerMask noteLayer;

    void Update()
    {
        if (Input.GetKeyDown(keyA)) CheckKeyPress(targetA);
        if (Input.GetKeyDown(keyS)) CheckKeyPress(targetS);
        if (Input.GetKeyDown(keyJ)) CheckKeyPress(targetJ);
        if (Input.GetKeyDown(keyK)) CheckKeyPress(targetK);
    }

    void CheckKeyPress(Transform target)
    {
        Collider2D note = Physics2D.OverlapCircle(target.position, 0.5f, noteLayer);

        if (note != null)
        {
            Destroy(note.gameObject); // Hit success
            Debug.Log("Point Scored!");
        }
        else
        {
            Debug.Log("Miss!");
        }
    }
}
