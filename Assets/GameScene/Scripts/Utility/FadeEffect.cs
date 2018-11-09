using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour {

    private Animator myAnimator;
    private Image myImage;

    void Awake()
    {
        myAnimator = GetComponent<Animator>();
        myImage = GetComponent<Image>();
    }

    public IEnumerator Fading()
    {
        myAnimator.SetBool("Fade", true);
        yield return new WaitUntil(() => myImage.color.a == 1);
        gameObject.SetActive(false);
    }
}
