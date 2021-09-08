using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    private bool player2;
    // Update is called once per frame

    private void Start()
    {
        player2 = (transform.parent.name == "PlayerTwo");
    }
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (player2)
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
