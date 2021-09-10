using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    Player playerScript;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject player = (this.transform.parent.gameObject);
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (playerScript.playerNumber == 2)
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
