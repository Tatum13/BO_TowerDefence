using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelHealthScript : MonoBehaviour
{
    public float health = 10;
    public bool gameEnd = false;

    //public Text healthText;

    private void Update()
    {
        if(health <= 0)
        {
            gameEnd = true;
            SceneManager.LoadScene(1);
        }
    }

    
}
