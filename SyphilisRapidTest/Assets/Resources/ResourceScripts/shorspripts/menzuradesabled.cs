using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menzuradesabled : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        while(GameObject.Find("input").GetComponent<gamecontroller>().am != 5)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
        if (GameObject.Find("input").GetComponent<gamecontroller>().am == 5) gameObject.GetComponent<menzuradesabled>().enabled = false;
	}
}
