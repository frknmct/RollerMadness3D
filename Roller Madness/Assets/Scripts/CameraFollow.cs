using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    [SerializeField] private Transform target;
    [SerializeField] private float cameraFollowSpeed = 5f;
    private Vector3 offsetVector;
    void Start()
    {
        offsetVector = CalculateOffset(target);
    }

    
    void FixedUpdate()
    {
        MoveTheCamera();
    }

    private void MoveTheCamera()
    {
        if (target != null)
        {
            Vector3 targetToMove =  target.position + offsetVector;
            transform.position = Vector3.Lerp(transform.position,targetToMove,cameraFollowSpeed * Time.deltaTime);
            transform.LookAt(target.transform.position);
        }
        
    }

    private Vector3 CalculateOffset(Transform newTarget)
    {
         return transform.position - newTarget.position;
        
    }
}
