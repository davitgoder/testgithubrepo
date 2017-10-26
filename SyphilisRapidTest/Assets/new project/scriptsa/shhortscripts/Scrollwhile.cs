using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Scrollwhile : MonoBehaviour {

    public Slider v;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //    Input.GetAxis("Mouse ScrollWheel");



         v.value += Input.GetAxis("Mouse ScrollWheel");
       

      
     //   Debug.Log("mmmmmmmousssssssssssssseeeeeeeeeeeeeee" + Input.GetAxis("Mouse ScrollWheel"));

    }





   public void sli(float s)
    {

        Debug.Log( "ssssssssssssssss" +  s);
        v.value = s;

    }


}
