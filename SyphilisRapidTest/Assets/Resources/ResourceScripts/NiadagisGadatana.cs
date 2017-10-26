using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiadagisGadatana : MonoBehaviour {

    public GameObject sasworze;
    public GameObject xelshi;
    public GameObject Player;

   public GameObject XelshiNiadagi;

	void Start () { 
		
	}
	
	void Update () {
		

        if(Input.GetKeyDown(KeyCode.Q) && Vector3.Distance(Player.transform.position, gameObject.transform.position) <1.5)
        {
            sasworze.SetActive(false);
            xelshi.SetActive(true);
            XelshiNiadagi.SetActive(true);
        }
	}
}
