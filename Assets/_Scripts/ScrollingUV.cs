using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingUV : MonoBehaviour {

    public Vector2 uvAnimateRate = new Vector2(1f, 0);

    int materialIndex = 0;
    string textureName = "_MainTex";

    Vector2 uvOffset = Vector2.zero;
	
	// Update is called once per frame
	void LateUpdate ()
    {
        uvOffset += (uvAnimateRate * Time.deltaTime);
        GetComponent<Renderer>().materials[materialIndex].SetTextureOffset(textureName, uvOffset);
	}
}
