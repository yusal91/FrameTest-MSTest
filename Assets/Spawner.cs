using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemySpawner;



    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }
    void SpawnEnemy()
    {
        for (int i = 0; i < 10000; i++)
        {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
        }
    }
}
