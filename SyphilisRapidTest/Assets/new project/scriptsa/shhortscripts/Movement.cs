using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    public GameObject to;

    float dro = 0;
    bool d = true;


    void Start ()
    {
    //    dro = Time.time;
	}
	
	


	void Update ()
    {
        /*
        if(d && Input.GetMouseButtonUp(0))
        {
            dro = Time.time;
            d = false;
        }


        if(Time.time - dro >1.5f && d == false)
        {
            Destroy(gameObject.GetComponent<Movement>());
        }
        */

		if(Vector3.Distance(gameObject.transform.position, to.transform.position) >0.1f)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, to.transform.position, 0.2f);
        }
        else
        {

            Destroy(gameObject.GetComponent<Movement>());

            gameObject.GetComponent<Movement>().enabled = false;
        }
    }
}
