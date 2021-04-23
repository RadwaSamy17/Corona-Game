using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 7;
    private Vector3 movevector;
    private float verticalvelocity=0;
    private float gravity = 12;
 
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    

        movevector = Vector3.zero;
        if (controller.isGrounded)
        {
            // calculate the vertical velocity

            verticalvelocity = -0.5f;
        }
        else
        {
            // when fall the vertical velocity increase

            verticalvelocity -= gravity * Time.deltaTime;
        }
        // x is left and right
        movevector.x = Input.GetAxisRaw("Horizontal")*speed;
        // y is up and down
        movevector.y = verticalvelocity;
        // z is forward and backward
        movevector.z = speed;
        controller.Move(movevector*Time.deltaTime);
    }
    

}
