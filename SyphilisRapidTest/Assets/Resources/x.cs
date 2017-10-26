using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x : MonoBehaviour {

   public AnimationClip anim;
    public Animation anim1;
    bool c = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("11");
            anim1.Play("A");

            Debug.Log("saasd" +  Input.GetKeyDown(KeyCode.E));
        }
	}
}
