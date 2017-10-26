using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menzura : AbsClass {

    public  Quaternion DefaultTransform;


	void Start ()
    {
        DefaultTransform = gameObject.transform.rotation;
	}
	
	
	void Update () {



      

	}

    public override void rotate(Vector2 r, GameObject cklicked)
    {

       
        base.rotate(r, cklicked); 

    }

    public override void PlaseObjectInsade(GameObject Insade)
    {

       
        base.PlaseObjectInsade(Insade);
    }





}
