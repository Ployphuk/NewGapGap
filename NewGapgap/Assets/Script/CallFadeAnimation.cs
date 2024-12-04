using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFadeAnimation : MonoBehaviour
{
    [SerializeField] Animator FadeAnim;
   
   public void StartAnimation()
    {
        StartCoroutine(CallAnimation());
    }

    IEnumerator CallAnimation()  // Fixed return type and method name
    {
        FadeAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        FadeAnim.SetTrigger("Start");
    }
}
