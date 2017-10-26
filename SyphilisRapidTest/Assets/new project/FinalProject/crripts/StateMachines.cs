using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachines : MonoBehaviour {

    public int CurrentState = 0;

    //nesassary objects
    public GameObject gloves;





    //nesassary objects



    void Start ()
    {
		
	}


    void Update ()
    {


        state();
	}



    public int ExOnlyOnce = 0;

    void state()
    {
        switch(CurrentState)
        {
            case 0:

                //  do first things

                // if gloves are cklicked state becomes 1 (from some script



            


                ExOnlyOnce = 1;


                break;



            case 1:


              
                if(ExOnlyOnce == 1)
                {
                    gloves.SetActive(false);



                    ExOnlyOnce = 2;
                }





                break;


            case 2:





                break;

            case 3:





                break;



        }



    }


}
