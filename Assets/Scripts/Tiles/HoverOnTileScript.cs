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
        hoverTheColor = true;//In deze functie staat deze bool op true;
        if (hoverTheColor == true && turret)//Als de hovercolor true is en de toren is er ga naar de startkleur.
        {
            rend.material.color = startColor;
        }
        else//anders als de toren er niet staat op mouseEnter de hovercolor laten zien.
        {
            rend.material.color = hoverColor;
        }
    }


    void OnMouseExit()//Als de muis van de tile afgaat dan laat die de normale kleur zien(begin kleur).
    {
        hoverTheColor = false;//In deze functie staat deze bool op false;
        if(hoverTheColor == false)//Als de hovercolor false is dan moet het naar de startkleur gaan.
        {
            rend.material.color = startColor;
        }
        else//Als de muis niet op de tile staat dan gaat de bool terug naar true en laat dus de hovercolor zien.
        {
            rend.material.color = hoverColor;
        }
    }


}
