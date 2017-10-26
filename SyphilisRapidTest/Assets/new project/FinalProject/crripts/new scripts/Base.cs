using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {


    // Types:
    //0 glow
    // 1 camera
    // 2 Place (box colliders)
    // 3 laminr box door

    public int state;
    public string Gname;
    public int Type; // gansazgvarvs obieqtis tips
    

    GameObject g;
	void Start ()
    {

	}

    // activate igets patametrad im obietcs romelmac gamoidzaxa 
    // mag to calling object == camera change clorshi gamoidzaxeba gansavevbuli feris animacia

	void Update ()
    {

  


        //ChangeColor(int.Parse(Input.inputString));

        MouseDelta();

    }



    public bool checkreciver = true;
   public bool GrabBool = false;

    public Vector3 StartMOusePos;
    public void Acivate(GameObject CallingObject)
    {

        if (checkreciver)
        { 

            ChangeColor(CallingObject.GetComponent<Base>().Type);  // sheidzleba damatebiti shemowmebis damateba feris shecvlaze



            ManageColliders(GrabBool);
         /// TransformSetion start
            if(Input.GetMouseButtonDown(0))
            {
                GrabBool = true;
                
            }
            if(Input.GetMouseButtonUp(0))  // 
            {
                GrabBool = false;
            }

            if (GrabBool)
            {

               
                grab();


                if (reflect() != null && reflect().GetComponent<Base>())
                {


                    switch(reflect().GetComponent<Base>().Type)
                    {
                        case 2:

                            if (Input.GetMouseButtonDown(0)) // mausis dawerisas obieqti motavsdeba 
                            {
                                reflect().GetComponent<Base>().place(gameObject); // meore obieqts gadaewodeba es obieqti
                                GrabBool = false;
                            }

                             
                            break;


                        case 3:

                            if(Input.GetMouseButtonDown(0))
                            {
                                StartMOusePos = Input.mousePosition;

                            }

                            if(Input.GetKey("mouse 0"))
                            {

                                Debug.Log("Differenece " + Vector3.Magnitude( MouseLocationOnFirstPress(StartMOusePos)));

                            }


                            break;




                    }


                }

              
               

            }
           

        /// TransformSetion end



        }


    }


    


    public List<GameObject> ColliderList; // mowyobilobebis kolaiderebi aq ar shedis magidis kolaiderebi

    void ManageColliders(bool GrabBool)
    {
        if (GrabBool)
        {
            foreach (GameObject ga in ColliderList)
            {

                ga.GetComponent<BoxCollider>().enabled = true;
            }
        }
        else
        {

            foreach (GameObject ga in ColliderList)
            {

                ga.GetComponent<BoxCollider>().enabled = false;
            }

        

        }

    }


    // obieqtis misagebad shesadzlebelia daematos funqcia romlsac gamomdzaxebeli obieqti 
    // gadascems tavis saxels
    //if(raycasthit == x) 
    //x.f(gameobject name)

    Ray ReflectRay;
    RaycastHit ReflectHit;

    public GameObject ReflectedObject;
    public int test;
    public GameObject reflect()
    { 


        ReflectRay.origin = gameObject.transform.position;


        //ReflectRay.direction = Camera.main.transform.forward;  

        ReflectRay.direction = Camera.main.GetComponent<Raycast>().ray.direction;
        

        Debug.DrawLine(ReflectRay.origin, ReflectRay.direction, Color.red);

        if (Physics.Raycast(ReflectRay, out ReflectHit, 4))
        {
            ReflectedObject = ReflectHit.transform.gameObject;

            Debug.DrawLine(ReflectRay.origin, ReflectHit.point, Color.blue);     
              
        }

        if (ReflectedObject != null)
            return ReflectedObject;
        else
        {

            return null;
        }


    }





   

    public void place(GameObject p)
    {
        if(gameObject.transform.childCount >0)
        {
            p.transform.position = gameObject.transform.GetChild(0).transform.position;

        }
        else
        {
            p.transform.position = gameObject.transform.position;
        }

    }

    
    public void ChangeColor(int AnimationType) // overload i qneba magidaze dasadebebs! 
    {
        if(gameObject.GetComponent<Animator>())
        {
            string paramName = AnimationType.ToString();
              

            foreach (AnimatorControllerParameter param in gameObject.GetComponent<Animator>().parameters)
            {
                if (param.name == paramName)
                {
                    gameObject.GetComponent<Animator>().SetTrigger(paramName);
                }
            }

        }



    } 


   public  void grab()
    {
        switch(gameObject.GetComponent<Base>().Type)
        {

            case 3:
                Vector3 temp = gameObject.transform.position;
                temp.y = MouseDelta()/100;

                gameObject.transform.position = temp;


                break;


            default :
                gameObject.transform.position = cursorWorldPosOnNCP;
                break;
        }

        

    }


    //mausis pozicia

    public float f;
      public float MouseDelta()  // dasaweria karis rotacia da wkiris rotacia!!!
    {
        Vector2 m = Input.mousePosition;

        Vector2 m1 = new Vector2();
        if ( TM(0.1f) )
        {
             m1 = Input.mousePosition;


        }


        f=m.y - m1.y;


        return f;
    }


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


    public Vector2 MouseLocationOnFirstPress(Vector3 CklickedMousePos)
    { 
        Vector3 MouseLOcation = CklickedMousePos -  Input.mousePosition;

        return MouseLOcation;

    }





    // grab() is funqciebi
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
