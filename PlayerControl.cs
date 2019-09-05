using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Rigidbody physic;
    float horizontal=0;
    float vertical=0;
    public float characterVelocity;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float eğim;
    float fireTime = 0;
    //time required to shoot
    public float timeReqtoShoot;
    public GameObject Bullet;
    public Transform bulletComeFrom;
    AudioSource audio;
            
	void Start ()
    {
        physic = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();

	}
     void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>fireTime) 
        {
            fireTime = Time.time + timeReqtoShoot;
            Instantiate(Bullet, bulletComeFrom.position, Quaternion.identity);
            audio.Play();

        }
        
    }


    void FixedUpdate ()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 vec = new Vector3(horizontal, 0, vertical);
        physic.velocity = vec*characterVelocity;
        physic.position = new Vector3(Mathf.Clamp(physic.position.x,minX,maxX), 0, Mathf.Clamp(physic.position.z,minZ,maxZ));
        physic.rotation = Quaternion.Euler(0, 0, physic.velocity.x*-eğim);


        
	}
}
