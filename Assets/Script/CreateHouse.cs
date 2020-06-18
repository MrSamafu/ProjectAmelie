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
                if(SystemManager.materials < 15 || SystemManager.cash < 15)
                {
                    Debug.Log("Il vous manque des ressources pour " + buildings[SystemManager.selection].name);
                }
                else
                {
                    SystemManager.materials = SystemManager.materials - 15;
                    SystemManager.cash = SystemManager.cash - 15;
                    SystemManager.staff = SystemManager.staff + 5;
                    SystemManager.maxStaff = SystemManager.maxStaff + 5;
                    Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
                }

            }
            if (buildings[SystemManager.selection].name == "LaboPrototype")
            {
                if (SystemManager.researchPoint < 15 || SystemManager.cash < 15)
                {
                    Debug.Log("Il vous manque des ressources pour " + buildings[SystemManager.selection].name);
                }
                else
                {
                    SystemManager.materials = SystemManager.researchPoint - 15;
                    SystemManager.cash = SystemManager.cash - 15;
                    SystemManager.staff = SystemManager.staff - 1;
                    Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
                }
            }
            if (buildings[SystemManager.selection].name == "DockPrototype")
            {
                if (SystemManager.cash < 15)
                {
                    Debug.Log("Il vous manque des ressources pour " + buildings[SystemManager.selection].name);
                }
                else
                {
                    SystemManager.cash = SystemManager.cash - 15;
                    SystemManager.staff = SystemManager.staff - 1;
                    Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
                }
            }
            if (buildings[SystemManager.selection].name == "FarmPrototype")
            {
                if (SystemManager.materials < 15)
                {
                    Debug.Log("Il vous manque des ressources pour " + buildings[SystemManager.selection].name);
                }
                else
                {
                    SystemManager.cash = SystemManager.materials - 15;
                    SystemManager.staff = SystemManager.staff - 1;
                    Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
                }
            }
            if (buildings[SystemManager.selection].name == "MarketPrototype")
            {
                if (SystemManager.cash < 15 || SystemManager.materials < 15 || SystemManager.food < 15)
                {
                    Debug.Log("Il vous manque des ressources pour " + buildings[SystemManager.selection].name);
                }
                else
                {
                    SystemManager.cash = SystemManager.cash - 15;
                    SystemManager.cash = SystemManager.materials - 15;
                    SystemManager.cash = SystemManager.food - 15;
                    SystemManager.staff = SystemManager.staff - 1;
                    Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
                }
            }

            build = true;
            
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
