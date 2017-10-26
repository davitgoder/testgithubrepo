using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHCalxculator : MonoBehaviour {


    public int NaOHConcentration;
    public int HClConcentration;


   


    public float CurrentPH;



	void Start ()
    {
        CurrentPH = Random.Range(4.0f, 9.0f);  
	}
	

	void Update ()
    {
		
	}



}
