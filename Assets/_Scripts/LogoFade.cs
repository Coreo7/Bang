using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class LogoFade : MonoBehaviour {

    CanvasGroup canvas;
	// Use this for initialization
	void Start () {
        canvas = GetComponent<CanvasGroup>();
        StartCoroutine(fadeCanvas());
	}
	
    IEnumerator fadeCanvas()
    {
        print("In Coroutine");
        yield return new WaitForSecondsRealtime(10);
        print("Fading Out");
        canvas.DOFade(0, 2);

        yield return new WaitForSecondsRealtime(600);

        canvas.DOFade(1, 2);

        fadeCanvas();
    }
}
