using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    public FishSpawnerScript fishSpawnerScript;
    public GameObject coin;
    public float timeBetweenSpawn = 25f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    void Start()
    {
        minX = fishSpawnerScript.minX;
        maxX = fishSpawnerScript.maxX;
        maxY = fishSpawnerScript.maxY;
        minY = fishSpawnerScript.minY;

        StartCoroutine(SpawnCoin());
    }

    IEnumerator SpawnCoin() 
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenSpawn);
            float spawnX = Random.Range(minX, maxX);
            float spawnY = Random.Range(minY, maxY);
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
            Instantiate(coin, spawnPos, transform.rotation);
        }
    }
}
