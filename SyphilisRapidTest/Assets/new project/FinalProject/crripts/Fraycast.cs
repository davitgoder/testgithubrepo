using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class Fraycast : MonoBehaviour
{

    Ray ray;

    public RaycastHit hit; 
    public GameObject locfind;

    bool searche = true;

    public bool state1 = false;

    public GameObject LocfindHold;

    public bool GrabBool= true;
    public GameObject grabbedOnmouseDown;


    public int DetectFunction(GameObject locgrabbed, GameObject reflected)
    {

        if(locgrabbed != null)
        if (locgrabbed.GetComponent<BaseClass>() && ReflectedObject.GetComponent<BaseClass>())
        {


            switch (locgrabbed.GetComponent<BaseClass>().ObjectName + reflected.GetComponent<BaseClass>().ObjectName)
            {
                case "Cubep":

                    Debug.Log("gamodazxe");

                    locgrabbed.GetComponent<BaseClass>().rotate();
                     
                    break;

                case "Cubef":

                    locgrabbed.GetComponent<BaseClass>().place(reflected);



                    break;



            }

        }

        return 0;
    }

    void Update()
    {



        if (GetName() != null)
        {
            if (Input.GetMouseButtonDown(0) && GrabBool && GetName().tag == "g")
            {
                grabbedOnmouseDown = GetName();
                GrabBool = false;
            }
        }


        if(!GrabBool)
        {


            grab(grabbedOnmouseDown);    // grabbedOnmousedownbs da RfelecdetObject

            reflect(grabbedOnmouseDown);


            if(ReflectedObject!= null && Input.GetMouseButtonDown(0))
            {
                StartDeterminieFunction = true;
             
              //  DetectFunction(grabbedOnmouseDown, ReflectedObject);

            }

            if(StartDeterminieFunction)
            {
                DetectFunction(grabbedOnmouseDown, ReflectedObject);

            }

        }


    }

    public bool StartDeterminieFunction;

     void Start()
    {
        ray = new Ray();
    }





    

    public GameObject GetName()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //ray.origin = Camera.main.transform.position;

        //ray.direction = Camera.main.ScreenToWorldPoint(Input.mousePosition); 


        if (Physics.Raycast(ray, out hit, 1000))
        {
            locfind = hit.transform.gameObject;
            Debug.DrawLine(ray.origin, hit.point, Color.blue);
          


        }


     
        if (locfind != null)
        {
            Debug.Log(locfind.name);
            return locfind;
        }

        return null;
    }




    RaycastHit ReflectHit;
    public GameObject ReflectedObject;

    Ray ray1;


    public GameObject reflect(GameObject reflect) // migebul obieqtidan agzavnis sxivs
    {

        if(reflect != null)
        ray1.origin = reflect.transform.position;
        ray1.direction = Camera.main.ScreenPointToRay(Input.mousePosition).direction;  // pirelis sxcivis mimartuleba

        if (Physics.Raycast(ray1, out ReflectHit, 20))
        {



            ReflectedObject = ReflectHit.transform.gameObject;


            Debug.DrawLine(ray1.origin, ReflectHit.point, Color.green);


            if(ReflectedObject.GetComponent<Animator>())
            {

                ReflectedObject.GetComponent<Animator>().SetTrigger("color");

            }

        }






        if (ReflectedObject != null)
        {
            if(ReflectedObject.name == "PS")
            {
                ReflectedObject.GetComponent<MeshRenderer>().enabled = true;

            }


            return ReflectedObject;
        }


        return null;



    }

    public GameObject grabbed;
    void grab(GameObject newgra)
    {
        grabbed = newgra;
        if (grabbed != null && grabbed.tag == "g")
            grabbed.transform.position = new Vector3(cursorWorldPosOnNCP.x, cursorWorldPosOnNCP.y, cursorWorldPosOnNCP.z);

    }



    private string cstring = "pCube";




    public static Vector3 cursorWorldPosOnNCP
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane + 1));
        }
    }

    private static Vector3 cameraToCursor
    {
        get
        {
            return cursorWorldPosOnNCP - Camera.main.transform.position;
        }
    }

    private Vector3 cursorOnTransform
    {
        get
        {
            Vector3 camToTrans = transform.position - Camera.main.transform.position;
            return Camera.main.transform.position +
                cameraToCursor *
                (Vector3.Dot(Camera.main.transform.forward, camToTrans) / Vector3.Dot(Camera.main.transform.forward, cameraToCursor));
        }
    }



    //enumeratori

    bool en = true;
    float tm = 0;

    bool TM(float val)
    {
        if (en)
        {
            tm = Time.time;
            en = false;
        }
        if (Time.time - tm >= val)
        {
            en = true;
            return true;
        }
        else
            return false;

    }



}




