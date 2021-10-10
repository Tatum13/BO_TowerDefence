using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    private float timer = 0;
    public float delay;

    void Start()
    {
        timer = delay;
    }

    void Update()
    {
        timer += Time.deltaTime;//Begint met tellen.
        if(timer > delay)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timer = 0.0f;
        }
    }



}
