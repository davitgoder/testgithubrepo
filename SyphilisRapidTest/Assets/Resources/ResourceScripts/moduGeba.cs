using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moduGeba : MonoBehaviour {


    public Animator A;


	void Start ()
    {
		
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            A.enabled = true;  GameObject.Find("input").GetComponent<gamecontroller>().am++;

        }


    }
}
