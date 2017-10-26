using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignaliWkirs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.GetComponent<Animator>().enabled == true)
        {
            GameObject.Find("wkiri").SetActive(true);
        }
	}
}
