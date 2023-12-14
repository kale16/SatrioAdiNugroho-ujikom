using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1f;
    public float spawnRadius = 10f;
    void Start()
    {
        InvokeRepeating("Spawn Enemy", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        Vector3 randomSpawnPosition = transform.position;
    }
}
