using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PenguinMove : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject tiles;
    private GameObject target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Tile (" + Random.Range(1, 1024) + ")");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,target.transform.position) <= 0.2f)
        {
            target = GameObject.Find("Tile (" + Random.Range(1, 1024) + ")");
        }
        agent.SetDestination(target.transform.position);
    }
}
