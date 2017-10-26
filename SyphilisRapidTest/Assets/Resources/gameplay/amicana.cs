using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amicana : MonoBehaviour {

    public GameObject go1;
    private Transform tr;
    public GameObject xeli;

	void Start ()
    {
        tr = go1.GetComponent<Transform>(); // mxolod ertxel gadaecema mere afdeiti sawiroa
	}
	
	void Update ()
    {
		
        if(Vector3.Distance(gameObject.transform.position, go1.transform.position) <3)
        {

            xeli.transform.position = go1.transform.position;
        }

	}
}
