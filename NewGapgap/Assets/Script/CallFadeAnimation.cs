using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFadeAnimation : MonoBehaviour
{
    [SerializeField] Animator FadeAnim;
    [SerializeField] GameObject FadeObject;
    [SerializeField] GameObject CloseDialogue;
    public GameObject OpenNextScene;
   
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
        CloseDialogue.SetActive(false);
        OpenNextScene.SetActive(true);
    }
}
