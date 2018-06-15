using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colorful;
using DG.Tweening;

public class EffectsController : MonoBehaviour {

    public Colorful.Wiggle Wiggler;
    public Colorful.AnalogTV AVSet;

    public float RandomTime, UpperBounds, LowerBounds;

    public float MaxWiggle, MinWiggle;

    public float NormalTime = 45;
	// Use this for initialization
	void Start () {
        Debug.Log("Wigglin");
        RestartWiggler();
	}
	
	// Update is called once per frame
	void Update () {
        print(Wiggler.Amplitude);
	}

    IEnumerator ChangeDaWiggle()
    {
        RandomTime = Random.Range(LowerBounds, UpperBounds);
        float wiggle = Random.Range(MinWiggle, MaxWiggle);
        DOTween.To(() => Wiggler.Amplitude, x => Wiggler.Amplitude = x, wiggle, 10);
        yield return new WaitForSeconds(RandomTime);

        normalize();
    }

    void RestartWiggler()
    {

        StartCoroutine(ChangeDaWiggle());
    }

    void normalize()
    {
        print("Goining normal");
        DOTween.To(() => Wiggler.Amplitude, x => Wiggler.Amplitude = x, -.03f, 3);

        StartCoroutine(GoNormal());
    }

    IEnumerator GoNormal()
    {
        yield return new WaitForSeconds(NormalTime);
        RestartWiggler();
    }
}
