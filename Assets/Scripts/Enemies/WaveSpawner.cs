using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    private float timer = 0;
    public float delay;
    //public Text waveCountdownText;

    void Start()
    {
        timer = delay;
        //waveCountdownText = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;//Begint met tellen.
        if(timer > delay)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timer = 0.0f;
        }

        //waveCountdownText.text = Mathf.Floor(timer).ToString();
    }



}
