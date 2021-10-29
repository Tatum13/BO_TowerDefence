using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDoDamageScript : MonoBehaviour
{
    public float damage = 1f;

   [SerializeField] private LevelHealthScript levelHealth;


    private void Start()
    {
        levelHealth = FindObjectOfType<LevelHealthScript>();
        //livesText = livesText.gameObject.GetComponent<Text>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EndTile")
        {
            Debug.Log("aaaaaaaaaaaaaaaaa");
            levelHealth.health -= damage;//Haalt de health er wel vanaf maar laat dat niet zien in de UI.
        }
    }

    private void Update()
    {
        //livesText.text = "Lives: " + levelHealth.health; //Zou de current health moeten laten zien.
    }
}
