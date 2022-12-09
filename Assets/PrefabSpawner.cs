using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{

    public List<GameObject> PrefabToSpawn;

    public int prevRandIndex;

    public int beginRandIndex;
    
    public float obstacleSpawnCooldown;

    public bool isSpawning;

    public Transform spawningTransform;
    
    // Start is called before the first frame update
    private void Start()
    {
        StartToSpawning();
    }
    [Button]
    public void StartToSpawning()
    {
        StartCoroutine(SpawningPrefabs());
    }

    IEnumerator SpawningPrefabs()
    {
        var rand = new System.Random();
        var randIndex = rand.Next(0, PrefabToSpawn.Count);
        if (randIndex==prevRandIndex)
        {
            StartCoroutine(SpawningPrefabs());
            yield break;
        }
        prevRandIndex = randIndex;
        while (isSpawning)
        {
            yield return new WaitForSeconds(obstacleSpawnCooldown);
            GameObject spawnedGO = Instantiate(PrefabToSpawn[randIndex],spawningTransform,true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
