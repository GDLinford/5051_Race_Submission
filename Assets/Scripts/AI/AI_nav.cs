using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_nav : MonoBehaviour
{

    public Transform destination;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();

        agent.SetDestination(destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
