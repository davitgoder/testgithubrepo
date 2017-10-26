using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kovziskriptio : MonoBehaviour {

    

   

    public GameObject Player;

    public GameObject NiadagiSasworze;

    public bool AnimaciisShuaPeriodi = false;
    
    public bool  KoovziDasrulda=false;

    public bool Am_IsGazrda = false;  // icvleba animaciis dasrulebsi shemdeg
    private bool shida = true;  // if shi ertxel shevides
    public bool CHarteGasaxsneladMitana = false;


    public Text T;

     void Update()
    {

        if (KoovziDasrulda)
        {

          //  T.text = "";
            GameObject.Find("input").GetComponent<gamecontroller>().am =5;

            gameObject.GetComponent<Animator>().enabled = false;
            GameObject.Find("rightIK").GetComponent<awonva>().enabled = false;
            GameObject.Find("rightIK").GetComponent<axamocana>().enabled = false;
            GameObject.Find("rightIK").GetComponent<niadagis>().enabled = false;



            gameObject.GetComponent<kovziskriptio>().enabled = false;
        }

        if (Vector3.Distance(Player.transform.position, gameObject.transform.position) <2  && Input.GetKeyDown(KeyCode.E))    // ანიმაციის დასრულების შემდეგ am იზრდება 
        {
           // ga2.SetActive(true); 
            gameObject.GetComponent<Animator>().enabled = true;
        }


        if (AnimaciisShuaPeriodi)
        {
            GameObject.FindGameObjectWithTag("active").transform.GetChild(0).gameObject.SetActive(true);
            //    NiadagiSasworze.SetActive(true);
        }

        if (CHarteGasaxsneladMitana)
        {
            GameObject.FindGameObjectWithTag("active").AddComponent<GasaxsneladMitana>();
            GameObject.FindGameObjectWithTag("active").GetComponent<GasaxsneladMitana>().enabled = true;           //("JamiSasworze").GetComponent<GasaxsneladMitana>().enabled = true;
        }



        //if(AnimaciisShuaPeriodi)
        //{
        //    NiadagiSasworze.SetActive(true);
        //}

        //if(CHarteGasaxsneladMitana)
        //{
        //    GameObject.Find("JamiSasworze").GetComponent<GasaxsneladMitana>().enabled = true;
        //}



        if (Am_IsGazrda && shida)
        {
            shida = false;
            gameObject.GetComponent<kovziskriptio>().enabled = false;
        }

        

    }



}
