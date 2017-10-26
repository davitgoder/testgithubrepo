using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {



    RaycastHit hit;

    GameObject  linecast1()
    {

        if(Physics.Linecast(cursorWorldPosOnNCP, cursorWorldPosOnNCP * 5, out hit))
        {
            Debug.Log(hit.transform.gameObject.name +"hhhhhhhhhhhhhhh");
        }


        Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward * 5, Color.yellow);


        return null;
    }


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        linecast1();
	}



    private static Vector3 cursorWorldPosOnNCP
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane + 1));
        }
    }

    private static Vector3 cameraToCursor
    {
        get
        {
            return cursorWorldPosOnNCP - Camera.main.transform.position;
        }
    }

    private Vector3 cursorOnTransform
    {
        get
        {
            Vector3 camToTrans = transform.position - Camera.main.transform.position;
            return Camera.main.transform.position +
                cameraToCursor *
                (Vector3.Dot(Camera.main.transform.forward, camToTrans) / Vector3.Dot(Camera.main.transform.forward, cameraToCursor));
        }
    }


}


