using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamageScript : MonoBehaviour
{
    public float damage = 10;

    public MainHealthScript mainBuildingHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainBuilding")
        {
            mainBuildingHealth.mainHealth -= damage;
        }
    }
}
