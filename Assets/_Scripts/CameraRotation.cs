using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    public float SpaceSpeed = 1;
    public float Speed2 = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back, SpaceSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, Speed2 * Time.deltaTime);
    }
}
