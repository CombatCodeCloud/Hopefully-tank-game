using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAnimation : MonoBehaviour
{
    public float rotationSpeed = 720;
    private Vector3 movementDirection;
    private float horizontalInput;
    private float verticalInput;


    // Start is called before the first frame update


    // Update is called once per frame
    private void FixedUpdate()
    { 
        
        if (transform.parent.name == "PlayerTwo")
        {
            horizontalInput = Input.GetAxis("Horizontal2");
            verticalInput = Input.GetAxis("Vertical2");        
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
        

        movementDirection = new Vector3(horizontalInput, verticalInput, 0);
        movementDirection.Normalize();

        //transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
        if (movementDirection != Vector3.zero)
        {
            transform.up = movementDirection;
        }
        
    }
}