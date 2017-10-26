using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niadagis : MonoBehaviour {

    public GameObject go;
  //  public Animator A;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {

		if(Vector3.Distance(gameObject.transform.position, go.transform.position ) <2 && Input.GetKeyDown(KeyCode.E) )
        {
            go.SetActive(true);

        }
	}
}
