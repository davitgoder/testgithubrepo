using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nk : MonoBehaviour {

    public GameObject fakebotles;
    public GameObject macivari;
    public GameObject gumeli;
    public GameObject box;
    public GameObject avtoklavi;
    public GameObject butt;
    public GameObject fakebotles1;
    public  GameObject pan;
    public GameObject pan2;
    public GameObject plight;
    public GameObject sound;
    public GameObject boxshi;
    public GameObject pmacivarshi;
    public GameObject PanelMicro;
    public GameObject PanelFreezer;
    /// /////////////////
   public bool b = false, b1 = false, b3 = true, allow = false;

     public bool allowed= false;

    float t = 0;

   public int mimdevroba = 0;


    Vector3 fa = new Vector3(56.123f, 1.367f, 45.457f);
    Vector3 ft = new Vector3(54.73f, 0.908f, 48.635f);
    Vector3 fm = new Vector3(57.189f, 0.774f, 51.163f);

    bool fal= false;

    bool let = false;
    void Update ()
    {
       // fakebotles.transform.position = fa;

        // butt.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = (int) (Input.GetAxisRaw("Mouse ScrollWheel") * 10);;

        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == fakebotles.name && mimdevroba==0)
        {
            fakebotles.GetComponent<Animator>().applyRootMotion = false;
            fakebotles.GetComponent<Animator>().SetTrigger("wk");
            mimdevroba = 1;
        }

        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == avtoklavi.name && mimdevroba == 1)
        {
            fakebotles.GetComponent<Animator>().enabled = false;
            fakebotles.transform.position = fa;
            mimdevroba = 2;
           
            pan.SetActive(true);
            t = Time.time;
        }


        if ((Time.time - t > 2 && mimdevroba ==2))
        {
            pan.SetActive(false);

        }

        if ( (Time. time - t > 2) && gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == avtoklavi.name && mimdevroba ==2)
        {

            fakebotles.transform.position = ft;
            t = Time.time;
            mimdevroba = 3;
        }


        if ((Time.time - t > 1) && gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == fakebotles.name && mimdevroba == 3)
        {
            // fakebotles.transform.Translate(fakebotles.transform.up * Time.deltaTime/3);

            fakebotles.transform.position = new Vector3(54.73f, 1.182f, 48.635f);
            mimdevroba = 4;
        }


        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == macivari.name && mimdevroba == 4)
        {
            PanelFreezer.SetActive(true); 
            fakebotles.transform.position = fm;
            let = false;
            mimdevroba = 5;


        }

        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == "UV" && mimdevroba ==5)
        {
            plight.SetActive(true);
            box.GetComponent<Animator>().SetBool("daketva", true);
            mimdevroba = 6;
        }

        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == macivari.name && mimdevroba == 6)
        {
            fakebotles.transform.position = ft;
            mimdevroba = 7;

        }




        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == fakebotles.name && mimdevroba == 7)
        {
            fakebotles.transform.position = new Vector3(54.73f, 1.182f, 48.635f);
            mimdevroba = 8;

        }



        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == gumeli.name && mimdevroba == 8)
        {
            PanelFreezer.SetActive(true);
            fakebotles.transform.position = new Vector3(57.405f, 0.999f, 48.082f);

            mimdevroba = 9;
            t = Time.time;
        }


        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == gumeli.name && mimdevroba == 9 && (Time.time -t >1))
        {
            fakebotles.transform.position = ft;
            mimdevroba = 10;
        }


        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == "AirFlow" && mimdevroba == 10)
        {
            box.GetComponent<Animator>().SetBool("anteba", true);
            sound.SetActive(true);
            mimdevroba = 11;
        }




        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == fakebotles.name && mimdevroba == 11)
        {

            pan2.SetActive(true);
            boxshi.SetActive(true);

            gameObject.GetComponent<Animator>().SetTrigger("t33");

            fakebotles.SetActive(false);

            t = Time.time;
            fal = true;
            

        }

        if(Time.time - t >2 && mimdevroba == 11 && fal)
        {
            pan2.SetActive(false);
            mimdevroba = 12;

        }


        if (gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == boxshi.name && mimdevroba == 12)
        {
            boxshi.GetComponent<Animator>().enabled = true;
            t = Time.time;
            mimdevroba = 13;
        }



        if (Time.time - t >45 && mimdevroba ==13)
        {
            gameObject.GetComponent<Animator>().SetTrigger("trig33");
            boxshi.SetActive(false);
            pmacivarshi.SetActive(true);
        }

            //if(gameObject.GetComponent<NewRaysdasu>().GetName().name == avtoklavi.name && mimdevroba==1)
            //    {

            //        avtoklavi.GetComponent<Animator>().SetTrigger("t");
            //        b1 = true;
            //    }


            //if(b1 && b3)
            //    {
            //        t = Time.time;
            //        b3 = false;
            //    }

            //if(Time.time - t >1 && allow==false)
            //    {
            //        allow = true;

            //    }

            //if(allow && gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == avtoklavi.name)
            //    {
            //        fakebotles.transform.position = fa;





            //        allowed = true;
            //        t = Time.time;
            //    }








            //    if (allowed && (Time.time- t >1)  /*&& gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == avtoklavi.name*/)
            //    {
            //        pan.SetActive(true);


            //        t = Time.time; mimdevroba = 1;
            //    }


            //    if(Time.time - t >1 && mimdevroba==1)
            //    {
            //        pan.SetActive(false);

            //        mimdevroba = 2;
            //    }


            //    if(mimdevroba == 2 && gameObject.GetComponent<NewRaysdasu>().GetHoldName().name == avtoklavi.name)
            //    {
            //        fakebotles.transform.position = ft;


            //    }






        }



}
