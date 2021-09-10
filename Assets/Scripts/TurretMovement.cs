using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    Player playerScript;

    // Update is called once per frame

    private void Start()
    {
        GameObject player = (this.transform.parent.gameObject);
        playerScript = player.GetComponent<Player>();
        Debug.Log(playerScript.player2);
    }
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (playerScript.player2)
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                transform.Rotate(0, 0, 2 * Time.deltaTime * 100);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Rotate(0, 0, 2 * Time.deltaTime * 100);
            }
        }
    }
}
