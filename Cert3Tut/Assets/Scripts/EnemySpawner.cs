using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float timeBetweenSpawns;
    [SerializeField] GameObject enemyPrefab;
    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= timeBetweenSpawns)
        {
            Spawn();
            spawnTimer = 0;
        }
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
