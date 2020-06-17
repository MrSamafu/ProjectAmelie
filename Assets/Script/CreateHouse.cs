using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHouse : MonoBehaviour
{
    public GameObject [] buildings;
    private Vector3 buildingPosition;
    private bool build;
    
    private void Start()
    {
        build = false;
        buildingPosition = new Vector3(transform.position.x, 0.6f, transform.position.z);
    }

    private void OnMouseUpAsButton()
    {
        if(build == false)
        {
            Instantiate(buildings[SystemManager.selection], buildingPosition, Quaternion.identity);
            build = true;
        }
    } 
}
