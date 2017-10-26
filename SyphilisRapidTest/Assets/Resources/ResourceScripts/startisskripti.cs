using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startisskripti : MonoBehaviour {
    public Material M;

    private Material M1;

    public GameObject ga1;

    public Animator A;
    public GameObject Ncylinder;
    public GameObject player;
    public GameObject gasaqrobicilindri;

    

    public bool B =false;
    void Start () {

        

        ga1.SetActive(false);
	}


     void Update()
    {

        if(Vector3.Distance(player.transform.position, gameObject.transform.position) <1.5 && Input.GetKeyDown(KeyCode.E) )
        {
            //A.enabled = true;
          
           
        }

        if (B)
        {

            Ncylinder.SetActive(true);
            gasaqrobicilindri.SetActive(false);

        }
    }

	
}
