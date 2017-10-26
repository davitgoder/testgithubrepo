using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petri : MonoBehaviour {



    public GameObject meshtext;
    public GameObject button;
   

    void Start ()
    {
        meshtext.GetComponent<TMPro.TextMeshPro>().text = "20 g.";	
	}
	
	void Update ()
    {
		
	}

}
