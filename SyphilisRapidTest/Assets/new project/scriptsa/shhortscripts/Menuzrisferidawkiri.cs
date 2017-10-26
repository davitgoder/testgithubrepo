using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menuzrisferidawkiri : MonoBehaviour {

    public GameObject wkiri;
    public GameObject Ccamera;

    public bool TakeControl= false;


    float dro = 0;


    public int counter = 0;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
		if(TakeControl)
        {

            if(Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name== "menzura state ma (1)" && dro==0)
            {


                GameObject.Find("menzura state ma (1)").GetComponent<Animator>().SetTrigger("p");
                GameObject.Find("Heater").GetComponent<Animator>().enabled = true;
                dro = Time.time;
                counter = 1;

            }

            if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "wkiri" && (Time.time - dro <0.5) && counter==1 )
            {

                Debug.Log("wkiri ffff");
                wkiri.SetActive(false);
                gameObject.transform.GetChild(4).GetComponent<MeshRenderer>().enabled = true;
                gameObject.transform.GetChild(4).GetComponent<Animator>().enabled = true;

                dro = Time.time;

                counter = 2;
            }



            if (Ccamera.GetComponent<NewRaysdasu>().GetHoldName().name == "menzura state ma (1)" && (Time.time- dro >2)  && counter ==2)
            {
                gameObject.transform.GetChild(4).GetComponent<MeshRenderer>().enabled = false;
                gameObject.transform.GetChild(4).GetComponent<Animator>().enabled = false;

                gameObject.GetComponent<Animator>().SetTrigger("pm");

                counter = 3;
                    
              }





            }



        }


     void OnMouseDown()
    {
        Ccamera.GetComponent<stateController>().na = true;




    }

}
