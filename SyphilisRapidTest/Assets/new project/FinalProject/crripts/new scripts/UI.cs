using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UI : MonoBehaviour {  // needs optimisation 

    public GameObject Objects, Result;
    public GameObject MyCamera;

    public List<GameObject> ScorePanelLIst;

	void Start ()
    {

        MyCamera = Camera.main.gameObject;
	}


    public GameObject helpbar;
    public void help()
    {
        helpbar.SetActive(true);
    }
    
    public void helpdis()
    {
        helpbar.SetActive(false);

    }

    public void Internet()
    {

      string s =  EventSystem.current.currentSelectedGameObject.name;

       
         Application.OpenURL(s);


    }

	void Update ()
    {


        StopOtherActivites();

    }
    

    public void StopOtherActivites() // cameris modzraobas acherebs
    {

      if( ! Objects.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Normal") || !Result.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Normal"))
        {
            MyCamera.GetComponent<CameraScript>().UiIsActive = true;

        }
      else
        {
            MyCamera.GetComponent<CameraScript>().UiIsActive = false;


        }



    }


}
