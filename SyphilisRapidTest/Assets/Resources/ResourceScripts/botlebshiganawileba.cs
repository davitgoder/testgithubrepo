using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botlebshiganawileba : MonoBehaviour {


    public bool c1 = false;

    public bool c2 = false;


    public Animator A1;
    public Animator A2;


    public bool c3 = false;

    public GameObject cyl;
    void Start ()
    {
        cyl.GetComponent<Animator>().SetBool("nd", true);
	}
	
	void Update ()
    {
		



        if(c1)
        {
            A1.SetBool("tavsaxuri500", true);
        }

        if(c2)
        {

            A2.SetBool("tavsaxuri250", true);

        }

        if (c1 && c2 &&  c3)
        {
            GameObject.Find("input").GetComponent<gamecontroller>().am = 10;
            gameObject.GetComponent<botlebshiganawileba>().enabled = false;
        }

	}
}
