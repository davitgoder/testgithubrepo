using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanagerStateM : MonoBehaviour {


    public List<GameObject> ScorePanelButtons  = new List<GameObject>();

    public int UiState = 0;

     
	void Start ()
    {

	}

    public GameObject cube;
	void Update ()
    {
	




        
	}


    public GameObject ScorePanel;
   

    public void ScoreInfo()
    {
       

            ScorePanel.GetComponent<Animator>().SetTrigger("show");
    }




    Vector2 ScreemPoint;
    public GameObject InfoPanel;
    //public void ObjectInfo(GameObject ga)
    //{

    //    ScreemPoint = Camera.main.WorldToScreenPoint(ga.transform.position);

    //    InfoPanel.SetActive(true);

    //    InfoPanel.transform.position = ScreemPoint;


    //}



    bool TimeSet = true;
    float TimeSpen;

    public GameObject PriveasObject;

    public void ObjectInfo(GameObject ga, float time = 2)
    {


            if (ga != PriveasObject)
            {

                TimeSpen = Time.time;

                PriveasObject = ga;

            }

        

        if ((Time.time - TimeSpen) < time)
        {


            ScreemPoint = Camera.main.WorldToScreenPoint(ga.transform.position);

            InfoPanel.SetActive(true);






            InfoPanel.transform.position = ScreemPoint;
        }
        else
        {
            InfoPanel.SetActive(false);

           

        }


         

        


    }


}
