using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {

    public Material change;

    public Material sakutari;

    public Material save;

    void Awake ()
    {
        save = gameObject.GetComponent<Renderer>().material;	
	}







     


     void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material = change;
    }

     void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material = save;
    }



}
