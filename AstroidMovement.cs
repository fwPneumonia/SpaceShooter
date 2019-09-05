using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {
    Rigidbody physic;
    public float velocity;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        physic.velocity = transform.forward * velocity*-1;

    }
}
