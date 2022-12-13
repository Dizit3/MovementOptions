using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseMover : MonoBehaviour
{
    public Vector3 direction;
    public float acceleration;

    public Rigidbody rb3D;


    private void FixedUpdate()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            rb3D.AddForce(direction.normalized * acceleration, ForceMode.Impulse);
        }
    }



}
