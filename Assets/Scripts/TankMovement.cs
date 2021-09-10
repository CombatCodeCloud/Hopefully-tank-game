using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    Player playerScript;

    // Start is called before the first frame update
    void Start()
    { 
        //GameObject playerTwo = GameObject.Find("PlayerTwo"); dont use this, this only for future reference.
        GameObject player = (this.transform.gameObject);
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerScript.player2);
    }

    private void FixedUpdate()
    {
        float speed = playerScript.speed;

        Vector3 movementDirection = playerScript.getMovementDirection();
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
    }
}
