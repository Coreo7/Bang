using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LasunchAstronaut : MonoBehaviour {

    public float LaunchInterval, LaunchStrength;
    public GameObject AstroMan, CannonOne, CannonTwo;

    InteralTimer timer;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(StartLaunch());
        //Physics.gravity = new Vector3(0, 1f, 0);
    }

    IEnumerator StartLaunch()
    {
        yield return new WaitForSeconds(LaunchInterval);
        LaunchAstroMan();
        StartCoroutine(StartLaunch());
    }

    private void Update()
    {

    }

    void LaunchAstroMan()
    {
        List<GameObject> obj = new List<GameObject>(); 
        obj.Add(Instantiate(AstroMan, CannonOne.transform));
        obj.Add(Instantiate(AstroMan, CannonTwo.transform));

     //   Debug.Log(obj.Count);
        foreach(GameObject g in obj)
        {
         //   Debug.Log("Firing");
            Rigidbody[] rbody = g.GetComponentsInChildren<Rigidbody>();
          //  Debug.Log(rbody.Length);
            
            foreach(Rigidbody r in rbody)
            {
                r.AddForce(g.transform.transform.forward * LaunchStrength);//, ForceMode.Impulse);
            }
        }
    }
}
