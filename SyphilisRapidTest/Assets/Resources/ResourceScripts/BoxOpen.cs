using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoxOpen : MonoBehaviour {

    public Text sh;
    
    public Animator A;
    public GameObject pl;

    Transform T;

	void Start () {
        T = pl.GetComponent<Transform>();


        GameObject.Find("rightIK").GetComponent<awonva>().enabled = true;

        GameObject.Find("rightIK").GetComponent<awonva>().YutisGaGebaAaqtiurebs = true;
    }
	
	
	void Update () {
		if(Vector3.Distance(gameObject.transform.position, T.position)<2 )
        {
            A.SetBool("gaReba", true);
            sh.text = "Enter weight!";
            // GameObject.Find("spoon").GetComponent<kovziskriptio>().enabled = true;
          
        }
       
	}



}
