using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearWithContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject shipExplosion;
    GameObject GameControl;
    GameControl control;
    void Start()
    {
        GameControl = GameObject.FindGameObjectWithTag("gamecontrol");
        control = GameControl.GetComponent<GameControl>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "sınır" && other.tag != "gemi") 
        {
            Destroy(other.gameObject);

            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            control.increaseScore(10);
        }
        if (other.tag == "gemi" && other.tag !="sınır")
        {
            Destroy(other.gameObject);

            Destroy(gameObject);
            Instantiate(shipExplosion, other.transform.position, other.transform.rotation);
            control.gameOver();

        }

    }
}
