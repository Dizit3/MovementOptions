using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectNavigation : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent myAagent;


    private void Start()
    {
        myAagent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            RaycastHit hitInfo;


            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAagent.SetDestination(hitInfo.point);
            }
        }
    }

}
