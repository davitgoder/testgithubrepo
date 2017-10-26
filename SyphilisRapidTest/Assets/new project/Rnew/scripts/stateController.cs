using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateController : MonoBehaviour {

    public GameObject PatarMenzura;
    public GameObject Didimenzura;

    public GameObject PetrisJami;
    public int state = 0;


    public GameObject wkiri;

    public bool na = false;


	void Start ()
    {
		
	}
	
	



	void Update ()
    {
		if(PatarMenzura.GetComponent<tetst>().CorrectAmount && gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == "petris jami")
        {
            PatarMenzura.GetComponent<tetst>().enabled = false;
            Didimenzura.GetComponent<tetst>().enabled = false;


            PetrisJami.GetComponent<PetrisState>().enabled = true;

            state = 1;
        }



        if(na)
        {


            if(gameObject.GetComponent<NewRaysdasu>().GetHoldName().name== "wkiri")
            {

                wkiri.GetComponent<Animator>().enabled = true;
            }



        }





    }


}
