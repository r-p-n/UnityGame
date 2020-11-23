using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoint : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    int m_CurrentWaypointIndex;

    void Start()
    {
        navMeshAgent.updateUpAxis = false;
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    void Update()
    {
        Debug.Log(m_CurrentWaypointIndex);
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);      
        }
        navMeshAgent.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

    }
}
