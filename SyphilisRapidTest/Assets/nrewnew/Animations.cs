using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Animations : MonoBehaviour {


    public int menzurebi=0, petris =0;
    public int Gstate =0;


    
    // quantiotis
    public int spoonquantity = 0;

        //quantitis

    //

    public GameObject menzura1, menzura2, PetriOb, textmesh, spoon, spoonSqroll, mediabox;
        //
	void Start ()
    {
	
	}
	
	
	void Update ()
    {
     


        if (Gstate < 2)
        {

            globstate1();
        }
        else
        {
            globstate2();

        }



    }




   


    public int g1=0;


    // quantity
    public GameObject Sliderobject;
    public GameObject TextObject;
    // quantity

    public void globstate2()
    {
        if(gameObject.GetComponent<Raycast>().GetHoldname().name == "Zero Out")
        {
            textmesh.GetComponent<TextMeshPro>().text = "0";
        }

        if (gameObject.GetComponent<Raycast>().GetHoldname().name == "Spoon")
        {
            
            spoonSqroll.SetActive(true);

        }


       
        if(spoonquantity == 52)
        {
            spoonSqroll.SetActive(false);
            spoon.GetComponent<Animator>().enabled = true;
            PetriOb.GetComponent<Animator>().SetTrigger("fill");

            g1 = 1;

        }
       

        if (spoon.GetComponent<Animator>().GetAnimatorTransitionInfo(0).IsName("iospoon") && g1 ==1 && gameObject.GetComponent<Raycast>().GetHoldname().name == "Petri Dish")
        {
            spoon.GetComponent<Animator>().SetTrigger("ToMeas");

        }



    }




    public bool wheelpermis = false;
    float i = 0;

    float tim = 0;

    public bool timb = false, timb1=false;



   public int counter=0;

    public GameObject ph;



    public bool OK= false;

    public GameObject petrislider;

    public void ok()
    {
        OK = true;

    }


    public float globquantity = 0;

    public int sequnece = 0;

    public void valusechange()
    {

        switch(sequnece)
        {
            case 0:

                Sliderobject.transform.GetChild(0).gameObject.GetComponent<Text>().text = Sliderobject.GetComponent<Slider>().value.ToString();
               // Sliderobject.transform.GetChild(0).gameObject.GetComponent<Text>().text += Input.GetAxis("Mouse ScrollWheel");

                globquantity = Sliderobject.GetComponent<Slider>().value;

                break;

            case 1:

                petrislider.transform.GetChild(0).gameObject.GetComponent<Text>().text = petrislider.GetComponent<Slider>().value.ToString();
                globquantity = petrislider.GetComponent<Slider>().value;
                break;

            case 2:


                break;

        }

       
    }

    public void globstate1()
    {


        if (gameObject.GetComponent<Raycast>().GetHoldname() &&  gameObject.GetComponent<Raycast>().GetHoldname().name == menzura1.name)
        {
            menzurebi = 1;

        }

        if ( gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name && menzurebi == 1)
        {

            menzurebi = 2;
            wheelpermis = true;

        }



        
        if (wheelpermis == true)
        {

            Sliderobject.SetActive(true);

            valusechange();


    
        }



        if ( OK && ( globquantity >0.9f && globquantity<1.1f ))
        {

            menzura1.GetComponent<Animator>().enabled = true;
            menzura2.GetComponent<Animator>().enabled = true;

            Sliderobject.SetActive(false);
            timb = true;
           
            counter = 1;
            wheelpermis = false;
            OK = false;
        }









        if ( gameObject.GetComponent<Raycast>().GetHoldname().name == "Petri Dish" && counter==1 && petris == 0 )
        {
            petris = 1;
        }


        if (petris == 1 && gameObject.GetComponent<Raycast>().GetHoldname().name == "scale")
        {
            PetriOb.GetComponent<Animator>().enabled = true;
            petris = 2;

            

        }







        if ( petris == 2 && gameObject.GetComponent<Raycast>().GetHoldname().name == "Spoon" || petris == 2 && gameObject.GetComponent<Raycast>().GetHoldname().name == "Media Box")
        {
            sequnece = 1;

            petrislider.SetActive(true);

            spoon.GetComponent<Animator>().enabled = true;
            mediabox.GetComponent<Animator>().SetTrigger("t");
            petris = 3;


           
        }

        if(petris == 3)
        {
            petrislider.SetActive(true);

          //  valusechange();

        }



        if ( (OK && petris == 3) && ( globquantity == 52 ) )
        {
            //PetriOb.GetComponent<Animator>().SetTrigger("ToMeas");

            //kovzis mtliani aniamacia

            Debug.Log("petrsi anim");

            OK = false;

            petrislider.SetActive(false);
            petris = 4;
        }

        if (petris == 4 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {
            menzura2.GetComponent<Animator>().SetTrigger("dissolve");
            petris = 5;

            tim = Time.time;
        }

        if (petris == 5 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name && (Time.time - tim >1))
        {
            menzura2.GetComponent<Animator>().SetTrigger("afterdisolve");

            petris = 6;
        }

        if (petris == 6 && gameObject.GetComponent<Raycast>().GetHoldname().name == "PH" && (Time.time - tim > 1))
        {
            ph.GetComponent<Animator>().enabled = true; 
        }





            //if (mycamera.GetComponent<Raycast>().GetHoldname().name == "Zero Out")
            //{
            //    mediabox.GetComponent<Animator>().SetTrigger("t");
            //    textmesh.GetComponent<TextMeshPro>().text = "0";
            //    petris = 3;
            //}

            //if (petris == 3)
            //{



            //    Gstate = 2;
            //}




        }


}
