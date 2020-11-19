using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform destination;

    NavMeshAgent meshAgent;

    void Start()
    {
        meshAgent = this.GetComponent<NavMeshAgent>();

        if(meshAgent == null)
        {
            Debug.LogError("The Agent component is not attached to " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if(destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            meshAgent.SetDestination(targetVector);
        }
    }


}
