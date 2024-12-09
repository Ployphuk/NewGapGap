using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScene : MonoBehaviour
{
    [SerializeField] Animator FadeAnim;
    [SerializeField] GameObject FadeObject;

    public void StartAnimation()
    {
        FadeObject.SetActive(true);
        StartCoroutine(CallAnimation());
    }

    IEnumerator CallAnimation()  // Fixed return type and method name
    {
        FadeAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        FadeAnim.SetTrigger("Start");
        FadeObject.SetActive(false);

    }
}
