using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glove : MonoBehaviour {

    public GameObject g;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!g.active)
        {
            Destroy(gameObject);
        }
	}
}
