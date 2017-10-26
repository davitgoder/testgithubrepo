using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoon : MonoBehaviour {


    public GameObject tavsaxuri;

    public float quantity = 0;

    public GameObject petri;
    GameObject mycamera;

	void Start ()
    {
        mycamera = Camera.main.gameObject;	
	}
	
	void Update ()
    {
      
        SpoonState();
	}

    public int locState=0;

    public void SpoonState()
    {

        switch(locState)
        {



            case 0:

        if(mycamera.GetComponent<Raycast>().GetName().name == tavsaxuri.name)
        {
            tavsaxuri.GetComponent<Animator>().SetTrigger("t");

                    locState = 1;
        }

          break;


            case 1:



                if (mycamera.GetComponent<Raycast>().GetName().name == gameObject.name)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t");
                    locState = 2;

                }





                 break;

            case 2:




                if (mycamera.GetComponent<Raycast>().GetName().name == petri.name)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t1");

                    

                }


                if (mycamera.GetComponent<Raycast>().GetName().name == tavsaxuri.name)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t2");

                   

                }

                break;



      }

    }


}
