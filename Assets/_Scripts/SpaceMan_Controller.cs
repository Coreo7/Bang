using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMan_Controller : MonoBehaviour {

    public GameObject SpaceMan;
    public Transform SpawnPoint;
    public float GenerationTime = 1;

	// Use this for initialization
	void Start () {
        StartCoroutine(CreateSpaceMan());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CreateSpaceMan()
    {
        yield return new WaitForSeconds(GenerationTime);

        GameObject dude = Instantiate(SpaceMan, SpawnPoint);
        dude.transform.localPosition = Vector3.zero;
        StartCoroutine(CreateSpaceMan());
    }
}
