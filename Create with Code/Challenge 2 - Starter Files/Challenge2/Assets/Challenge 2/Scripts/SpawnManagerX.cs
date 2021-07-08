﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    public float timer;

    private float minTime = 1.5f;
    private float maxTime = 6.0f;

    public float spawnTimeInterval;
    private float startDelay = 2.0f;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimeInterval = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        timer += timer.deltaTime;
        //spawnTimeInterval = Random.Range(minTime, maxTime);
        if (timer > spawnTimeInterval)
        {
            //call function
            SpawnRandomBall();
            //reset timer and spawn interval
            spawnTimeInterval = Random.Range(minTime, maxTime);
            timer = 0;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}