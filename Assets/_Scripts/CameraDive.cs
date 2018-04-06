using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDive : MonoBehaviour {

    public float Speed = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, Speed * Time.deltaTime);
    }
}
