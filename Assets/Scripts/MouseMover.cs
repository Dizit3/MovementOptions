using UnityEngine;

public class MouseMover : MonoBehaviour
{
    public float speed;

    private Vector3 targetPos;
    private bool isMoving = false;



    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TriggerPos();
        }

        if (isMoving)
        {
            Move();
        }

    }

    void TriggerPos()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(myRay, out hitInfo, 50))
        {
            targetPos = hitInfo.point;
            targetPos.y = transform.position.y;

            isMoving = true;
        }

    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
        {
            isMoving = false;
        }

    }

}
