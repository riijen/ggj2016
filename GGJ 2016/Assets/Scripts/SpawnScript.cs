﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SpawnScript : MonoBehaviour
{

    public GameObject obj;
    public string inputAccess = "Fire1";
    public float maxSpawnRate = 1.0f;
    private float timeSinceSpawn;

    void Start()
    {
        timeSinceSpawn = 0;
    }

    private void FixedUpdate()
    {
        timeSinceSpawn += Time.deltaTime;
        bool spawn = CrossPlatformInputManager.GetAxis(inputAccess) > 0;

        if (spawn && timeSinceSpawn >= maxSpawnRate)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
            timeSinceSpawn = 0;
        }
    }
}
