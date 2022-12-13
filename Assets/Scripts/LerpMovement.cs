using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{

    public Vector3 startPos;
    public Vector3 endPos;
    public float step;
    private float progress;

    private void Start()
    {
        transform.position = startPos;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(startPos, endPos, progress);
        progress += step;
    }
}
