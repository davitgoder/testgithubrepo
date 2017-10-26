using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGloves : MonoBehaviour {

    public GameObject p1lane1;
     public GameObject player;

    public GameObject butt;
    public GameObject butt1;
    
    void Start ()
    {
        
        player.GetComponent<Animator>().enabled = true;
    }
	

	void Update ()
    {
		
        

	}

     void OnMouseDown()
    {
        player.GetComponent<Animator>().SetTrigger("tt12");



    
      

        gameObject.SetActive(false);
       
        
    }


   public void e1n()
    {

        player.GetComponent<Animator>().SetTrigger("ttt");
        p1lane1.SetActive(false);
        butt.SetActive(false);
        butt1.SetActive(true);
    }


}
