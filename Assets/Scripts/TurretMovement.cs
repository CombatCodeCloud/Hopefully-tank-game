using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Rotate(0, 0, 2 * Time.deltaTime * 100);
        }
    }
}
