using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTwitch : MonoBehaviour {

    public float TwitchStrength = 10, Speed = 10;
    public float TimeScale = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.M))
        {
            Twitch();
        }
        Time.timeScale = TimeScale;
        transform.Rotate(Vector3.back, Speed * Time.deltaTime);

    }

    void Twitch()
    {
        Rigidbody rbody = GetComponent<Rigidbody>();

        rbody.AddForce(transform.transform.right * TwitchStrength);//, ForceMode.Impulse);
    }
}
