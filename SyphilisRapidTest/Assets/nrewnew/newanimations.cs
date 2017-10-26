using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class newanimations : MonoBehaviour {



    public GameObject menuzra1, menzura2, petri, kovzi, saswori, mediabox, hotplate, botli, ph,avtoklav,macivari,gumeli,laminarbox;



    


	void Start ()
    {
		
	}

    public int state = 0;

	void Update ()
    {
        MainFunction();
	}



    public int SubtSate = 0;

    void MainFunction()
    {
        switch(SubtSate)
        {
            case 0:

                Water();
                break;


            case 1:

                petrif();

                break;
                  
            case 2:

                menzuar2f();

                break;

            case 3:
                botlisanim();
                break;




        }


    }


  public  short i =0;

    public GameObject Zslider;
    public float Quantity;
    public float correctquantoty = 0;

    public void Water()
    { 
        if( i== 0 && gameObject.GetComponent<Raycast>().GetHoldname().name == menuzra1.name)
        {

            menuzra1.GetComponent<Animator>().SetTrigger("cklick");

            i = 1;
        }

        if (i == 1 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {
            Zslider.SetActive(true);
            acuraccy = 0.3f;
            correctquantoty = 1;
            i = 2;
        }

        if(i == 2) // slideris ganaxleba
        {

            SliderFunction();

        }

        if(i== 3)
        {

            menuzra1.GetComponent<Animator>().SetTrigger("g");
            menzura2.GetComponent<Animator>().enabled = true;

            SubtSate = 1;
            i = 0;
        }






    }


    void petrif()
    {
        if (i == 0 && gameObject.GetComponent<Raycast>().GetHoldname().name == petri.name)
        {

            petri.GetComponent<Animator>().SetTrigger("up");

            i = 1;
        }

        if (i == 1 && gameObject.GetComponent<Raycast>().GetHoldname().name == saswori.name)
        {

            petri.GetComponent<Animator>().SetTrigger("sasworze");




            i = 2;
        }



        if (i == 2 && gameObject.GetComponent<Raycast>().GetHoldname().name == mediabox.name)
        {

            mediabox.GetComponent<Animator>().SetTrigger("t");

            i = 3;
        }


        if (i == 3 && gameObject.GetComponent<Raycast>().GetHoldname().name == kovzi.name)
        {

            kovzi.GetComponent<Animator>().enabled = true;




            //           
            Zslider.SetActive(true);
            correctquantoty = 52;
            acuraccy = 1;
            Zslider.GetComponent<Slider>().minValue = 0;
            Zslider.GetComponent<Slider>().maxValue = 60;
            //



            i = 4;
        }


        if (i == 5)
        {

            kovzi.GetComponent<Animator>().SetTrigger("anim");
            petri.GetComponent<Animator>().SetTrigger("fill");
            i = 6;
        }

        if (i == 6 && gameObject.GetComponent<Raycast>().GetHoldname().name == petri.name)
        { 
            i = 7;

        }

        if (i == 7 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {
            petri.GetComponent<Animator>().SetTrigger("ToMeas");
            menzura2.GetComponent<Animator>().speed = 100;
            menzura2.GetComponent<Animator>().SetTrigger("c");

            SubtSate = 2;
            i = 0;
        }




    }

        void menzuar2f()
    {

        if (i == 0 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {
            menzura2.GetComponent<Animator>().speed = 1;
            menzura2.GetComponent<Animator>().SetTrigger("up");

            i = 1;
        }

        if (i == 1 && gameObject.GetComponent<Raycast>().GetHoldname().name == hotplate.name)
        {
            menzura2.GetComponent<Animator>().SetTrigger("dissolve");


            i = 2;
        }

        if (i == 2 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {
            menzura2.GetComponent<Animator>().SetTrigger("afterdisolve");
         
            i = 3;
        }




        if (i == 3 && gameObject.GetComponent<Raycast>().GetHoldname().name == ph.name)
        {

            ph.GetComponent<Animator>().enabled = true;


            i = 4;
        }







        if (i == 4 && gameObject.GetComponent<Raycast>().GetHoldname().name == menzura2.name)
        {

            menzura2.GetComponent<Animator>().SetTrigger("up2");


            i = 5;
        }


        if (i == 5 && gameObject.GetComponent<Raycast>().GetHoldname().name == botli.name)
        {
            menzura2.GetComponent<Animator>().SetTrigger("botlebshi");

            botli.GetComponent<Animator>().SetTrigger ("c");
            i = 0;
            SubtSate = 3;
        }







    }



    float tim = 0;


    public GameObject petrebi;
    public GameObject finalpetri;
    public GameObject door;





    public List<GameObject> li = new List<GameObject>();
    // avtoklavi, macivaro, mikrogulemi, ;laminar
    void botlisanim()
    {


        if (i == 0 && gameObject.GetComponent<Raycast>().GetHoldname().name == botli.name)
        {



            botli.GetComponent<Animator>().SetTrigger("c1");


            i = 1;

        }





        if (i == 1 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[0].name )
        {


          
            botli.GetComponent<Animator>().SetTrigger("c2");
            li[0].GetComponent<Animator>().SetTrigger("t1");

            tim = Time.time;
            
            i = 2;

        }

      



        if (i == 2 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[0].name && (Time.time - tim >1) )
        {


            botli.GetComponent<Animator>().SetTrigger("c21");
            li[0].GetComponent<Animator>().SetTrigger("t1");


            i = 3;

        }




        if (i == 3 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[1].name)
        {
            botli.GetComponent<Animator>().SetTrigger("c4");

            li[1].GetComponent<Animator>().SetTrigger("t1");

            tim = Time.time;
            i = 4;

        }





        if (i == 4 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[1].name && (Time.time - tim > 0.3f))
        {
            botli.GetComponent<Animator>().SetTrigger("c41");
            li[1].GetComponent<Animator>().SetTrigger("t1");

            i = 5;

        }





        if (i == 5 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[2].name)
        {
            botli.GetComponent<Animator>().SetTrigger("c3");
            li[2].GetComponent<Animator>().SetTrigger("t1");


            tim = Time.time;
            i = 6;

        }




        if (i == 6 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[2].name && Time.time - tim >1)
        {
           
          
            botli.GetComponent<Animator>().SetTrigger("c31");
            li[2].GetComponent<Animator>().SetTrigger("t1");


            tim = Time.time;

            i = 7;

        }



        


        if (i == 7 && gameObject.GetComponent<Raycast>().GetHoldname().name == li[3].name )
        {
          

            botli.GetComponent<Animator>().SetTrigger("c5");
            li[3].GetComponent<Animator>().SetTrigger("t1");


            tim = Time.time;
            i = 8;

        }


        if(i == 8)
        {

            Zslider.SetActive(true);
            correctquantoty = 30;
            acuraccy = 1;
            Zslider.GetComponent<Slider>().minValue = 0;
            Zslider.GetComponent<Slider>().maxValue = 40;

            i = 9;
        }



        if( i == 9&& Zslider.GetComponent<Slider>().value >29)
        {
            Zslider.SetActive(false);
            gameObject.GetComponent<Animator>().enabled = true;
            botli.GetComponent<Animator>().SetTrigger("ff");
            petrebi.GetComponent<Animator>().enabled = true;
            i = 10;

            tim = Time.time; 


        }

        if( i == 10 &&/* !botli.GetComponent<Animator>().GetAnimatorTransitionInfo(0).IsName("final")*/ Time.time - tim>15)
        {

            Destroy(petrebi);

            gameObject.GetComponent<Animator>().SetTrigger("t");
            finalpetri.SetActive(true);
            li[3].GetComponent<Animator>().SetTrigger("anim");
        }

















    }







    public void SliderFunction()
    {

        Zslider.transform.GetChild(0).gameObject.GetComponent<Text>().text = Zslider.GetComponent<Slider>().value.ToString("####0.00") + ".ml";
        Quantity = Zslider.GetComponent<Slider>().value;

    }



    float acuraccy = 0;
    public void OK()
    {

        if(Quantity  < correctquantoty + acuraccy && Quantity > correctquantoty-acuraccy)
        {

            i++;
            Zslider.SetActive(false);


        }

    }





}
