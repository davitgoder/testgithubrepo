using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axamocana : MonoBehaviour  //    aqrobs magidaze da achens xelshi
{

    public GameObject GaqraMagidaze;
    


    public GameObject PetriXelshi;
    public GameObject jamisasworze;


    public GameObject plitastanjami;

    private int count = 0; 

     void Update()
    {




        if(Vector3.Distance(gameObject.transform.position, GaqraMagidaze.transform.position) <1.5 && Input.GetKeyDown(KeyCode.E) && count ==0)  // jamis saswporz gadatana 
        {
            GaqraMagidaze.GetComponent<Renderer>().enabled = false;
            PetriXelshi.GetComponent<Renderer>().enabled = true;

            count = 1;

        }

        if(Vector3.Distance(gameObject.transform.position, jamisasworze.transform.position)<1.5 && Input.GetKeyDown(KeyCode.E)  && count ==1 ) // sasworze dadeba
        {
            jamisasworze.SetActive(true);
            PetriXelshi.GetComponent<Renderer>().enabled = false;
        


            GameObject.Find("spoon").GetComponent<kovziskriptio>().enabled = true;



        }





        
        /*
        if (count ==1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GaqraMagidaze.SetActive(false);

                PetriXelshi.SetActive(true);
            }
            count = 1;
        }
        */
    }

   
}
