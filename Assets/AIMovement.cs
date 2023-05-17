using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{

    void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(GameManager.Instance.Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}