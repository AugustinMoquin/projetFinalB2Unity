using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform Player;


    void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(Player.position);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(Player.position);
    }
}