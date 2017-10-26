using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    private Animator anim;

    public GameObject player;


	void Start () {

        anim = gameObject.GetComponent<Animator>();
	}
	

	void Update () {


        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 2)
        {


            anim.SetBool("door", true);

        }

	}
}
