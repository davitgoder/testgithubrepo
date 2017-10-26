using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class petrin : MonoBehaviour {


    public int quantity = 0;

    public GameObject mycamera;

    public GameObject sasworistavi;

    public GameObject sasworistexts;


    public GameObject spoom;

    void Start ()
    {
        mycamera = Camera.main.gameObject;
	}
	
	void Update ()
    {


        func();
	}

    public int locstate=0;

    public bool informmain = false;

    public void func()
    {
        switch(locstate)
        {
            case 0:

                gameObject.GetComponent<Animator>().SetTrigger("t1");


                if (mycamera.GetComponent<Raycast>().GetHoldname().name == gameObject.name)
                {
                    locstate = 1;
                }
                    break;


            case 1:


                    gameObject.GetComponent<Animator>().SetTrigger("t2");

                if (mycamera.GetComponent<Raycast>().GetHoldname().name == sasworistavi.name)
                {
                    locstate = 2;
                }


                    break;




            case 2:

                gameObject.GetComponent<Animator>().SetTrigger("t3");

                sasworistexts.GetComponent<TextMeshPro>().text = 20.ToString();


                if (mycamera.GetComponent<Raycast>().GetHoldname().name == "Zero Out")
                {
                    locstate = 3;
                }



                    break;



            case 3:

                sasworistexts.GetComponent<TextMeshPro>().text = 0.ToString();

                informmain = true;


                break;


        }


    }


}
