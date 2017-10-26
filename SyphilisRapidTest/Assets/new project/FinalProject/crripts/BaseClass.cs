using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BaseClass : MonoBehaviour {



    public float Quantity;
    public string ObjectName;
    public string ObjectDiscription;

    public GameObject ObjectWithContact;



    GameObject player;


    void Start ()
    {
        player = Camera.main.gameObject;
	}


    void Update ()
    {
		
	}




    public void rotate()
    {
       
   

       
        if(Input.GetMouseButtonDown(1))
        {
            player.GetComponent<Fraycast>().StartDeterminieFunction = false;

        }

    }


    public void place(GameObject p)
    {

        gameObject.transform.position = p.transform.position;

        ClearFraycast();

    }





    void ClearFraycast()
    {
        player.GetComponent<Fraycast>().ReflectedObject = null;
        player.GetComponent<Fraycast>().grabbedOnmouseDown = null;
        player.GetComponent<Fraycast>().GrabBool = true;
    }




     void OnTriggerEnter(Collider other)
    {


        ObjectWithContact = other.transform.gameObject;
    }



}
