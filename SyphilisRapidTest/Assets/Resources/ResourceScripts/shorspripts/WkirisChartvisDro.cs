using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WkirisChartvisDro : MonoBehaviour {
    public bool W = false;




    void Update ()
    {
		if(Vector3.Distance(gameObject.transform.position, GameObject.Find("menzura").transform.position)>0.2)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = true;

        }
    }
}
