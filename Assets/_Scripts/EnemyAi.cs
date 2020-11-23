using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField]
    GameObject target;
    [SerializeField]
    GameObject spawnPoint;

    void Start()
    {

        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist > 80)
        {
            navMeshAgent.SetDestination(spawnPoint.transform.position);
        }
        else
        {
            navMeshAgent.SetDestination(target.transform.position);
        }

        transform.Rotate(new Vector3(90, 0, 0));
        
    }
}
