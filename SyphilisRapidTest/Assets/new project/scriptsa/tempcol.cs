using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempcol : MonoBehaviour {

	public GameObject k;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public GameObject OnCollisionStay(Collision collision)
    {
        Debug.Log("coll   " + collision.gameObject.name);

        k = collision.gameObject;
        return collision.gameObject;
    }


    
}
