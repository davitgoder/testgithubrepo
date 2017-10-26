using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marjvenaxeli : MonoBehaviour {

    public GameObject saswori;
    public GameObject iktarg;


    public GameObject anim_marcxena_ob;
    



    private Animator anim;
    private Animator marcxena;

    public float distance;
    public GameObject go; // asagebi obiecti

    private Rigidbody rb;
	void Start ()
    {
        rb = iktarg.GetComponent<Rigidbody>();

        anim = gameObject.GetComponent<Animator>();
        marcxena = anim_marcxena_ob.GetComponent<Animator>();
	}
	
	void Update ()
    {
	
    if( Vector3.Distance(transform.position, go.transform.position) <distance)
        {

            
            gameObject.transform.position = go.transform.position;
            go.transform.parent = gameObject.transform;


        }

    if(Input.GetKeyDown(KeyCode.P) && Vector3.Distance(transform.position, go.transform.position) < distance) 
        {

            marcxena.SetBool("marcxena", true);
            anim.SetBool("wyali", true);
        }
    
       if(Input.GetKeyDown(KeyCode.B))  // agebis dros jobia  camera look et is damateba  !!!
        {

            rb.AddForce(transform.forward *20);


        }
              
        	
	}

}

