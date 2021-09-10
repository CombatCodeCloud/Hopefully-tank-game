using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //make code less repeating in other classes by putting methods to help in this Player Class
    public float speed;   
    public string playerName;
    public int playerNumber;
    public float horizontalInput;
    public float verticalInput;
    //make a switch with checking the player number here, then changing these to those in update accordingly

    void Start()
    {
        playerName = transform.name;
        playerNumber = int.Parse(playerName.Substring(8,1)); //convert to int
        Debug.Log(playerName);
        Debug.Log(playerNumber);
        speed = 2;
        //make int and switch with subtring
    }

    // Update is called once per frame
    void Update()
    {
        /*

        switch (currentStatus)
        {
           
        }

        if (badstatus)
        {
            speed = 1;
        }
        else
        {
            speed = 2;
        }
        */
    }

    
    public Vector3 getMovementDirection()
    {
        //work here, yuh works, do this with other things

        switch (playerNumber)
        {
            case 1:
                horizontalInput = Input.GetAxis("Horizontal");
                verticalInput = Input.GetAxis("Vertical");
                break;
            case 2:
                horizontalInput = Input.GetAxis("Horizontal2");
                verticalInput = Input.GetAxis("Vertical2");
                break;
        }
        
         Vector3 movementDirection;
         
         movementDirection = new Vector3(horizontalInput, verticalInput, 0);
         movementDirection.Normalize();

         return movementDirection;
    }
}