using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignaliWylisAnimacias : MonoBehaviour {



    public bool ChangeM = false;

    public GameObject wyali;
    private float time;
    void Start ()
    {
        

	}


    
     void Update()
    {

        if(ChangeM)
        {
            gameObject.GetComponent<Animator>().SetBool("M", true);

            gameObject.GetComponent<SignaliWylisAnimacias>().enabled = false;        // gamoirtveba 
        }



        if(gameObject.GetComponent<Animator>().enabled==true)
        {
            wyali.GetComponent<Animator>().SetBool("FerisShecvla", true);
            GameObject.Find("heater").GetComponent<Animator>().enabled = true;
          //  GameObject.Find("input").GetComponent<gamecontroller>().am++;
        }

    }
 
}
