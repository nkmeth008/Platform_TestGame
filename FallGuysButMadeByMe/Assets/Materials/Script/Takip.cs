using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Takip : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform target;
   

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agent.destination = target.position;
    }

}
