using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    private Player player;
    private GameObject playerObject;

    // Start is called before the first frame update
    private void Start()
    {
        playerObject = (this.transform.parent.gameObject);
        player = playerObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (player.playerNumber == 2)
        {
            if (Input.GetKey (KeyCode.RightShift))
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
