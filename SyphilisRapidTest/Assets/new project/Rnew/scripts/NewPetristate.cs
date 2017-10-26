using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPetristate : MonoBehaviour {
   public int GlobaState = 0;
    public bool awonilia = false;

    GameObject Didimenzura;
    GameObject PataraMenzura;
    GameObject saswori;
    GameObject kovzi;
    GameObject Ccamera;
    GameObject yuti;
    GameObject plita;
    GameObject ph;
    GameObject fakebotles;
    GameObject woman;
    GameObject wkiri;



    void Start ()
    {
       Didimenzura= GameObject.Find("menzura state ma");
        PataraMenzura = GameObject.Find("menzura state ma (1)");
        saswori = GameObject.Find("weight 1");
        kovzi = GameObject.Find("kovzi state ");
        plita = GameObject.Find("Heater");
        Ccamera = GameObject.Find("Camera");
        yuti = GameObject.Find("kkkkk");
        wkiri = GameObject.Find("wkiri");
        ph = GameObject.Find("PH_metre");
        fakebotles = GameObject.Find("fakebottles");
        woman = GameObject.Find("Woman (2)");
    }
	
	
	void Update ()
    {
 


        if (allowStateMachine)
        SateMachine();

        if (Didimenzura.GetComponent<tetst>().CorrectAmount && Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name== gameObject.name && GlobaState ==0)
        {

            PataraMenzura.GetComponent<tetst>().enabled = false;
            Didimenzura.GetComponent<tetst>().enabled = false;
            GlobaState = 1;

        }


        if (GlobaState == 1)
        {
            PstateMashine();

        }

        if(GlobaState==2)
        {
            menzura();

        }




        }




   public int Pstate = 0;
    float dro = 0;

    void PstateMashine()
    {

        switch(Pstate)

        {
            case 0:

                gameObject.GetComponent<Animator>().SetInteger("state", 0);

                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == gameObject.name)
                {

                    dro = Time.time;
                    Pstate = 1;

                }


                break;




            case 1:



                gameObject.GetComponent<Animator>().SetInteger("state", 1);

                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "weight 1")
                {

                    Pstate = 2;

                }

                if (Time.time - dro >1.5f)
                {

                    Pstate = 0;

                }


                break;


            case 2:

                gameObject.GetComponent<Animator>().SetInteger("state", 2);
                saswori.transform.GetChild(2).gameObject.SetActive(true);
                saswori.transform.GetChild(2).GetComponent<TextMesh>().text ="10";
               


                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "ganuleba")
                {
                    saswori.transform.GetChild(2).GetComponent<TextMesh>().text = "0";
                    Pstate = 3;
                
                }

                break;

            case 3:



                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == yuti.name)
                {
                    kovzi.GetComponent<spoonState>().enabled = true;
                    yuti.GetComponent<Animator>().SetTrigger("t");
                    Pstate = 4;
                }



                    break;


            case 4:

                saswori.transform.GetChild(2).GetComponent<TextMesh>().text = kovzi.GetComponent<spoonState>().sawwori.ToString();

                if (kovzi.GetComponent<spoonState>().sawwori == 52)
                {
                    //kovzi.GetComponent<spoonState>().enabled = false;
                    Pstate = 5;
                }

                break;


            case 5:

                if(Input.GetMouseButton(0) &&   kovzi.GetComponent<spoonState>().isfinished)
                {
                 
                    gameObject.GetComponent<Animator>().SetInteger("state", 3);
                    Pstate = 6;
                   
                }

                break;


            case 6:

                if(Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == PataraMenzura.name)
                {
                    gameObject.GetComponent<Animator>().SetInteger("state", 5);
                    PataraMenzura.GetComponent<Animator>().SetTrigger("feri");
                    GlobaState = 2;
                }


                break;

        }




        





    }

  public  int stateMenzura = 0;

    public GameObject FakeBotleSlider;
    public GameObject FakeBotleSlider1;

    void menzura()
    {

        switch(stateMenzura)
        {
            case 0:

                if(Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == PataraMenzura.name)
                {
                    PataraMenzura.GetComponent<Animator>().SetTrigger("p");
                    stateMenzura = 1;
                }


                break;




            case 1:

                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == plita.name)
                {
                    PataraMenzura.GetComponent<Animator>().SetTrigger("pp");
                    plita.GetComponent<Animator>().enabled = true;
                    stateMenzura = 2;
                }

                break;



            case 2:
                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == wkiri.name)
                {
                    wkiri.SetActive(false);

                    PataraMenzura.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = true;
                    PataraMenzura.transform.GetChild(4).gameObject.GetComponent<Animator>().enabled = true;

                    dro = Time.time;

                    stateMenzura = 3;
                }

                break;


            case 3:


                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == PataraMenzura.name && (Time.time - dro > 1 ) )
                {
                    PataraMenzura.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = false;
                    PataraMenzura.transform.GetChild(4).gameObject.GetComponent<Animator>().enabled = false;

                    PataraMenzura.GetComponent<Animator>().SetTrigger("ppp");
                    stateMenzura = 4;
                }

                   break;



            case 4:
                if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == ph.name)
                {
                    ph.GetComponent<Animator>().enabled = true;
                    dro = Time.time;
                    stateMenzura = 5;
                }

                    break;



            case 5:


                if( ( Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == PataraMenzura.name  || Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == fakebotles.name) && (Time.time - dro >6 ))
                {
                    fakebotles.GetComponent<Animator>().enabled = true;

                    dro = Time.time;
                    stateMenzura = 6;
                }

             

                break;


            case 6:

                if(Time.time - dro > 2 )
                {

                    allowStateMachine = true;


          

                }
            
                break;


        }






    }


    public bool allowStateMachine = false;

    public int st = 0;

    float full = 0, f=5;
    float full1 = 0, f1=5;

    public GameObject gf; // patara cyl

    public GameObject gf1; // didi cyl


    public Slider s1; // didi salideri  
    public GameObject SliderHandelS1;

    public Slider s2; // patara salideri
    public GameObject SliderHandelS2;


    public GameObject sl1;
    public GameObject sl2;

    int deltatimeDiv = 10;

    float ltime = 0;
    bool bc = true;

    bool k = true;
    void SateMachine()
    {

        if(k)
        {

            sl2.SetActive(true);
            sl1.SetActive(true);
            k = false;
        }
     


      
        fakebotles.GetComponent<BoxCollider>().enabled = false;
        Vector3 temp = gf.transform.localScale;  //  patar botli 
        Vector3 temp1 = gf1.transform.localScale; //didi botli



        Vector3 tempM = PataraMenzura.transform.GetChild(1).transform.localScale; // menzura

     
        switch (st)
        {
            case 0:

                PataraMenzura.GetComponent<Animator>().SetTrigger("h");
                PataraMenzura.GetComponent<Animator>().SetInteger("i", 0);
                PataraMenzura.GetComponent<Animator>().SetBool("hb", true);

                if(gf1.transform.localScale.z >= 0.5311901f && gf.transform.localScale.z >= 0.351496f && bc)
                {

                    ltime = Time.time;
                    bc = false;

                  
                }
                if (Time.time - ltime > 0.3 && !bc)
                {
                    sl2.SetActive(false);
                    sl1.SetActive(false);
                    PataraMenzura.GetComponent<Animator>().SetBool("ft", true);
                    fakebotles.GetComponent<Animator>().SetTrigger("lk");
                    fakebotles.GetComponent<BoxCollider>().enabled = true;
                    Ccamera.GetComponent<nk>().enabled = true;
                }


                if (gf1.transform.localScale.z >= 0.5311901f)
                {
                    SliderHandelS1.GetComponent<Image>().color = Color.green;

                }



                if (gf.transform.localScale.z >= 0.351496f)
                {
                    SliderHandelS2.GetComponent<Image>().color = Color.green;

                }


                if ((Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "col1") /*&& gf.transform.localScale.z< f*/)
                {
             


                    st = 1;

                }

                if ((Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "col2") /*&& gf1.transform.localScale.z < f1*/)
                {

                

                    st = 2;

                }

                break;



            case 1:

              
                PataraMenzura.GetComponent<Animator>().SetBool("hb", false);
                PataraMenzura.GetComponent<Animator>().SetInteger("i", 1);
                //PataraMenzura.GetComponent<Animator>().SetTrigger("h1");

                if (gf1.transform.localScale.z < 0.5311901f && Input.GetKey(KeyCode.Mouse0))
                {

 

     tempM.z -= Time.deltaTime / 20;
  PataraMenzura.transform.GetChild(1).transform.localScale = tempM;

                 temp1.z += Time.deltaTime / deltatimeDiv;
                    gf1.transform.localScale = temp1;

                  

                  
                    s2.value += Time.deltaTime / 6.992466f;

                }
                else
                {
                     st = 0;
                }

                break;


            case 2:
             
                PataraMenzura.GetComponent<Animator>().SetBool("hb", false);
                PataraMenzura.GetComponent<Animator>().SetInteger("i", 2);
                

                if (gf.transform.localScale.z < 0.351496f && Input.GetKey(KeyCode.Mouse0))
                {
         

                    temp.z += Time.deltaTime / deltatimeDiv;
                    gf.transform.localScale = temp;


                    tempM.z -= Time.deltaTime / 20;
                    PataraMenzura.transform.GetChild(1).transform.localScale = tempM;

                  
                    s1.value += Time.deltaTime / 6.992466f;

                }
              else
                {
                    st = 0;
                }


                break;



        }


      



    }



}
