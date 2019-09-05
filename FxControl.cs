using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControl : MonoBehaviour {

    Rigidbody physic;
    public float velocity;

	void Start ()
    {
        physic = GetComponent<Rigidbody>();
        physic.velocity = transform.forward*velocity;
	}
	
	
	
}
