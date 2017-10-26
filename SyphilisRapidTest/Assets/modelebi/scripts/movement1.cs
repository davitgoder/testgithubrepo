using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 using TMPro;

public class movement1 : MonoBehaviour {

    
    public GameObject paketi, makrateli, Comb, parent, combfake, imunocomb;
    public GameObject numbertext;
    public GameObject[] imuno; 
    void Start ()
    {
		imuno = GameObject.FindGameObjectsWithTag("imuno");
        imononumber();
    }
	
	void Update ()
    {
        
        stateM();        

	}

    int imunonumbers;
    void imononumber()
    {
        foreach (GameObject ga in imuno)
        {
            ga.AddComponent<number>().n=imunonumbers++;


        }
    }

  


    public int state=0;

    private bool mak = false;
    private bool pac = false;

    Color original;


    private GameObject CombChangeColor;


    public List<GameObject> anims = new List<GameObject>();
   
    public int SelectedNumber=0;

    
    bool temp= true;


   public List<GameObject> imunocombplate = new List<GameObject>();
    int imunocombselnumber=0;
    void stateM()
    {
        //GetComponent<MeshRenderer>().material.color = Color.green;
       
        switch (state)
        {


            case 0:

                if (gameObject.GetComponent<movement>().GetHoldName().name == paketi.name && !pac)
                {
                    paketi.GetComponent<Animator>().SetTrigger("up");
                    pac = true;

                }

                if (gameObject.GetComponent<movement>().GetHoldName().name == makrateli.name && !mak)
                {
                    makrateli.GetComponent<Animator>().SetTrigger("up");
                    mak = true;
                }


                if (pac && mak)
                {
                    state = 1;
                }


                break;

            case 1:

                if (gameObject.GetComponent<movement>().GetHoldName().name == paketi.name)
                {
                    makrateli.GetComponent<Animator>().SetTrigger("gachra");
                    paketi.GetComponent<Animator>().SetTrigger("gachra");

                    state = 2;
                }

                break;

            case 2:

                if (gameObject.GetComponent<movement>().GetHoldName().name == Comb.name)
                {
                    paketi.GetComponent<Animator>().SetTrigger("combup");

                    Comb.GetComponent<BoxCollider>().enabled = false; // mtliaqni obiewti box collideri



                    for (int i = 0; i < Comb.transform.childCount; i++)
                    {
                        if (Comb.transform.GetChild(i).gameObject.GetComponent<BoxCollider>())
                            Comb.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().enabled = true;


                        original = Comb.transform.GetChild(2).GetComponent<MeshRenderer>().material.color;
                    }

                    state = 3;
                }


                break;

            case 3:


                numbertext.SetActive(true);
                for (int i = 0; i < 11; i++) // number
                {

                    if (gameObject.GetComponent<movement>().Getname().GetComponent<number>())
                    {
                       
                        if(gameObject.GetComponent<movement>().Getname().GetComponent<number>())
                        for(int k =0; k<=gameObject.GetComponent<movement>().Getname().GetComponent<number>().n; k++)
                            {
                                if(Comb.transform.GetChild(k).gameObject.GetComponent<number>())
                                {

                                    Comb.transform.GetChild(k).gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                                    numbertext.transform.position = Camera.main.WorldToScreenPoint(Comb.transform.GetChild(k).gameObject.transform.position);
                                }
                                SelectedNumber = k;
                                numbertext.GetComponent<Text>().text = SelectedNumber.ToString();
                             
                               

                            }


                        for (int k = gameObject.GetComponent<movement>().Getname().GetComponent<number>().n; k < 12; k++)
                        {
                            if (Comb.transform.GetChild(k).gameObject.GetComponent<number>())
                            {
                                Comb.transform.GetChild(k).gameObject.GetComponent<MeshRenderer>().material.color = original;

                            }


                        }


                    }



                    if(SelectedNumber >1 && Input.GetMouseButtonDown(0))
                    {
                        paketi.GetComponent<Animator>().enabled = false;

                        for (int j = 0; j < SelectedNumber; j++)
                        {
                            if (Comb.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material.color == Color.green)
                            {

                              
                                    Comb.transform.GetChild(j).gameObject.SetActive(false);
                               
                                    combfake.transform.GetChild(j).gameObject.SetActive(true);

                               
                                // Comb.transform.GetChild(i).gameObject.transform.parent = parent.transform;

                            }

                        }
                        paketi.GetComponent<Animator>().enabled = true;
                        paketi.GetComponent<Animator>().SetTrigger("combisdadeba");
                        combfake.GetComponent<Animator>().SetTrigger("faketotable");
                        state = 4;
                    }





                }
                break;


            case 4:

                Comb.GetComponent<BoxCollider>().enabled = false;
                for (int k = 0; k <= gameObject.GetComponent<movement>().Getname().GetComponent<number>().n; k++)
                {
                    if (Comb.transform.GetChild(k).gameObject.GetComponent<number>())
                    {
                        Comb.transform.GetChild(k).gameObject.GetComponent<MeshRenderer>().material.color = original;

                    }
                    SelectedNumber = k;


                    }


                    state = 5; // infutis gareshe gadadsis


                break;


            case 5:

                numbertext.SetActive(false);
             //   paketi.GetComponent<Animator>().SetInteger("i", SelectedNumber++);

                state = 6;

                break;


            case 6:

             


                if(gameObject.GetComponent<movement>().GetHoldName() == imunocomb && temp)
                {
                    imunocomb.GetComponent<Animator>().enabled = true;
                   
                }

                if( gameObject.GetComponent<movement>().Getname().tag == "imuno")
                {
                    okbutton.SetActive(true);
                    numbertext.SetActive(true);
                    numbertext.transform.position =
                    Camera.main.WorldToScreenPoint(gameObject.GetComponent<movement>().Getname().transform.position);



                   

                    gameObject.GetComponent<movement>().Getname().GetComponent<MeshRenderer>().material.color = Color.green;
                    if(!imunocombplate.Contains(gameObject.GetComponent<movement>().Getname()))
                    {

                        imunocombplate.Add(gameObject.GetComponent<movement>().Getname());
                        imunocombselnumber++;

                        numbertext.GetComponent<Text>().text = imunocombselnumber.ToString();
                    }

               

                   
                }




                break;

            case 7:
              //  perforatori.transform.Translate(imunocombplate[0].transform.position * Time.deltaTime);
                 


                if (!timeset&&gameObject.GetComponent<movement>().GetHoldName() == perforatori)
                {


                  //  perforatori.transform.position = Vector3.Lerp(perforatori.transform.position, imunocombplate[0].transform.position, Time.deltaTime/5);
                    perforatori.GetComponent<Animator>().SetTrigger("reset");

                    animtime = Time.time;

                    timeset = true;
                }

               if(timeset && Time.time - animtime >3)
                {
                   for(int i=0; i< imunocomb.transform.childCount; i++)
                    {
                        if(imunocomb.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material.color == Color.green)
                        {
                            imunocomb.transform.GetChild(i).gameObject.SetActive(false);
                        }
                    }

                    imunocomb.GetComponent<Animator>().SetTrigger("toeye");

                    state = 8;
                }




                break;

            case 8:
                imunocomb.GetComponent<Animator>().SetTrigger("totable");
                perforatori.GetComponent<Animator>().SetTrigger("ss");



                break;


        }


     
        


        }

    public int imunocount = 0;

    float animtime; bool timeset= false; int mim;

    public GameObject perforatori;

    public GameObject okbutton; 
    public void okpress()
    {
        imunocomb.GetComponent<Animator>().SetTrigger("totable");

        numbertext.SetActive(false);
        state = 7;
        
    }


   }




