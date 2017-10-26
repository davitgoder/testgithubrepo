using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArrow : MonoBehaviour {

 

    public float speed = 0.1f;
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x - speed, 
                transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x + speed, 
                transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, 
                transform.position.y, transform.position.z + speed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, 
                transform.position.y , transform.position.z - speed);
        }

    }
}

