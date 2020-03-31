using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent : MonoBehaviour
{

    private NavMeshAgent agentN;

    public Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        agentN = GetComponent<NavMeshAgent>();
        //agentN.SetDestination(destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                agentN.SetDestination(hit.point);
            }

        }
    }
}
