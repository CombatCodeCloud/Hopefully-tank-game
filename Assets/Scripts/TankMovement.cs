using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    private Player player;
    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    { 
        //GameObject playerTwo = GameObject.Find("PlayerTwo"); dont use this, this only for future reference.
        playerObject = (this.transform.gameObject);
        player = playerObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.player2);
    }

    private void FixedUpdate()
    {
        float speed = player.speed;

        Vector3 movementDirection = player.getMovementDirection();
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
    }
}
