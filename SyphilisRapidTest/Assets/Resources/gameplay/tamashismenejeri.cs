using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tamashismenejeri : MonoBehaviour {


    //public Text text;
   

    public GameObject go;

    public GameObject jami;


    void Start ()

    {
    

    }
	




	void Update ()

    {
        if (Input.GetKeyDown(KeyCode.B))  // agebis dros jobia  camera look et is damateba  !!!
        {

            Debug.Log("sdebageri");

            gameObject.transform.position= Vector3.Lerp(gameObject.transform.position, go.transform.position, 0.1f);
         //   gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1,2,3) * 1);

           // gameObject.GetComponent<Rigidbody>().useGravity = true;
        } 



    }


}
