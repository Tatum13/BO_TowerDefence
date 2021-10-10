using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLookAtScript : MonoBehaviour
{
    private GameObject target;
    public GameObject bullet;
    public float radius;
    public float reloadTime;
    private float timer;


    void Start()
    {
        timer = reloadTime; //Timer begint op 0.
    }

    public void Update()
    {
        if (target)
        {
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);//Geeft de positie aan van enemy.
            transform.LookAt(targetPosition);//Kijkt naar de positie van enemy.
            timer += Time.deltaTime;//Als die naar de enemy kijkt start de timer.
            if (timer > reloadTime)//Wanneer het timer groter is dan de delay.
            {
                GameObject aBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                aBullet.GetComponent<BulletScript>().target = target;//Dat de target(enemy) van de tower hetzelfde is als die van de bullet.
                timer = 0.0f;
            }

            if(Vector3.Distance(transform.position, target.transform.position) > radius)
            {
                target = null; //Wanneer de enemy buiten range is dan word de target naar niks gezet "null" want hij kan het niet vinden, dus heeft geen target.
            }
        }

        else
        {
            FindTargetInRange(); //Wanneer die geen target(enemy) heeft dan moet die daar naar opzoek.
        }
    }

    void FindTargetInRange()//Zoekt naar alle colliders binnen de radius met de tag Enemy en daar kijkt die dan naar.
    {
        Collider[] enemiesInRange = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider anEnemy in enemiesInRange)//Voor elke collider in de sphere moet hij er naar kijken.
        {
            if (anEnemy.CompareTag("Enemy"))//Hier moet die alleen zoeken naar een collider met als tag 'Enemy'.
            {
                target = anEnemy.gameObject;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);//Tekent een sphere zonder inhoud vandaar de 'Wire'.
    }

}
