using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealthScript : MonoBehaviour
{
    public float mainHealth = 100;
    void Start()
    {
        
    }


    void Update()
    {
        if(mainHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
