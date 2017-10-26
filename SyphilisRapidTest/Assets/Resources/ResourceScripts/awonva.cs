using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awonva : MonoBehaviour {

    public bool YutisGaGebaAaqtiurebs = false;
   
    public GameObject magidaze;

    public GameObject sasworze;

    public GameObject xelshi;

     int count = 0;
    

    
	
	void Update ()
    {
        if (YutisGaGebaAaqtiurebs)
        {
            
            if (Vector3.Distance(gameObject.transform.position, magidaze.transform.position) < 1.5f && Input.GetKeyDown(KeyCode.E) && count ==0)
            {
                magidaze.SetActive(false);
                xelshi.SetActive(true);
                count = 1;
            }
            

            if (Vector3.Distance(gameObject.transform.position, sasworze.transform.position) < 1.5f  && Input.GetKeyDown(KeyCode.E) && count ==1)
            {
                xelshi.SetActive(false);
                sasworze.SetActive(true);
                count = 2;
                GameObject.Find("input").GetComponent<gamecontroller>().am = 4;
            }
            
        }

    
    }
}
