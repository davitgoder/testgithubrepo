using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGetter : MonoBehaviour {

    Animator _animator;
    float Direction;
    Transform playerTransform;
   

	void Start () {
        _animator = GetComponent<Animator>();
        playerTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Direction = Input.GetAxis("Horizontal");
        Debug.Log(Direction);
        _animator.SetFloat("Direction", Direction);
	}
}
