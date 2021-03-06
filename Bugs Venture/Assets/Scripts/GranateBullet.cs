﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranateBullet : MonoBehaviour {

    //Public
    public float bulletSpeed = 10f;
    public GameObject GranateParticle;

    //Private
    private Rigidbody RigidBody;

    void Start()
    {
        RigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        Destroy(this.gameObject, 2);
    }
    void OnCollisionEnter(Collision col)
    {
        Instantiate(GranateParticle, this.transform.position, Quaternion.Euler(new Vector3(-90, 90, 0)));
        Destroy(this.gameObject);
    }
}
