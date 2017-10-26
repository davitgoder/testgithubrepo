using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {




    public GameObject mycamera;

    public Vector3 StartMousePos;
    public Vector3 ffgh;

    public float UpConst = 185.2973f;
    public float DonwConst = 84.72729f; 

    public Vector3 v = new Vector3(270.0f, 86.2f, 0.0f);

    private void Start()
    {
        mycamera = Camera.main.gameObject;
    }

    public GameObject ga;

    void Update()
    {


        





        if(Input.GetMouseButtonDown(0))
        {
            ga = mycamera.GetComponent<Raycast>().GetName();

        }
        if(Input.GetMouseButtonUp(0))
        {
            ga = null;

        }
        if(Input.GetKey("mouse 0") && ga == gameObject )
        {
            OtherDoor();
        }

     


    } // update 


   

   

    public void OtherDoor()
    {

        if (gameObject.tag == "OtherDoor")
        {
            

            if (Input.GetMouseButtonDown(0))
            {

                StartMousePos = Input.mousePosition;
                CheckBool = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                CheckBool = false;  // sawiroa gamuleba raime xerxit !!

            }


            if (CheckBool)
            {
                //   float TempFloat = Vector3.Magnitude(StartMousePos - Input.mousePosition); //varianti 1 


                float TempFloat = StartMousePos.x - Input.mousePosition.x; // varianti 2
                TempFloat /= 100;




                ffgh = gameObject.transform.rotation.eulerAngles;



                if (ffgh.y > DonwConst && ffgh.y < UpConst)
                {
                    gameObject.transform.RotateAround(gameObject.transform.position, Vector3.up, TempFloat);
                }
                else
                {

                    // gameObject.transform.RotateAround(gameObject.transform.position, Vector3.up, -TempFloat);


                    Quaternion q = new Quaternion(); q.eulerAngles = v;
                    gameObject.transform.rotation = q;
                }






            }

        }
        else if(gameObject.tag == "laminar box")
        {
            LaminarDoor();

        }


    }


    public void rotate()
    {

    }


    public bool CheckBool = false;

 


    public void LaminarDoor()
    {

        if (Input.GetMouseButtonDown(0))
        {
            CheckBool = true;

            StartMousePos = Input.mousePosition;

        }

        if (Input.GetMouseButtonUp(0))
        {
            CheckBool = false;  // sawiroa gamuleba raime xerxit !!

        }


        if (CheckBool)
        {
             //  float TempFloat = Vector3.Magnitude(StartMousePos - Input.mousePosition); //varianti 1 
             float TempFloat = StartMousePos.y - Input.mousePosition.y; // varianti 2
            float tt = gameObject.transform.position.y - TempFloat / 5000;


            Vector3 TempV = new Vector3(gameObject.transform.position.x, tt, gameObject.transform.position.z);

            
            
                gameObject.transform.position = TempV;
           

        }


    }


 
}
