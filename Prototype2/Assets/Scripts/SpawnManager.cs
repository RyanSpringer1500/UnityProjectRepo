/*
 * (Ryan Springer
 * (Assignment3)
 * (spawns in creatures
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    public HealthSystem healthSystem;
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("Health Systems").GetComponent<HealthSystem>();
        //InvokeRepeating("spawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandomPrefabWithCorotine());
    }
    IEnumerator SpawnRandomPrefabWithCorotine()
    {
        yield return new WaitForSeconds(3f);

        while(!healthSystem.gameOver)
        {
            spawnRandomPrefab();
            float randomDelay = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
           //pawnRandomPrefab();
        }
        
    }
    void spawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
