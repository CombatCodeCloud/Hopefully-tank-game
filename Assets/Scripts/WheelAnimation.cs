using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAnimation : MonoBehaviour
{
    public float rotationSpeed = 720;
    private Vector3 movementDirection;
    private float horizontalInput;
    private float verticalInput;
    Player playerScript;


    // Start is called before the first frame update
    private void Start()
    {
        GameObject player = (this.transform.parent.gameObject);
        playerScript = player.GetComponent<Player>();
        Debug.Log(playerScript.player2);
        //player2 = (transform.parent.name == "PlayerTwo");
    }
    // Update is called once per frame
    private void FixedUpdate()
    { 
        //todo : make this not dependent on the name
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

        //transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
        if (movementDirection != Vector3.zero)
        {
            transform.up = movementDirection;
        }
        
    }
}