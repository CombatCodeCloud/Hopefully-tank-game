using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSPScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject sourceBullet;
    private List<GameObject> bullet;
    private float bulletSpeed = 0.1f;
    private int updateIterator = 0;
    
    void Start()
    {
        bullet = new List<GameObject>();
        sourceBullet = GameObject.Find("Bullet");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            if(updateIterator % 5000 >= 50) //essentially rate of fire
            {
                updateIterator = 0;
                bullet.Add(Instantiate(sourceBullet, this.transform.position, this.transform.rotation)); //create bullet add to list
            }
        }
    }

    void FixedUpdate()
    {
        updateIterator++;

        if (bullet.Count != 0) //if list isnt empty
        {
            foreach (GameObject b in bullet) //every object in list
            {
                if (b != null)
                {
                    b.transform.Translate(Vector3.up * bulletSpeed); //move them bullet
                    if (b.transform.position.y >= 10 || b.transform.position.y <= -10 ||
                        b.transform.position.x >= 10 || b.transform.position.x <= -10) //check if bounds
                    {
                        Destroy(b); // make null/destroy if not in bounds
                    }
                }

                while (bullet.Remove(null))
                {
                }
                //constantly remove null AKA destroyed gameObjects from list
                //todo : Check if this is actually removing null objects
            }
        }
    }
}

