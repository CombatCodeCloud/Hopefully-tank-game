using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 movementDirection;
    private float horizontalInput;
    private float verticalInput;
    Player playerScript;

    void Start()
    { 
        //GameObject playerTwo = GameObject.Find("PlayerTwo"); dont use this, this only for future reference.
        GameObject player = (this.transform.gameObject);
        playerScript = player.GetComponent<Player>();
        Debug.Log(playerScript.player2);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerScript.player2);
    }

    private void FixedUpdate()
    {
        int speed;
        speed = 2;



        if (playerScript.player2)
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
