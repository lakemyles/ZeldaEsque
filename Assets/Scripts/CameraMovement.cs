using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate comes after Update so player moves on Update 
    // and camera moves on LateUpdate
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPostition = new Vector3(target.position.x, 
                target.position.y, transform.position.z);
            targetPostition.x = Mathf.Clamp(targetPostition.x,
                minPosition.x, maxPosition.x);
            targetPostition.y = Mathf.Clamp(targetPostition.y,
                minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position,
                targetPostition, smoothing);
        }
    }
}
