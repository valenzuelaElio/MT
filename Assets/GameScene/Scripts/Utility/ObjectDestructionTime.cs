using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestructionTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 10.0f);
	}
	
}
