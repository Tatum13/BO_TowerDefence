using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManagerScript : MonoBehaviour
{
    public static BuildManagerScript instance;
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;

    private void Awake()
    {
        if (instance != null)//
        {
            Debug.Log("CAN'T BUILD HERE");
            return;
        }
        instance = this;//Hoeft maar 1 keer opgestart te worden? 
    }

    private void Start()
    {
        turretToBuild = standardTurretPrefab; //Moet de tower prefab op staan.
    }

    public GameObject GetTurrentToBuild()
    {
        return turretToBuild;
    }

}
