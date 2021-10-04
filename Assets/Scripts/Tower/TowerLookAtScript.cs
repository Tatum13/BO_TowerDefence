using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLookAtScript : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        Vector3 direction = target.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}
