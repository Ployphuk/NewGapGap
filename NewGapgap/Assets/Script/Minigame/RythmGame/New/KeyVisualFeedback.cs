using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyVisualFeedback : MonoBehaviour
{
    public KeyCode key;
    public GameObject buttonSprite;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            StartCoroutine(FlashButton());
        }
    }

    IEnumerator FlashButton()
    {
        buttonSprite.GetComponent<SpriteRenderer>().color = Color.gray;
        yield return new WaitForSeconds(0.1f);
        buttonSprite.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
