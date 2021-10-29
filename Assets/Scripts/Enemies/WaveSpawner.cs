using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    //public Transform SpawnPoint;

    //private float timer = 0;
    private float countdown = 5;
    private float resetTimer = 10f;
    //private float delayEnemies = 1f;
    //public float delay;

    public int waveNumber = 0;
    public int enemyCounter;
    //public int enemyAmount;

    public Text waveCountdownText;
    public Text waveAmount;

    public Wave[] waves;
    private LevelHealthScript levelHealth;
    void Start()
    {
        //timer = delay;
        //delayEnemies += Time.deltaTime;
        levelHealth = GameObject.FindWithTag("EndTile").GetComponent<LevelHealthScript>();
        waveCountdownText = waveCountdownText.gameObject.GetComponent<Text>();
        waveAmount = waveAmount.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        //delayEnemies -= Time.deltaTime; //Tijd tussen spawnen de enemies.
        //timer += Time.deltaTime;//Begint met tellen naar tijd van delay vul je in in de inspector.
        /*if(timer > delay)
        {
            //Instantiate(enemyPrefab, transform.position, Quaternion.identity);//Maakt de enemy aan.
            timer = 0.0f;
        }*/
        waveCountdownText.text = Mathf.Floor(countdown).ToString();//Zorgt ervoor dat het nummer afgerond word met floor en dat die naar een string gaat.
        waveAmount.text = "Wave: " + Mathf.Floor(waveNumber).ToString();
        if (enemyCounter <= -1)
        {
            enemyCounter = 0;
        }

        if (enemyCounter > 0)
        {
            return;
        }

        if (countdown <= 0)
        {
            if (levelHealth.gameEnd == true)
            {
                return;
            }
            StartCoroutine(Delay());
            countdown = resetTimer;//zet de timer weer naar 5.
            return;
        }
        countdown -= Time.deltaTime; //gaan secondes van de timer af in de UI.

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        
        /*
        void SpawnWave()
        {
            if (enemyPrefab)
            {
                enemyCounter += 1;
            }

            for (int i = 0; i < waveNumber; i++)
            {
                SpawnEnemy();//Elke wave komt er een extra enemy bij.
            }

            waveNumber++;//Dat het het wavenummer opteld
            Debug.Log(waveNumber);
        }*/


    }
        IEnumerator Delay()
        {
            Wave wave = waves[waveNumber];
            for (int i = 0; i <  wave.count / wave.enemy.Length; i++)//deze spawned de wave array
            {
                for (int j = 0; j < wave.enemy.Length; j++)// Deze spawned de enemy array.
                {
                    SpawnEnemy(wave.enemy[j]);
                    yield return new WaitForSeconds(1f / wave.rate);
                }
            }
            waveNumber++;
        }
        void SpawnEnemy(GameObject enemy)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);//Maakt de enemy aan
            enemyCounter++;
        }
}
