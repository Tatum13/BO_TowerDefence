using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float damage = 10;

    private void Update()
    {

        if (target)//Als die target(enemy) vind dan moet die erheen.
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);//Beweegt de bullet naar de enemy toe.    
        }
        else//Als die de target(enemy) niet vind dan moet de bullet er niet meer zijn.
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))//zoekt naar de enemytag en als die gevonden is MOEEEEET het damage doen.
        {
            collision.gameObject.GetComponent<EnemyHealthScript>().enemyHealth -= damage;
            Destroy(gameObject);
        }
    }

    


}
