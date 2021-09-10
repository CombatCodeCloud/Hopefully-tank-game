using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //make code less repeating in other classes by putting methods to help in this Player Class
    public float speed;    
    public bool player2;
    public float horizontalInput;
    public float verticalInput;
    //make a switch with checking the player number here, then changing these to those in update accordingly

    void Start()
    {
         player2 = (transform.name == "PlayerTwo"); //dude you gotta fix having to do this for every script
        //make int and switch with substring
    }

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

    /*
    Vector3 getMovementDirection()
    {
        //work here
        
        switch(player)
        {
            case 2:
            horizontalInput = Input.GetAxis("Horizontal2");
            verticalInput = Input.GetAxis("Vertical2");

            case 1:
        
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
        
         Vector3 movementDirection;
         float horizontalInput;
         float verticalInput; 
         movementDirection = new Vector3(horizontalInput, verticalInput, 0);
         movementDirection.Normalize();
         return movementDirection;

    }
    */

    
}