using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHouse : MonoBehaviour
{
    public GameObject [] buildings;
    private Vector3 buildingPosition;
    private bool build;
    private Renderer render;
    private Color startColor;
    
    private void Start()
    {
        build = false;
        buildingPosition = new Vector3(transform.position.x, 0.6f, transform.position.z);
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    private void OnMouseUpAsButton()
    {
        if(build == false)
        {
            if(buildings[SystemManager.selection].name == "HousePrototype")
            {

            }
            if (buildings[SystemManager.selection].name == "LaboPrototype")
            {

            }
            if (buildings[SystemManager.selection].name == "DockPrototype")
            {

            }
            Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
            build = true;
            render.material.color = Color.green;
        }
    }
    private void OnMouseOver()
    {
        render.material.color = Color.green;
    }
    private void OnMouseExit()
    {
        render.material.color = startColor;
    }
}
