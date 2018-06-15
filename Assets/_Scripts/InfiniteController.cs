using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colorful;

public class InfiniteController : MonoBehaviour {

    public AnalogTV analogTv;
    public float Speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        analogTv.ScanlinesOffset = Time.time * Speed;
	}
}
