using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform objTransform;

    public Vector3 offset;

    public float camSpeed = 5f; 


    private void Update()
    {
        Vector3  newCamPos = new Vector3(objTransform.position.x, offset.y, objTransform.position.z);

        transform.position = Vector3.Lerp(transform.position, newCamPos, camSpeed * Time.deltaTime);


        if (0 != Input.mouseScrollDelta.y )
        {
            offset -= new Vector3(0f, Input.mouseScrollDelta.y,0);

        }
    }
}
