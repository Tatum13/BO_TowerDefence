using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    public float enemyHealth = 100;

    private WaveSpawner newEnemyCounter;

    private void Start()
    {
        newEnemyCounter = GameObject.FindWithTag("Spawn").GetComponent<WaveSpawner>();
    }
    void Update()
    {
        if(enemyHealth <= 0)
        {
            newEnemyCounter.enemyCounter--;
            Destroy(gameObject);
        }
    }
}
