using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewIK : MonoBehaviour {

    Animator anim;

    public float ikWeight = 1;
    public Transform leftIKTarget;
    public Transform rightIKTarget; 



    void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
		
	}





    void OnAnimatorIK()
    {
       // anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, ikWeight);
        //anim.SetIKPositionWeight(AvatarIKGoal.RightHand, ikWeight);


      //  anim.SetIKPosition(AvatarIKGoal.LeftHand, leftIKTarget.position);
       // anim.SetIKPosition(AvatarIKGoal.RightHand, rightIKTarget.position);
    }



}
