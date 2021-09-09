using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;    
    public bool player2;
    public float horizontalInput;
    public float verticalInput;
    //make a switch with checking the player number here, then changing these to those in update accordingly

    void Start()
    {
         player2 = (transform.name == "PlayerTwo"); //dude you gotta fix having to do this for every script
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

    
}