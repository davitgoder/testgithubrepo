using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewRaysdasu : MonoBehaviour
{


    
    public GameObject[] ListOfPlasebleObjects;  // boxebi tagit place


    Ray ray;
    float range = 10;
    public RaycastHit hit;
    public GameObject locfind;

    bool searche = true;

    public bool state1 = false;

    public GameObject LocfindHold;

    public bool permission = false;


    public GameObject reflect1;

    public GameObject CklickedObjectWichhasTag_g;

    /// <summary>
    ///  skripti iyenebs state machins 
    ///  state_1 elodeba inputs
    ///  stae_2 miigo pirveli obiuecti da elodeba revleqtnames romelzec mousedwonis shemtxvevashi axrulebs moqmedeba s da brindeba state 0 shi
    /// </summary>
    /// 


    void Awake()
    {
        ListOfPlasebleObjects = GameObject.FindGameObjectsWithTag("place");

    }



    
   

    public Vector2 MousePositionAtCklickedTime = Vector2.zero;

    
    void Update()
    {




        if(GetName().tag == "place")   // lurji sxivis gadatarebisas gamortavs yubetis kolaiders!!!  
        {
            GetName().GetComponent<BoxCollider>().enabled = false;

        }


        if (GetName().tag == "g") // mshobeli klasis cvladidna igebs g - is
        {
           

            if (Input.GetMouseButton(0))
            {
                CklickedObjectWichhasTag_g = GetName();
                foreach (GameObject ga in ListOfPlasebleObjects)
                {
                    ga.GetComponent<BoxCollider>().enabled = true;

                }



            }


        }


        if(CklickedObjectWichhasTag_g != null) // grabbing
        {

            grab(CklickedObjectWichhasTag_g);

             

          GameObject  ReflectedObject = reflect(CklickedObjectWichhasTag_g);  



            if (ReflectedObject.tag == "place") // mxolod boxebs aqvs es tagi
            {


             
                if(Input.GetMouseButtonDown(0))
                {
                   
                    CklickedObjectWichhasTag_g.GetComponent<AbsClass>().PlaseObjectInsade(ReflectedObject);


                    CklickedObjectWichhasTag_g = null;

                }




            }

            else
            {

                ControRotation(v2, ReflectedObject);

                if(ReflectedObject.GetComponent<AbsClass>())  // amowmebs obieqts aqvs tu ara abbsclass
                {

                  switch(ReflectedObject.GetComponent<AbsClass>().intag)
                    {
                        case "rotate":


                            if(Input.GetMouseButtonDown(0))
                            {
                                v2 = Input.mousePosition;
                                permiss = true;
                            }
                           



                            break;








                    }





                }






            }



        }

}


    Vector2 v2 = new Vector2();  // es ori cvlasdi gadaecema ControlRotataion s
    bool permiss = false;
     
    void ControRotation(Vector2 CklickedPoint, GameObject ReflectedObject)
    {

        if(permiss)
        {

            CklickedObjectWichhasTag_g.GetComponent<AbsClass>().rotate(v2, ReflectedObject);



        }



    }



   








    public GameObject GetHoldName()
    {


        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Vector3 position = gameObject.transform.position;

        Vector3 m = Input.mousePosition;




        Vector3 target = (gameObject.transform.forward + m) * range;






        if (Physics.Raycast(ray, out hit, 10))
        {
         

            locfind = hit.transform.gameObject;


            Debug.DrawLine(ray.origin, hit.point, Color.blue);


        }


        if (locfind != null && Input.GetKey(KeyCode.Mouse0))
        {
            LocfindHold = locfind;
            return LocfindHold;
        }
        else
            LocfindHold = null;



        return null;
    }



    RaycastHit hittt;
    public GameObject ObjectTahtHasBeenReturnedFrom__Reflectname;

    Ray ray1;


    public GameObject reflect(GameObject reflect) // migebul obieqtidan agzavnis sxivs
    {

        // ray1  = Camera.main.ViewportPointToRay(reflect.transform.position);
        
        ray1.origin = reflect.transform.position;

        // ray1.direction = new Vector2( Input.mousePosition.x *10, Input.mousePosition.y);
        ray1.direction = Camera.main.ScreenPointToRay(Input.mousePosition).direction;  // pirelis sxcivis mimartuleba






        if (Physics.Raycast(ray1, out hittt, 20))
        {
           


            ObjectTahtHasBeenReturnedFrom__Reflectname = hittt.transform.gameObject;


            Debug.DrawLine(ray1.origin, hittt.point, Color.green);


        }


    



        if(ObjectTahtHasBeenReturnedFrom__Reflectname != null)
        {
            return ObjectTahtHasBeenReturnedFrom__Reflectname;
        }


        return null;

       

    }














    public GameObject GetName()
    {

     

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);




       






        if (Physics.Raycast(ray, out hit, 1000))
        {
            //Debug.DrawLine(ray.origin, hit.point, Color.red);


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


  public  GameObject grabbed;


    public GameObject Reflectname;

    void grab(GameObject newgra)
    {
        

            grabbed = newgra;

            if (grabbed != null)
                grabbed.transform.position = new Vector3(cursorWorldPosOnNCP.x, cursorWorldPosOnNCP.y, cursorWorldPosOnNCP.z);


            //if (grabbed != null)
            //{
            //    gameObject.GetComponent<LineRenderer>().SetPosition(0,  /*new Vector3(hit1.point.x, hit1.point.y +10, hit1.point.z)*/   new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 1, Camera.main.transform.position.z));
            //    gameObject.GetComponent<LineRenderer>().SetPosition(1, hit1.point);

            //}




            //ray1 = new Ray(grabbed.transform.position, ray.direction);


            //if (Physics.Raycast(ray1, out hit1, 10))
            //{


            //    Reflectname = hit1.transform.gameObject;
            //    Debug.Log("namesdsdsdsd" + hit1.transform.gameObject.name);


            //}



    }


    


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




