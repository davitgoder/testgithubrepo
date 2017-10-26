using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PirveliAnim : MonoBehaviour {

    public GameObject ga;

    bool already = true;
    public Animator A;
    public GameObject wyali;

    public Text Tex; 
   

     public Transform T;
	void Start ()
    {
        T = T.GetComponent<Transform>();
	}


    void Update()
    {



        if (already)
        {
            if (Vector3.Distance(gameObject.transform.position, T.position) < 1.5)
            {
               // Tex.text = "daaWire e - s";

            }
            else
            {
                //Tex.text = "";
            }


            if (Vector3.Distance(gameObject.transform.position, T.position) < 2 && Input.GetKeyDown(KeyCode.E))
            {

                gameObject.GetComponent<Animator>().SetBool("Param", true);
                wyali.SetActive(true);
                A.GetComponent<Animator>().SetBool("Param1", true);
                already = false;


                already = false;
               //  Tex.text = "";

            }

            
        }
        
    }

   

}
