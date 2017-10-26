using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gamecontroller : MonoBehaviour
{  // kanvass adevs   ,   !! ????????? ?????? ????????? ??????? ?????? ??????? ??????? ?????????? ?????? 



    int a = 0;

    public int am;




    public Text T;
    public List<string> karnaxi;


    public string[] lis;



    public string M;
    void Start()     // toca xelshi petris jami aqtiuria IK shi icvleba vcladi da sxva obieqte miemarte a(xeli chamoshvebulia)
    {
        am = 0;


        karnaxi.Add("Before you start working in the Lab put on the lab coat and gloves;");   // \r\n
        karnaxi.Add("Read attentively an instruction on the box of dry media which you are going to prepare. ");
        karnaxi.Add("Take one liter of desterilized water and pour it in the glass fireproof Flask.");
        karnaxi.Add("Place measurement plate on electro balance to find out its weight.");
        karnaxi.Add("Weight 52 gr media powder");
        karnaxi.Add("Place powder in flask with desterilized water");
        karnaxi.Add("Place the flask on electro heater and by glass stick stir  \r\n until dry powder dissolves. The resulted liquid should be boiled 2 - 3 min.");
        karnaxi.Add("Take prepared media from electro heater.");
        karnaxi.Add("Measure PH of media using paper indicator.");

        karnaxi.Add("Pour prepared media in the sterail gapped glass boteles");

        karnaxi.Add("Put paper ribbon on glass bottles and  \r\n label with marker – nomination, percentage, the date of preparing.");
        karnaxi.Add("Put the bottles in the autoclave (15mn on 121 0 C)");
        karnaxi.Add("After time out and switch of autoclave.");
        karnaxi.Add("Wait until it’s become solid and keep in cool place (refrigerator) + 4-5 0 C");  // duplikati
        karnaxi.Add("Wait until it’s become solid and keep in cool place (refrigerator) + 4-5 0 C");

        karnaxi.Add("Switch on the laminar box use button on the control panel of box.");
        karnaxi.Add("Put down the front glass.");

        karnaxi.Add("Switch on the UV light for 30 min use another button on the control panel of box.");

        karnaxi.Add("Afterwards switch off UV light.");

        karnaxi.Add("Melt the media in microwave oven");

        karnaxi.Add("Put sterile plastic or glass Petri dishes and melted media in the laminar box.");
        //   karnaxi.Add("Put sterile plastic or glass Petri dishes and melted media in the laminar box.");
        karnaxi.Add("Carefully unpack melted media bottle from foil paper and cover");
        karnaxi.Add("Take up the cover of the Petri dishes and pour 30ml of media, \r\n after quickly put down the cover in initial condition ");

        karnaxi.Add("Media on Petri dishes become solid and should be kept \r\n with cover down to avoid accommodation of big amount of condensate on the media surface.");
        karnaxi.Add("Label Petri dishes by marker – type of media and date");

        karnaxi.Add(" Keep Petri dishes with media in the refrigerator on + 4 - 5 0 C");



        //     karnaxi.Add("15. Add NAOH or HCl if the PH of media is not satisfied according to alkali or acid reaction you want to get until getting the optimal PH.");
        lis = new string[2];

        fire_start_time = 0;
    }


    //public List<string> lis;





    public GameObject inp;

    void Update()
    {

        Debug.Log("am" + am);
        T.text = karnaxi[am];  // kanvassze dawera
        switch (am)
        {
            case 0:
                erti();
                break;


            case 2:
                wyali();                                                         // ????? ????????

                break;

            case 3:                                                                    // ????? ???????? ?? ????? ??????
                                                                                       // inverswyali();
                M = "";
                tefshi();

                //    box(); rtvas wyluis gadasxma



                break;

            case 4:   // aq unda shemoqmdes if shi rom inputshi shetanilia ricxvi


                if (Vector3.Distance(GameObject.Find("axaliobjectm1").transform.position, GameObject.Find("spoon").transform.position) < 1.7 && Input.GetKeyDown(KeyCode.E))
                {
                    GameObject.Find("spoon").GetComponent<kovziskriptio>().enabled = true;
                    inp.SetActive(true);

                }

                break;
            case 5:
                inp.SetActive(false);


                lis[0] = M;
                meeqvse();

                //  MosadugebladGadatana();  // gasaxnelad mitana :)


                break;

            case 6:
                //inp.SetActive(true);
                meshvide();                              //  RealMosadugebladGadatana();
                break;

            case 7:
                lis[1] = M;
                merve();
                break;
            case 8:

                mecxre();

                break;

            case 9:
                meate();

                break;

            case 10:
                metertmete();
                break;

            case 11:

                metormete();
                break;

            case 12:
                mecamete();
                break;

            case 13:
                metotxmete();

                break;

            case 14:
                metxutmete();
                break;

            case 15:

                teqvsmeti();
                break;


            case 16:
                chvidmeti();
                break;

            case 17:
                tvrameti();
                break;

            case 18:
                cxrameti();
                break;

            case 19:
                oci();
                break;

            case 20:
               // ocdaerti();
                break;

            case 21:
                //ocdaori();
                break;

            case 22:
                ocdasami();
                break;

            case 23:
                ocdaotxi();
                break;
            case 24:
                ocdaxuti();
                break;
            case 25:
                ocdaeqvsi();
                break;

        }
        //  tefshi();
        //  wyali();
        // kovzi();
        // MosadugebladGadatana();
        // box();
        // moreva();




    }



    public Animator anim99;

    public GameObject GloveSound;
    bool lk = true;
    void erti()
    {

        if ((Vector3.Distance(GameObject.Find("Table 1 (3)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2) && (Input.GetKeyDown(KeyCode.E)) && lk)
        {
            GameObject.Find("axaliobjectm1").GetComponent<Animator>().enabled = false;

            GloveSound.SetActive(true);
            GameObject.Find("marcxena (1)").SetActive(false);
            fire_start_time = Time.time; lk = false;


        }


        if ((Time.time - fire_start_time) > 12 && lk == false /*Vector3.Distance(GameObject.Find("Table 1 (3)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2  && Input.GetKeyDown(KeyCode.E)  */)
        {

            GameObject.Find("axaliobjectm1").GetComponent<Animator>().enabled = true; ;
            fire_start_time = 0;

            anim99.enabled = true;
            am = 2;

        }


    }

    //
    public GameObject petrisjamixelshi;
    public GameObject sferopetrisjamixelshi;

    public GameObject magidaze;
    public GameObject sferomagidaze;

    public GameObject menzura;

    static int temp1 = 0;
    float fire_start_time = 0;
    public GameObject menzurashiFeri;
    void meeqvse()     // roca am aris 5   place flasc with distilled water 
    {



        if (Vector3.Distance(GameObject.Find("JamiSasworze").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E) && temp1 == 0)
        {
            GameObject.Find("JamiSasworze").GetComponent<Renderer>().enabled = false; //SetActive(false);
            GameObject.Find("Niadagi").GetComponent<Renderer>().enabled = false;

            petrisjamixelshi.SetActive(true);
            sferopetrisjamixelshi.SetActive(true);

            temp1 = 1;

        }



        if (Vector3.Distance(menzura.transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E) && temp1 == 1)
        {

            petrisjamixelshi.SetActive(false);
            sferopetrisjamixelshi.SetActive(false);

            magidaze.SetActive(true);
            sferomagidaze.SetActive(true);

            temp1 = 2;
            fire_start_time = Time.time;
        }




        if (Vector3.Distance(menzura.transform.position, GameObject.Find("axaliobjectm1").transform.position) < 5 && temp1 == 2)
        {





            if (Input.GetKeyDown(KeyCode.E) && (Time.time - fire_start_time) > 1)
            {
                magidaze.GetComponent<Animator>().enabled = true;
                // GameObject.Find("menzura").GetComponent<Animator>().enabled = true;
                fire_start_time = Time.time;
                temp1 = 3;
            }



        }

        if ((Time.time - fire_start_time) > 1 && temp1 == 3)
        {
            menzurashiFeri.GetComponent<Animator>().SetBool("FerisShecvla", true);

            am = 6;
        }

    }

    //public GameObject wkiri;
    int incount = 0;
    void meshvide()
    {

        if (Input.GetKeyDown(KeyCode.E) && incount == 0)
        {
            menzura.GetComponent<Animator>().enabled = true;
            GameObject.Find("Heater").GetComponent<Animator>().enabled = true;
            M = "";
            fire_start_time = Time.time;
            incount = 1;
        }

        if ((Time.time - fire_start_time) > 6 && incount == 1)
        {

            if (Vector3.Distance(wkiri.transform.position, menzura.transform.position) < 0.2)
            {
                wkiri.SetActive(true);
            }
            inp.SetActive(true);
            incount = 2;
        }

        if (Input.GetKeyDown(KeyCode.Return) && incount == 2)
        {
            wkiri.SetActive(false);
            inp.SetActive(false);



            am = 7;
        }

    }




    void merve()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            menzura.GetComponent<Animator>().SetBool("M", true);
            am = 8;
        }

    }

    //
    public GameObject ph;
    bool c = true;
    void mecxre()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {


            ph.GetComponent<Animator>().enabled = true;

            if (c)
            {
                fire_start_time = Time.time; c = false;
            }
            if (Time.time - fire_start_time > 10)
            {
                fire_start_time = 0;
                am = 9;  // 10 wami
            }
        }

    }




    public GameObject botl;
    void meate()
    {
        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(menzura.transform.position, GameObject.Find("axaliobjectm1").transform.position) < 3)
        {
            GameObject.Find("fakebottles").GetComponent<Animator>().enabled = true;
            botl.GetComponent<Animator>().enabled = true;

            menzura.GetComponent<Animator>().SetBool("bgavseba", true);
            menzura.GetComponent<botlebshiganawileba>().enabled = true;      // zrdis am -s
        }



    }

    public GameObject botli1;
    public GameObject botli2;
    bool b = true;

    void metertmete()
    {



        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(menzura.transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5)  // texturebic unda mieniwos
        {


            GameObject.Find("Marker").GetComponent<Animator>().enabled = true;
            if (b)
            {
                fire_start_time = Time.time; b = false;
            }

            if (Time.time - fire_start_time > 3)
            {

                fire_start_time = 0;
                am = 11;
            }

        }


    }

    public GameObject fake;

    public GameObject fakeontable;

    bool nnn = true;

    int intcount1 = 0;
    void metormete()
    {
        if (Vector3.Distance(GameObject.Find("menzura").transform.position, GameObject.Find("rightIK").transform.position) < 2 && Input.GetKeyDown(KeyCode.E) && intcount1 == 0)
        {
            fake.SetActive(true);
            fakeontable.SetActive(false);
            intcount1 = 1;
        }



        if (Vector3.Distance(GameObject.Find("Autoclave 1").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && nnn && intcount1 == 1)
        {
            GameObject.Find("Autoclave 1").GetComponent<Animator>().enabled = true;
            fire_start_time = Time.time;
            intcount1 = 2;
        }

        if (Time.time - fire_start_time > 1.5f && intcount1 == 2)
        {
            fakexelshi.SetActive(false);

            fire_start_time = 0;
            am = 12;

        }



    }



    bool b7 = true; bool cvlad = false;

    void mecamete()  // macivari
    {
        if (Vector3.Distance(GameObject.Find("Autoclave 1").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Autoclave 1").GetComponent<Animator>().SetBool("b", true);
            if (b7)
            {
                fire_start_time = Time.time; b7 = false; cvlad = true;
            }
        }

        if ((Time.time - fire_start_time) > 2 && cvlad)
        {
            // fake.SetActive(true);
            //fakemacivarshi.SetActive(false);



            fakemacivarshi.SetActive(false);
            fakexelshi.SetActive(true);
            am = 13;

        }






    }

    public GameObject fakemacivarshi;

    public GameObject fakexelshi;



    void metotxmete()
    {
        if (Vector3.Distance(GameObject.Find("axali mac").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && Input.GetKeyDown(KeyCode.E))
        {


            GameObject.Find("axali mac").GetComponent<Animator>().enabled = true;

            am = 14;



        }



    }
    public GameObject fakerealmacivarsi;
    bool f = true;

    bool dro = true;
    void metxutmete()

    {

        if (Vector3.Distance(GameObject.Find("axali mac").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && Input.GetKeyDown(KeyCode.E) && dro)
        {

            fire_start_time = Time.time;
            GameObject.Find("axali mac").GetComponent<Animator>().enabled = true; dro = false;



        }

        if ((Time.time - fire_start_time) > 2)
        {
            fakexelshi.SetActive(false);
            fakerealmacivarsi.SetActive(true);
            am = 15;
        }





    }

    bool n = true;
    void teqvsmeti()
    {


        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Laminur_box (1)").GetComponent<Animator>().enabled = true;

            if (n)
            {
                fire_start_time = Time.time; n = false;
                am = 16;
            }
        }




    }


    void chvidmeti()
    {

        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E) && (Time.time - fire_start_time > 0.7))
        {
            GameObject.Find("Laminur_box (1)").GetComponent<Animator>().SetBool("daketva", true);

            am = 17;
        }
    }

    int n1 = 0;
    public Text gil;





    public GameObject l;

    void tvrameti()
    {
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))
        {

            l.SetActive(true);


            if (n1 == 0)
            {
                fire_start_time = Time.time; n1 = 1;
            }

        }

        if (Time.time - fire_start_time < 30 && n1 == 1)
        {


            string s = (Time.time - fire_start_time).ToString();
            if (s[1] == '.') { gil.text = s[0].ToString(); }
            else
            {

                gil.text = s[0].ToString() + s[1].ToString();
            }
        }

        if ((Time.time - fire_start_time) > 30)
        {
            l.SetActive(false);
            gil.enabled = false;
            am = 18;
        }

    }


    void cxrameti()
    {
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))
        {


            GameObject.Find("Laminur_box (1)").GetComponent<Animator>().SetBool("air", true);
            fire_start_time = 0;
            am = 19;
        }

    }

    int asss = 0;
    bool coint3 = true;

    public GameObject botlebi777;
    bool boo1 = true;
    bool boo = true;


    int temp_h = 0;

    public Text tempkarnaxi;
    void oci()
    {

       
        if(temp_h == 0)
            {
            Debug.Log("logging");

            if (Vector3.Distance(GameObject.Find("axali mac").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && Input.GetKeyDown(KeyCode.E))
            {

                Debug.Log("logging1");
                fire_start_time = 0;

                GameObject.Find("axali mac").GetComponent<Animator>().SetBool("b", true); coint3 = false;

                fire_start_time = Time.time;
               
            }

            if (coint3 == false && (Time.time - fire_start_time) > 1.5f)
            {

                Debug.Log("logging2");
                fire_start_time = Time.time;
                fakexelshi.SetActive(true);
                fakerealmacivarsi.SetActive(false);
                asss = 1;

            }


            if (asss == 1)
            {
                Debug.Log("logging3");
                GameObject.Find("axali mac").GetComponent<Animator>().SetBool("datetva", true);


                if (Time.time - fire_start_time > 1)
                {
                    Debug.Log("logging4");
                    GameObject.Find("axali mac").GetComponent<Animator>().SetBool("datetva", false); fire_start_time = 0;
                    temp_h = 1;
                }
            }
            
        }


        else if (temp_h == 1)

        {
           

            if (Vector3.Distance(GameObject.Find("microwave_BI").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))  // iwres xelshi da miaqsv magidaze sadac tavisit chndeba petris jamebi
            {

                Debug.Log("logging5");
                Debug.Log("111");
                GameObject.Find("microwave_BI").GetComponent<Animator>().enabled = true;
                botlebi777.SetActive(true);
                fakexelshi.SetActive(false);


                if (boo1)
                {
                    fire_start_time = Time.time; boo1 = false;

                    Debug.Log("222");
                }


            }

            if ((Time.time - fire_start_time) > 3 && boo1 == false)
            {

                Debug.Log("333");
                temp_h = 2;
            }


            
        }



       else if(temp_h==2)
        {
            if (Vector3.Distance(GameObject.Find("microwave_BI").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))  // iwres xelshi da miaqsv magidaze sadac tavisit chndeba petris jamebi
            {

                Debug.Log("444");

                if (boo)
                {

                    Debug.Log("555");

                    GameObject.Find("microwave_BI").GetComponent<Animator>().SetBool("b", true);
                    fire_start_time = Time.time; boo = false;
                }

                if ((Time.time - fire_start_time) > 3 && Input.GetKeyDown(KeyCode.E))
                {

                    Debug.Log("666");
                    botlebi777.SetActive(false);
                    fakexelshi.SetActive(true);
                    tempkarnaxi.text = "Put sterile plastic or glass Petri dishes and melted media in the laminar box.";
                   
                }


            }


            if(Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))
            {
                am = 22;
            }

        }


    
}



    public GameObject gap;
    public GameObject gap1;


    public GameObject gamt;
    public GameObject anim33;

    bool c3 = true;
    bool ukve = true;
    void ocdasami()
    {
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2)
        {


            if (ukve)
            {
                anim33.GetComponent<Animator>().SetBool("bool33", true);  ukve = false;
            }

           if(Time.time-fire_start_time >0.5f)
            {
                anim33.GetComponent<Animator>().SetBool("bool33", false);
            }

            gamt.SetActive(true);
            fakexelshi.SetActive(false); 

            //  gap.SetActive(true);
            //  gap1.SetActive(true);
            if(c3)
            {
                fire_start_time = Time.time; c3 = false;
            }

         

            GameObject.Find("petrisjamebi").SetActive(true);

            if(Time.time -fire_start_time >2  && Input.GetKeyDown(KeyCode.E))
            {
                anim33.GetComponent<Animator>().SetBool("bool33", false);
                Debug.Log("here");
                am = 23;
            }



           

        }

    }


    void ocdaotxi()
    {
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2)
        {

            GameObject.Find("petrisjamebi").GetComponent<Animator>().enabled = true;

            am = 24;
        }


    }

    public GameObject kalami;

    void ocdaxuti()
    {
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2  && Input.GetKeyDown(KeyCode.E))
        {
            kalami.SetActive(true);
            am = 25;

        }


    }

    public GameObject mtliani;

    public GameObject macivarshio;

    bool b45 = false;
    public Text t45; 
    public Text t145;

    void ocdaeqvsi()
    {

        
        if (Vector3.Distance(GameObject.Find("Laminur_box (1)").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 2 && Input.GetKeyDown(KeyCode.E))
        {
            mtliani.SetActive(false);
        }


        if (Vector3.Distance(GameObject.Find("axali mac").transform.position, GameObject.Find("axaliobjectm1").transform.position) < 1.5 && Input.GetKeyDown(KeyCode.E))
        {
            macivarshio.SetActive(true);

            GameObject.Find("axali mac").GetComponent<Animator>().SetBool("mgageba", true);
            fire_start_time = Time.time;
            b45 = true;

        }



        if(b45)          // pasuxebis ghamotana
        {



            if(Time.time-fire_start_time >0.6)
            {
                GameObject.Find("axali mac").GetComponent<Animator>().SetBool("mgageba", false);
            }
            

            if(lis[0]=="52")
            {
                t45.color = Color.green;
                t45.text = " Your answer : " + lis[0] + " Correct answer 52 ";
            }

            else
            {
                t45.color = Color.red;
                t45.text = " Your answer : " + lis[0] + " Correct answer 52 ";
            }




            if (lis[1] == "2" || lis[1]=="3")
            {
                t145.color = Color.green;
                t145.text = " Your answer : " + lis[1] + " Correct answer 52 ";
            }

            else
            {
                t145.color = Color.red;
                t145.text = " Your answer : " + lis[1] + " Correct answer 52 ";
            }


        }



    }
        /*

        IEnumerator  im ()
        {

              // funqciashi idzaaxebs !!  StartCoroutine("im");
            yield return new WaitForSeconds(15);

        }

        */
        //


        //

        // tepshi 0
        int temp = 0;

    public Animator playeranim1;
    void tefshi()
    {

        playeranim1.SetBool("nivtisageba", true);
        GameObject ga;
        ga = GameObject.Find("rightIK");

        if (temp == 0)
        {
            ga.GetComponent<axamocana>().enabled = true;
            temp++;
        }

        if (temp == 1)
        {
            ga.GetComponent<awonva>().enabled = true;
            temp++;

        }
        /*
        if (temp == 2)
        {
             ga.GetComponent<niadagis>().enabled = true;
        }
        */
    }



    // tepshi 1

    // wyali 0

    public bool WylisGadasxmadarulda = false;
    void wyali()
    {

        GameObject.Find("distwater").GetComponent<PirveliAnim>().enabled = true;
        if (WylisGadasxmadarulda)
        {
            am++;
        }
    }


    void inverswyali()   //  gamortavs  pirvelianims (distwater), gamortavs DasruebisMereZrdisamS s (Cylinder.002) 
    {
        GameObject.Find("distwater").GetComponent<PirveliAnim>().enabled = false;
        GameObject.Find("Cylinder.002").GetComponent<DasruebisMereZrdisamS>().enabled = false;
    }


    // wyali 1



    void box()
    {
        GameObject ga;
        ga = GameObject.Find("yuti");
        ga.GetComponent<BoxOpen>().enabled = true;


    }

    void MosadugebladGadatana()
    {
        GameObject ga;
        ga = GameObject.Find("menzura");
        ga.GetComponent<moduGeba>().enabled = true;
    }

    //
    public GameObject wkiri;
    public Text ti;
    void RealMosadugebladGadatana()   // mtlianad aq aris
    {


        Debug.Log("kodi gaeshavaa");
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("menzura").GetComponent<Animator>().enabled = true;

            GameObject.Find("menzura").GetComponent<Animator>().SetBool("MenzurisPlitazeDadeba", true);

            wkiri.SetActive(true);

            GameObject.Find("Heater").GetComponent<Animator>().enabled = true;

            ti.text = "Enter Time";


        }


        if (M == "2" || M == "3")   // ????? ???? 2 ?? 3 ???? wonis shetanisgas unda gasuftavdes , shemdegi funqciis gaswyishi unda gasuftavdes M -i 
        {
            wkiri.SetActive(false);

            ti.text = "";
            am++; Debug.Log("input55555");
        }

    }
    //

    // public GameObject menzura;





    void Moreva()
    {
        GameObject ga;
        ga = GameObject.Find("wkiri");
        ga.GetComponent<moreva>().enabled = true;


    }











    public void input(string guest)  // yoveli sheyvanis shendeg gadaiwereba sxva cvladshi da tviton gasuftavdeba 
    {
        M = guest;

        Debug.Log(M);

    }






}
/*
 * IEnumerator Example()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(5);
        Debug.Log(Time.time);
    }
*/
