using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSpin : MonoBehaviour {

    public float speed = 10f, translateSpeed = 10f, modifier = 100;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
        transform.Translate(Vector3.forward *  translateSpeed);
        translateSpeed = translateSpeed * (1 + (modifier + Time.deltaTime)/ 1000);
	}
}
