using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreva : MonoBehaviour {

    public Animator A;
	
	void Start ()
    { 
   
		
	}
	
	

	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            A.enabled = true;
        }

	}
}
