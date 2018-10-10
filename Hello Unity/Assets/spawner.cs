﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public float spawnRate = 1f;

    public GameObject hexaPrefab;

    private float nextTimeToSpawn = 0f;

	
	// Update is called once per frame
	void Update () {
		if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexaPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
	}
}
