using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogetherScript : MonoBehaviour
{
    public float speed;
    private Vector3 movementDirection;
    private float horizontalInput;
    private float verticalInput;
    private bool player2;

    void Start()
    {
        player2 = (transform.name == "PlayerTwo"); //dude you gotta fix having to do this for every script
    }

    /*
    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime * 2, 0);
            dirFacing = 0; //0
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime * 2, 0);
            dirFacing = 4; //4
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime * 2, 0, 0);
            dirFacing = 2; //6
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * 2, 0, 0);
            dirFacing = 6; //2
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            dirFacing = 7; //1
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            dirFacing = 1; //7
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            dirFacing = 5; //3
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            dirFacing = 3; //5
        }

        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 1 * Time.deltaTime * 2, 0);
            dirFacing = "w";

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * Time.deltaTime * 2, 0);
            dirFacing = "s";
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Time.deltaTime * 2, 0, 0);
            dirFacing = "a";
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * Time.deltaTime * 2, 0, 0);
            dirFacing = "d";
        }
      
    //Debug.Log(dirFacing);
    }
    */

    // Update is called once per frame
    void Update()
    {
        /*

        switch (this.currentStatus)
        {
            case "normal":
                speed = originalSpeed;
                break;
        }

        if ((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
                || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)))
        {
            speed = 1;
        }
        else
        {
            speed = 2;
        }
        */
    }

    public void FixedUpdate() {
        int speed;
        speed = 2;


        
        if (player2)
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

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        /*
        if (movementDirection != Vector3.zero)
        {
            transform.up = movementDirection;
        }
        */
    }
}