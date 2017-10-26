using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measuuring : State

{


    void Start ()
    {
        mycamera = Camera.main.gameObject;
	}
	
	void Update ()
    {


        AanimationSatte();

    }

    public int AnimSatate = 0; // startig state

    public GameObject Other;

    public float tim;


    public bool lo = false;
   

    public void AanimationSatte()
    {

       if(mycamera.GetComponent<Raycast>().GetName().name == gameObject.name && Other.GetComponent<Measuuring>().lo)
        {
            
            lo = true;

        }
       


       if(lo)
        switch (AnimSatate)
        {
            case 0:

                if (mycamera.GetComponent<Raycast>().GetHoldname().name == gameObject.name)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t1");

                    tim = Time.time;

                    AnimSatate = 1;

                }                


                break;

            case 1:


               
                


                if (Time.time - tim > 0.7f)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t4");

                    AnimSatate = 0;

                }





                if (mycamera.GetComponent<Raycast>().GetHoldname().name == Other.name)
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t2");


                    tim = Time.time;
                    AnimSatate = 2;

                }



                break;


            case 2:



                if (Input.GetMouseButtonUp(0))
                {
                    gameObject.GetComponent<Animator>().SetTrigger("t3");

                    tim = Time.time;

                    AnimSatate = 3;

                }







                break;


            case 3:


             if(Time.time - tim > 0.7f)
                {

                    gameObject.GetComponent<Animator>().SetTrigger("t4");
                    AnimSatate = 0;

                }





                break;


            case 4:




                //if (Time.time - tim > 0.7f)
                //{
                //    AnimSatate = 1;

                //}
                //gameObject.GetComponent<Animator>().SetBool("b3", false);
                //gameObject.GetComponent<Animator>().SetBool("b4", true);


                break;



        }


    }


}
