using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMover : MonoBehaviour
{

    public Vector3 direction;
    public float acceleration;

    public Rigidbody rb3D;



    private void FixedUpdate()
    {
        rb3D.AddForce(direction.normalized * acceleration);
    }

}
