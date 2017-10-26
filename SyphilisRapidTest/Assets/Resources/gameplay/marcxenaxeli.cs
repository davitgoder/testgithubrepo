using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marcxenaxeli : MonoBehaviour {

   // public GameObject menzura;
   // public Animator anim;

    public float distance =0.5f;
    public GameObject menzura; // asagebi obiecti

      

    void Start()
    {

    }

    void Update()
    {

        if (Vector3.Distance(transform.position, menzura.transform.position) < distance)
        {


            gameObject.transform.position = menzura.transform.position;
            menzura.transform.parent = gameObject.transform;


        }

        /*
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("menzura", true);
        }

    */
    }




}
