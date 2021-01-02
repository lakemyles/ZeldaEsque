using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;

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
            transform.position = Vector3.Lerp(transform.position,
                targetPostition, smoothing);
        }
    }
}
