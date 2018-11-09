using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffSetSroller : MonoBehaviour {

    public float scrollSpeed;
    private Vector2 savedOffSet;

    public bool startMoving;

	void Start () {
        savedOffSet = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	void Update () {
        if (startMoving == true)
        {
            float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
            Vector2 offSet = new Vector2(x, 0);
            GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offSet);

        }
        

	}

    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffSet);

    }
}
