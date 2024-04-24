using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
 public float moveSpeed =0f;
 public KeyCode moveLeftButton = KeyCode.JoystickButton8;
 public KeyCode moveRightButton = KeyCode.JoystickButton9;
 public KeyCode moveUpButton = KeyCode.W;
 public KeyCode moveDownButton = KeyCode.S;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
     Move();
    }
    private void Move()
    {
        float horizontalInput= 0f;
        float verticalInput= 0f;
    if (Input.GetKey(moveLeftButton))
    {
        horizontalInput= -1f;
    }
    else if (Input.GetKey(moveDownButton))
    {
        verticalInput = 1f;
    }
    rb.velocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
    

    //      RotateWithMouse();
    }

/* void RotateWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
    }
*/


}
