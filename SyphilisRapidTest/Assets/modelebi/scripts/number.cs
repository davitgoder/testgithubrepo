using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number : MonoBehaviour {


    public GameObject parent;
    public int n;

    public Vector3 vecLoc = new Vector3();
    public Quaternion vecRot = new Quaternion();
    void Start ()
    {
        if (gameObject.tag != "imuno")
        {


            parent = GameObject.Find("Parent");
            vecRot = gameObject.transform.rotation;
            vecLoc = gameObject.transform.position;
        }


    }
	
	public void startpostion()
    {

        gameObject.transform.position = new Vector3(parent.transform.position.x, parent.transform.position.y,
        parent.transform.position.z + (n) );// parent.transform.position;

        gameObject.transform.rotation = vecRot;
        gameObject.transform.parent = parent.transform;
    }

}
