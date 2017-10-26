using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSate : MonoBehaviour { // main sttae machien that controls entire game

    int state = 0;


    public GameObject SMeas, Lmeas;
    public GameObject Petri;
    public GameObject spoon;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        Statechontrol();


    }

    public int LocState = 0;
    public void Statechontrol()
    {

        switch(LocState)
        {
            case 0:

                if(SMeas.GetComponent<State>().Quantity == 1)
                {
                    SMeas.GetComponent<Measuuring>().enabled = false;
                    Lmeas.GetComponent<Measuuring>().enabled = false;

                    Petri.GetComponent<petrin>().enabled = true;

                    LocState = 1;
                }

             break;

            case 1:

                if(Petri.GetComponent<petrin>().informmain)
                {
                    LocState = 2;

                }
                

                break;
            case 2:

                spoon.GetComponent<spoon>().enabled = true;


                if(Petri.GetComponent<petrin>().quantity == 52)
                {
                    LocState = 3;

                }

                break;





        }

    }



}
