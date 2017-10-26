using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//if(GetName() != null && GetName().GetComponent<Base>())
//{
//    GetName().GetComponent<Base>().Acivate(gameObject);
//}
//else if(GetName() != null && GetName().GetComponent<Liquid>())
//{
//    Debug.Log("liqid");
//    GetName().GetComponent<Liquid>().Acivate(gameObject);

//}




public class Raycast : MonoBehaviour {

	
	void Start ()
    {
        ReflectedObject = new GameObject();
    }


    public GameObject GlobalGrabbed;
    public bool grabbed = false;

    public bool isrotataing = false;

    public Quaternion StartRot;
    public GameObject cube;

    public GameObject GlobalReflected;


    public GameObject go, ro;

    public void DesplayObnames()
    {
        if(GlobalGrabbed != null)
        {
            go.SetActive(true);
            go.transform.GetChild(0).gameObject.GetComponent<Text>().text = GlobalGrabbed.name;
        }
         if(GlobalGrabbed != null && GlobalReflected != null)
        {

            go.SetActive(true);
            go.transform.GetChild(0).gameObject.GetComponent<Text>().text = GlobalGrabbed.name;
            ro.SetActive(true);
            ro.transform.GetChild(0).gameObject.GetComponent<Text>().text = GlobalReflected.name;
             
        }
       else
        {

            go.SetActive(false);
            ro.SetActive(false);
        }


    }

	void Update ()
    {


        Debug.Log("getane " + GetName().name);


    }

    public void chslider()
    {
      
       slider.GetComponent<Slider>().transform.GetChild(0).gameObject.GetComponent<Text>().text = slider.GetComponent<Slider>().value.ToString();
    }

    public int grams;
    public GameObject slider;



    public GameObject petri;

    public void SpoonState(GameObject Spoon, GameObject ro)
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(ro.name == "Petri Dish")
            {
                if(Spoon.GetComponent<Name>().state == 0) // chayra  petrshi
                {
                  

                   

                    Spoon.GetComponent<Name>().Quantity -= slider.GetComponent<Slider>().value;
                    petri.GetComponent<Name>().Quantity = Spoon.GetComponent<Name>().Quantity;
                    Spoon.GetComponent<Name>().state = 1;
                   

                }
                else // amoyra petridan
                {



                    Spoon.GetComponent<Name>().Quantity += slider.GetComponent<Slider>().value;
                    petri.GetComponent<Name>().Quantity = Spoon.GetComponent<Name>().Quantity;
                    Spoon.GetComponent<Name>().state = 0;
                }


                Debug.Log("Petri");
            }

            if (ro.name == "Media Box")
            {

                if (Spoon.GetComponent<Name>().state == 0) // chayra  boxshi
                {

                    Spoon.GetComponent<Name>().Quantity += slider.GetComponent<Slider>().value;

                    Spoon.GetComponent<Name>().state = 1;
                }
                else   // amoyra boxsidan
                {

                    //Spoon.GetComponent<Name>().Quantity += slider.GetComponent<Slider>().value;

                    //Spoon.GetComponent<Name>().state = 0;
                }
                Debug.Log("media");


            }

        }


    }

    public  Ray ray;
    RaycastHit hit;

    public GameObject locfind;

    public bool BlockBool = false;

    public GameObject GetName(int RaycatsDistance=1000)
    {

        
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (!BlockBool)
        {



            if (Physics.Raycast(ray, out hit, 1000))
            {
                locfind = hit.transform.gameObject;
                Debug.DrawLine(ray.origin, hit.point, Color.blue);
            }

        }


        if (locfind != null)
        {
           
            return locfind;
        }

        return null;
    }




    Ray ray1;
    RaycastHit hit1;
    GameObject locfind1;

    public GameObject GetHoldname()
    {
        ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);

        //ray.origin = Camera.main.transform.position;

        //ray.direction = Camera.main.ScreenToWorldPoint(Input.mousePosition); 


        if (Physics.Raycast(ray1, out hit1, 1000))
        {
            locfind1 = hit1.transform.gameObject;
            Debug.DrawLine(ray.origin, hit1.point, Color.blue);
        }



        if (locfind1 != null && Input.GetMouseButtonDown(0))
        {
         
            return locfind1;
        }

        return null;
    }




    ///// new 












    public void grab(GameObject ga)
    {

        ChangeColor(ga, 2);
        ga.transform.position = cursorWorldPosOnNCP;

    }

    public void place(GameObject place, GameObject inside)
    {

     
        place.transform.position = inside.transform.position;
       
        place = null;
        inside = null;

    }

    public void LiquidPour(GameObject pour, GameObject inside)
    {

        LiquidLevel(pour, inside);

        // Rotate(pour);

    }

    public void LiquidLevel(GameObject pour, GameObject inside)
    {

        //   pour.transform.localScale = new Vector3(1,4,1);
        Transform t = pour.transform.GetChild(0).transform;

        t.localScale = new Vector3(t.localScale.x, t.localScale.y, 
            Mathf.MoveTowards( t.transform.localScale.z, 0.02198826f,  Time.deltaTime * 0.1f));

        pour.GetComponent<Name>().Quantity -= Time.deltaTime * 0.15f;

        Transform t1 = inside.transform.GetChild(0).transform;

        t1.localScale = new Vector3(t1.localScale.x, t1.localScale.y,
            Mathf.MoveTowards(t1.transform.localScale.z, 0.8967518f, Time.deltaTime * 0.1f));
        inside.GetComponent<Name>().Quantity += Time.deltaTime * 0.22f;

    }

    public void Rotate(GameObject pour)
    {

      pour.transform.Rotate(0, 0, -Time.deltaTime * 10, Space.World);
  
    }







    Ray ReflectRay = new Ray();
    RaycastHit ReflectHit = new RaycastHit();
    GameObject ReflectedObject;
    public GameObject reflect(GameObject Grabbed)
    {

        

        ReflectRay.origin = Grabbed.transform.position;



        ReflectRay.direction = Camera.main.GetComponent<Raycast>().ray.direction;


       

        if (Physics.Raycast(ReflectRay, out ReflectHit, 4))
        {
            ReflectedObject = ReflectHit.transform.gameObject;

            Debug.DrawLine(ReflectRay.origin, ReflectHit.point, Color.blue);

        }

        if (ReflectedObject != null)
        {

            ChangeColor(ReflectedObject, 2);
            return ReflectedObject;
        }
        else
        {

            return null;
        }


    }


    

    public void ChangeColor(GameObject ga, int AnimationType) // overload i qneba magidaze dasadebebs! 
    {
        if (ga.GetComponent<Animator>())
        {
            string paramName = AnimationType.ToString();


            foreach (AnimatorControllerParameter param in ga.GetComponent<Animator>().parameters)
            {
                if (param.name == paramName)
                {
                    ga.GetComponent<Animator>().SetTrigger(paramName);
                }
            }

        }



    }






    // garb() is funqciwebi
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





}








        
            //DesplayObnames();

            //if (GetName() != null && GetName().GetComponent<Name>())
            //{
            //    GameObject get = GetName();

            //    if(Input.GetMouseButtonDown(0) && get.GetComponent<Name>().Grabbeble)
            //    {
            //        grabbed = true;

            //        GlobalGrabbed = get;


            //    }

            //}

            //if(grabbed)
            //{
            //    grab(GlobalGrabbed);
            //    GameObject ro = reflect(GlobalGrabbed);
            //    GlobalReflected = ro;


            //    if (ro.GetComponent<Name>() && Input.GetMouseButtonDown(0))
            //    {
            //        switch (ro.GetComponent<Name>().Type) // amowmebs areklili obieqtis tips
            //        {
            //            case 1:

            //                place(GlobalGrabbed, ro); // anbulebs obieqtebs
            //                grabbed = false;
            //                GlobalGrabbed = null;

            //                break;


            //            case 2:
            //                if (GlobalGrabbed.GetComponent<Name>().Type == 2) // grabbd onieqtis tipi aseve unda iyos liquid
            //                    isrotataing = true;



            //                break;


            //            case 3:





            //                break;

            //        }           

            //    }



            //    if (Input.GetKey("mouse 0") && isrotataing)
            //    {
            //        LiquidPour(GlobalGrabbed, ro);

            //    }


            //    if (GlobalGrabbed.name == "Spoon")
            //    {


            //        slider.SetActive(true);

            //        if (ro.name == "Media Box" || ro.name == "Petri Dish")
            //        {


            //            Debug.Log("grabb ___");
            //            SpoonState(GlobalGrabbed, ro);
            //        }


            //        chslider();
            //    }
            //    else
            //    {
            //        slider.SetActive(false);
            //    }




            //}



       