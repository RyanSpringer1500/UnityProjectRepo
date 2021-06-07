﻿/*
 * (Ryan Springer
 * (Assignment3)
 * spawns in the different balls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public HealthSystem healthSystem;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        StartCoroutine(spawnRandomPrefabCorotine());
    }
    IEnumerator spawnRandomPrefabCorotine()
    {
       // yield return new WaitForSeconds(3.0f);
        while(!healthSystem.gameOver)
        {
            SpawnRandomBall();
            float randomSpawn = Random.Range(3.0f, 5.0f);
            yield return new WaitForSeconds(randomSpawn);

        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int prefabIndex = Random.Range(0, ballPrefabs.Length);
          
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

}
