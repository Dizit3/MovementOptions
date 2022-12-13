using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
            transform.Translate(direction.normalized * speed);
    }
}
