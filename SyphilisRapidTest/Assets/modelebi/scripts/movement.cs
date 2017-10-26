using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public AudioSource mousecklick;
    LineRenderer line;
        void Start ()
    {
        line = gameObject.GetComponent<LineRenderer>();
        ray.origin = gameObject.transform.position;
        hit = new RaycastHit();
    }
	
	void Update ()
    {
        clickeffects(); // line renderer material and sound 
        Cursor();
        Getname();

        GetHoldName(); 

    }



    public Material linemat1;
    public Material linemat2;
    void clickeffects()
    {

        if(GetHoldName()!= null && GetHoldName().tag =="click")
        {
            mousecklick.Play(100);
        }

        
        if (Input.GetMouseButtonDown(0))
        {
          

            line.material = linemat1;
        }
        if(Input.GetMouseButtonUp(0))
        {
       

            line.material = linemat2;
        }
    }


    void Cursor()
    {
        Vector3[] Linepositions = new Vector3[2];
        Linepositions[0] = gameObject.transform.position;
        Linepositions[0].y -= 1;


        Linepositions[1] = Camera.main.ScreenToWorldPoint(new Vector3( Input.mousePosition.x, Input.mousePosition.y, 
            Camera.main.nearClipPlane +20) );


     

      //  Debug.Log(Input.mousePosition);


       line.SetPositions(Linepositions);

    }

    Ray ray;
    RaycastHit hit;

    public GameObject locfind;
    public GameObject Getname()
    {

        ray.direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Camera.main.nearClipPlane + 500));

        if (Physics.Raycast(ray, out hit ))
        {
         //   Debug.Log("name" + hit.transform.gameObject.name);

            locfind = hit.transform.gameObject;
            return hit.transform.gameObject;
        }
        else
        {
            return null;
        }



    }


    public GameObject GetHoldName()
    {

        ray.direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Camera.main.nearClipPlane + 500));

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
         //   Debug.Log("name" + hit.transform.gameObject.name);

            
            return hit.transform.gameObject;
        }
        else
        {
            return null;
        }



    }




}
