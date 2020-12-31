using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");  // GetAxis has an accelation component rather than going straight to player speed
        change.y = Input.GetAxisRaw("Vertical");    // GetAxisRaw goes straight to the player speed set
        //Debug.Log(change);                        // Used debug to show the speed in the bottom left corner while playing
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(
             transform.position + change.normalized * speed * Time.deltaTime
        );
    }
}
