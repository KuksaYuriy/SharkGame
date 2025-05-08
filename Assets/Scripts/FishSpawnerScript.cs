using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnerScript : MonoBehaviour
{
    public float spawnTime = 10f;

    public float minX = -20f;
    public float maxX = 313f;
    public float minY = 17f;
    public float maxY = -10f;

    public GameObject fish;
    void Start()
    {
        StartCoroutine(SpawnFish());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnFish() 
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            float spawnX = Random.Range(minX, maxX);
            float spawnY = Random.Range(minY, maxY);
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
            Instantiate(fish, spawnPos, transform.rotation);
        }
    }
} 