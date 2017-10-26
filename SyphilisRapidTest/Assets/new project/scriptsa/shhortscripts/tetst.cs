using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tetst : MonoBehaviour
{

    public bool CorrectAmount = false;

    public GameObject other;

    public int state = 0;


    public GameObject part;

    public GameObject g;
    public GameObject g1;

    int a;
    Vector3 temp, temp1;

    public bool savse = false;
    public GameObject part2;

    float time = 0;


    public GameObject ca;

    float tim = 0;

    public bool holding = false;

    public GameObject didicilindri;

    public GameObject pataracilindri;

    public Slider slider;
    public GameObject sliderobject;


  
    void Start()
    {


    }




    public float va = 0;

    public GameObject b;

    void Update()
    {

        if (pataracilindri.transform.localScale.z < 1.5f && 1.25f < pataracilindri.transform.localScale.z)
        {

          
            CorrectAmount = true;
            b.SetActive(true);
            Sliderhandel.GetComponent<Image>().color = Color.green;
        }
        else
        {
            
            CorrectAmount = false;

            b.SetActive(false);
            Sliderhandel.GetComponent<Image>().color = Color.red;
        }






        








        temp1 = g1.transform.localScale;
        temp = g.transform.localScale;

        if (other.GetComponent<tetst>().holding == false)
        {
            switch (state)
            {
                case 0:

                    b.SetActive(false);

                    holding = false;

                    gameObject.GetComponent<Animator>().SetInteger("s", -1);

                    if (ca.GetComponent<NewRaysdasu>().locfind.name == gameObject.name && Input.GetMouseButtonDown(0))
                    {

                        holding = false;
                        tim = Time.time;
                        state = 1;


                    }


                    break;

                case 1:


                    holding = true;

                    gameObject.GetComponent<Animator>().SetInteger("s", 0);




                    if (ca.GetComponent<NewRaysdasu>().locfind.name == other.name && Input.GetMouseButtonDown(0))
                    {
                        tim = Time.time;
                        state = 2;
                    }



                    if (Time.time - tim > 2)
                        state = 0;










                    break;


                case 2:






                    part.SetActive(true);
                    gameObject.GetComponent<Animator>().SetInteger("s", 1);

                    if (Time.time - tim > 2)
                        wyali();

                    if (Input.GetMouseButtonUp(0))
                    {
                        part.SetActive(false);

                        tim = Time.time;
                        state = 1;
                    }






                    break;


                case 3:





                    part2.SetActive(true);
                   
                    
                    if (Time.time - tim > 2)
                    {

                       


                        part2.SetActive(false);

                        tim = Time.time;
                        state = 1;
                    }

                    break;



                case 4:



                    break;

            }

        }





    }



    public float timer = 0;


    public bool p = false;

    public GameObject M;
    public GameObject Sliderhandel;


   


    void wyali()
    {




     
        
  


        if (5.5f - Mathf.Abs(timer) < 0.5f && 5.5f - Mathf.Abs(timer) > -0.4)
        {
            savse = true;
        }
        else
        {
            savse = false;
        }


        //Vector3 tem = pataracilindri.transform.localScale;
        //tem.z = 1.785052f;
        //pataracilindri.transform.position = tem;
        //Debug.Log("+++++++" + pataracilindri.transform.localScale.z);
        //     if((pataracilindri.transform.localScale.z > 0.04813874f) && (pataracilindri.transform.localScale.z < 1.785051f))

        if (/*timer <= 7 ||*/(pataracilindri.transform.localScale.z > 0.04813875f) && (pataracilindri.transform.localScale.z < 1.785051f)  || p  )

        {
           

            p = false;


            if (Input.GetKey(KeyCode.Mouse0))

            {
                timer += Time.deltaTime;


                sliderobject.SetActive(true);

                if (gameObject.transform.GetChild(1).name == "cyl22" )
                {

                  

                    

                    temp1.z += Time.deltaTime / 4;
                    g1.transform.localScale = temp1;


                    temp.z -= Time.deltaTime / 20;
                    g.transform.localScale = temp;
                    slider.value +=  Time.deltaTime/6.992466f;

                  
                }
                else
                {



                
                    slider.value -= Time.deltaTime / 6.992466f;
                    temp1.z += Time.deltaTime / 20;
                    g1.transform.localScale = temp1;


                    temp.z -= Time.deltaTime / 4;
                    g.transform.localScale = temp;




                }
                part.SetActive(true);
            }
            else
            {

                sliderobject.SetActive(false);
                part.SetActive(false);
            }
        }
        else
        {

            M.GetComponent<tetst>().p = true;

            
        
            part.SetActive(false);
            tim = Time.time;
            state = 3;

        }



    }



}






//public void OnMouseDown()
//{


//    if(let)
//    {


//        state++;


//    }


//   let = false;


//}

//      if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("hold") &&
//               gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0)

//                {
//}