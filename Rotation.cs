using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    Rigidbody physic;
    public float velocity;
	// Use this for initialization
	void Start ()
    {
        physic = GetComponent<Rigidbody>();
        physic.angularVelocity = Random.insideUnitSphere*velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
