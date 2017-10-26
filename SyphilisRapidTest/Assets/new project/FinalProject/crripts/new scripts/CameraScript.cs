
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
   public  float speed = 1;



    Vector3 CameraStartpostion;
    public GameObject ResetCameraPostion;
    public float StartFiledOfView;
    public GameObject ViewRoom;
    void Start()
    {
        StartFiledOfView = Camera.main.fieldOfView;
        CameraStartpostion = gameObject.transform.position; // rotaciis cvliebis shemtxvevashi unda mivigo rotaciac
        Sun = GameObject.Find("Sun");
    }


    public int cameraCurrentZoom = 8;
    public int cameraZoomMax = 10;
    public float cameraZoomMin = 0.1f;

    public bool b= false;
    public bool b1 = false;
    public bool b2 = false;


    public void SetbuttonPassive()// resets settings from camera motion
    {
        gameObject.transform.position= CameraStartpostion;
        Camera.main.fieldOfView = StartFiledOfView;

        b = false;
        ResetCameraPostion.SetActive(false);

    }

    public GameObject ViewObjectsLocation;

    public List<GameObject> InstatiatebleObjectsList;

    public GameObject Instantiated;


    public GameObject ViewSphereButton;

     public void CleanUpViewSphere() // ViewSphereButtonze aris dadebuli
    { 

     if(Instantiated != null)
        {
            butt.SetActive(false);
            ObjectNameButton.SetActive(false);
            Destroy(Instantiated);

            ViewSphereButton.SetActive(false);
            Camera.main.transform.position = CameraStartpostion;
            ObjectNameButton.SetActive(false);

            ShoLabel = false;

            ExecuteOnlyOnce = true;
            isInsideViewSphere = false;
        }


    }

    // view start

    public GameObject ObjectNameButton;
    bool SetUpView = true;

    public int RaycastDistance = 10;
       GameObject Sun;

    public void ViewObject(string ObjectToVeiw )
    {

       
            
            for (int i = 0; i < InstatiatebleObjectsList.Count; i++)
            {
                if (InstatiatebleObjectsList[i].name == ObjectToVeiw)
                {



                ObjectNameButton.SetActive(true);

                SetbuttonPassive();
                isInsideViewSphere = true;
                ViewSphereButton.SetActive(true);


                Instantiated = Instantiate(InstatiatebleObjectsList[i], ViewObjectsLocation.transform.position, ViewObjectsLocation.transform.rotation);
                    Instantiated.AddComponent<RoateAround>();


                gameObject.transform.position = ViewRoom.transform.position;

              
            }
                else
            {

                ShoLabel = false;
            }


            }

         

        






        // obieqtis saxlis migeba start

        if (gameObject.GetComponent<Raycast>().GetName(RaycastDistance) != null)
        {
            GameObject CurrentPart = gameObject.GetComponent<Raycast>().GetName(RaycastDistance);
            Vector3 CurrentObjectVector = new Vector3( CurrentPart.transform.position.x -3 , CurrentPart.transform.position.y, CurrentPart.transform.position.z);
            

            ObjectNameButton.transform.position = Camera.main.WorldToScreenPoint(CurrentObjectVector);

            ObjectNameButton.GetComponent<Button>().GetComponentInChildren<Text>().text = CurrentPart.name;

        }
        if (Input.GetButton("Fire1") &&gameObject.GetComponent<Raycast>().GetName(RaycastDistance).name =="Sun" )
        {
            Sun.transform.position = cursorWorldPosOnNCP;
        }

        // obieqtis saxlis migeba end



    }


    // view and
    public bool isInsideViewSphere=false;

    bool N= false;

    bool ExecuteOnlyOnce= true;

    //public void InvokeSphereView(GameObject View)
    //{

    //    if (ExecuteOnlyOnce)
    //    {
    //        N = true;
    //        SetUpView = true;
    //        ExecuteOnlyOnce = false;
    //    }

    //    if (N)
    //    {

    //        ViewObject(View.name);

    //    }


    //}

    public float CameraMovementSpeed = 30;

    public float X, Y;

    public bool UiIsActive = false; // ui is aqtivacia acherebs kameris modzraobas

    public GameObject butt;
    public bool ShoLabel= false;

    void Update()
    {

      X= Input.GetAxis("RightX");

        Y=Input.GetAxis("RightY");

        if (gameObject.GetComponent<Raycast>().GetName() != null)
        {


            if (Input.GetMouseButtonDown(1))
            {

                ViewObject(gameObject.GetComponent<Raycast>().GetName().name);
                ShoLabel = true;

            }
          

        }


        if(ShoLabel)
        {

            butt.SetActive(true);
            butt.transform.position = Camera.main.WorldToScreenPoint(gameObject.GetComponent<Raycast>().GetName().transform.position);
            butt.GetComponent<Button>().transform.GetChild(0).gameObject.GetComponent<Text>().text = gameObject.GetComponent<Raycast>().GetName().name;
        }
        else
        {


        }
        

        if(!UiIsActive)
        {

        

        if ( (Input.GetAxis("Mouse ScrollWheel") != 0))
        {
            b = true;
            ResetCameraPostion.SetActive(true);

        }


            if (!isInsideViewSphere)
            {

                if (b)
                {



                    if (Input.GetMouseButtonDown(0))
                    {
                        b2 = true;

                    }
                    else if (Input.GetMouseButtonUp(0))
                    {
                        b2 = false;

                    }

                    if (b2)
                    {

                        if (Mathf.Abs(Input.GetAxis("RightX")) > 5)
                        {

                            if (!(transform.position.x < 32.4f) && !(transform.position.x > 39.68f))
                            {
                                transform.Translate(new Vector3(-Input.GetAxisRaw("RightX") * Time.deltaTime * speed, 0, 0) * (Time.deltaTime * CameraMovementSpeed));
                            }


                        }

                        else if (Mathf.Abs(Input.GetAxis("RightY")) > 5)
                        {

                            //   if ( !(transform.position.y < 4.05f) && !(transform.position.y > 1.05f))
                            {
                                transform.Translate(new Vector3(0, -Input.GetAxisRaw("RightY") * Time.deltaTime * speed, 0) * (Time.deltaTime * CameraMovementSpeed));
                            }

                        }
                    }


                




                if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
                {
                    if (cameraCurrentZoom < cameraZoomMax)
                    {
                        cameraCurrentZoom += 1;
                        Camera.main.fieldOfView = Mathf.Max(Camera.main.fieldOfView + 2);
                    }
                }
                if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
                {
                    if (cameraCurrentZoom > cameraZoomMin)
                    {
                        cameraCurrentZoom -= 1;
                        Camera.main.fieldOfView = Mathf.Min(Camera.main.fieldOfView - 2);
                    }
                }

            }



            }

        }





    }

    // grabbis funqciebi


    public static Vector3 cursorWorldPosOnNCP
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane + 3));
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
