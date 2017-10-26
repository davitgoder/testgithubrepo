using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startfinish : MonoBehaviour {
    public GameObject cube;
    public GameObject Sbut;
    public GameObject Fbut;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Sbutt()
    {
        cube.GetComponent<MeshRenderer>().enabled = false;
        cube.SetActive(false);
        Sbut.SetActive(false);

    }

  public  void fButt()
    {
        Application.Quit();

    }


   


}
