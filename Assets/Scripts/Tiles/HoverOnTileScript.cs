using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOnTileScript : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;
    public bool hoverTheColor;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("This can't build there");
            return;
        }
        GameObject turretToBuild = BuildManagerScript.instance.GetTurrentToBuild();//Instantieerd de turret(tower).
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);//Plaatst de turret(tower prefab).

    }

    void OnMouseEnter()//Als de muis op de tile staat dan laat die een andere kleur zien.
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()//Als de muis van de tile afgaat dan laat die de normale kleur zien(begin kleur).
    {
        rend.material.color = startColor;
    }

}
