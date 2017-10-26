using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amocana : MonoBehaviour
{


    public Transform go;

    private Transform T;

    void Start()
    {
        T = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            T.position = go.position;
            go.transform.parent = T.transform;

        }
        

    }
}
