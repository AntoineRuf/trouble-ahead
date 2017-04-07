﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour {

    // Use this for initialization
    public float radius = 200.0F;
    public float power = 2.0F;

    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null && !rb.gameObject.Equals(transform.gameObject) && rb.CompareTag("Player"))
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }


// Update is called once per frame
void Update () {
		
	}
}