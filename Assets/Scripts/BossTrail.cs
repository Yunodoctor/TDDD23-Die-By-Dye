﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrail : MonoBehaviour {

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject[] Trail;
    private BossController Boss;

    void Start ()
    {
        Boss = GetComponent<BossController>();
	}

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, Trail.Length);
            GameObject instance = (GameObject)Instantiate(Trail[rand], transform.position, Quaternion.identity);
            Destroy(instance, 12f);

            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
