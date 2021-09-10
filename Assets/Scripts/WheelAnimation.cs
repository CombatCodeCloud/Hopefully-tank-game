using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAnimation : MonoBehaviour
{
    public float rotationSpeed = 720;
    Player playerScript;


    // Start is called before the first frame update
    private void Start()
    {
        GameObject player = (this.transform.parent.gameObject);
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 movementDirection = playerScript.getMovementDirection();

        if (movementDirection != Vector3.zero)
        {
            transform.up = movementDirection;
        }
        
    }
}