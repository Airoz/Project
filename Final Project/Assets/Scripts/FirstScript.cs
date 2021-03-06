﻿using UnityEngine;
using System.Collections;

public class FirstScript : MonoBehaviour
{

    public float speed = 20.0f;
    public Rigidbody projectile;

	// Use this for initialization
	void Start ()
    {
	


	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetButtonDown("Fire1"))
        {

            Rigidbody instantiateProjectile = Instantiate(projectile,transform.position,transform.rotation) as Rigidbody;
            instantiateProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Debug.Log("Firing");
            
        }
        
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "terrain")
        {
            DestroyObject(other.gameObject);
        }
    }

}