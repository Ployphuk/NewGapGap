using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFadeAnimation : MonoBehaviour
{
    [SerializeField] Animator FadeAnim;
    [SerializeField] GameObject FadeObject;
    [SerializeField] GameObject Dialogue;
    public GameObject NextScene;
   
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
        Dialogue.SetActive(false);
        NextScene.SetActive(true);
    }
}
