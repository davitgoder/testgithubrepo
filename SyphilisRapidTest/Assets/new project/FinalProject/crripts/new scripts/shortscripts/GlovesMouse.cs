using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlovesMouse : MonoBehaviour {

    public GameObject mycamera;

    public void Start()
    {
        mycamera = Camera.main.gameObject;
    }

    void OnMouseDown()
    {
        mycamera.GetComponent<NSate>().state = 1;


        Destroy(gameObject);

    }

}
