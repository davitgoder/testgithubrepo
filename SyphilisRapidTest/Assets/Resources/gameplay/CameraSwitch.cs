using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public Camera ca1;
    public Camera ca2;

       void Start ()
    {
		
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.H))
        {

            ca1.enabled = false;
            ca2.enabled = true;

        }

        if(Input.GetKeyDown(KeyCode.K))
        {

            ca1.enabled = true;
            ca2.enabled = false;
        }

	}
}
