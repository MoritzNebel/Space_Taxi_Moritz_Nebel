﻿using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.8f, 0);

    public GameObject bulletPrefab;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;

    void Update()
    {
        cooldownTimer -= 0.01f;

        if ( cooldownTimer <= 0)
        {
			cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = gameObject.layer;
        }
    }
}
