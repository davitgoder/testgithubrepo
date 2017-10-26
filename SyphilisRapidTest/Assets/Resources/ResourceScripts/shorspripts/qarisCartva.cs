using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qarisCartva : MonoBehaviour {

    public GameObject AIR;

	void Start () {
		
	}
	
	
	void Update () {
		
        if(gameObject.GetComponent<Animator>().GetBool("air") == true)
        {
            AIR.SetActive(true);
        }

        if (gameObject.GetComponent<Animator>().GetBool("gaxsna") == true)
        {
            AIR.SetActive(false);
            gameObject.GetComponent<qarisCartva>().enabled = false;
        }

    }
}
