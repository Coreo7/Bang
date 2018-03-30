using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCrasher : MonoBehaviour {

    public float KillTimer = 15;
    public bool OverrideKill = false;
	// Use this for initialization
	void Start () {
        StartCoroutine(WarpCrasher());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WarpCrasher()
    {
        yield return new WaitForSeconds(KillTimer);
        if(!OverrideKill)
        {
            Destroy(gameObject);

        }
    }
}
