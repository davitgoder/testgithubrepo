using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NSate : MonoBehaviour { // kameris pirvel animacias akeTebs es


    /// <summary>
    /// 1. put on glaves
    /// 2. measure water
    /// 3. put peter dish
    /// 4. zero out the scale
    /// ... put media on petre dish
    /// 5. put media in water
    /// 6. turn on heater
    /// 7. put water on heater
    /// 8. stear water
    /// 9. measure ph
    /// 10. prepare bottles
    /// 11. put media in bottles
    /// 12. put bottles in avtoclave
    /// 13. put bottles in freezer
    /// 14. put bottle in microwae (one)
    /// 15. turn on laminar box
    /// 16. put media in laminar box
    /// 17. fill petre dishes
    /// 18. put petre dishes and left over media in freezer
    /// </summary>

   public int state = 0;
    public GameObject ShowScorePanel;



    void Start ()
    {

   

    }
	
	void Update ()
    {



        StateMachine();

        CameraAnim();

    }



    public int OnlyOnce = 0;



    public GameObject WaterSlider;
    public GameObject measurring;



    public GameObject meshtext;

    public GameObject petri;

    public void StateMachine()
    {
        switch(state)
        {
            case 0:
                // waiting for gloves
                OnlyOnce = 1;

                break;

            case 1:

                if(OnlyOnce == 1)
                {
                    gameObject.GetComponent<UI>().ScorePanelLIst[0].SetActive(true);
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Highlighted");
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Pressed");


                    OnlyOnce = 2;
                    state = 2;
                }


                break;

            case 2:


                //if()
                WaterSlider.SetActive(true);

                WaterSlider.GetComponent<Slider>().value = measurring.GetComponent<Name>().Quantity;
                WaterSlider.transform.GetChild(0).gameObject.GetComponent<Text>().text= measurring.GetComponent<Name>().Quantity.ToString();
                if(measurring.GetComponent<Name>().Quantity >= 0.9f && measurring.GetComponent<Name>().Quantity <= 1.1f)
                {
                    WaterSlider.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.green;
                }
                else
                {
                    WaterSlider.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.red;
                }



                if(measurring.GetComponent<Name>().Quantity >= 0.9f && measurring.GetComponent<Name>().Quantity <= 1.1f && !gameObject.GetComponent<Raycast>().grabbed)
                {
                    WaterSlider.SetActive(false);


                    gameObject.GetComponent<UI>().ScorePanelLIst[1].SetActive(true);
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Highlighted");
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Pressed");
                    state = 3;

                }

                //if (OnlyOnce == 2)
                //{
                 



                //    OnlyOnce = 3;
                //    state = 3;
                //}


                break;

            case 3:


                if(gameObject.GetComponent<Raycast>().GetName().name == "Petri Dish" && gameObject.GetComponent<Raycast>().GlobalReflected.name == "sphere (1)")
                {

                    GameObject.Find("saswori").GetComponent<petri>().enabled = true;
                    state = 4;

                }
                break;

            case 4:

              if(gameObject.GetComponent<Raycast>().GetName().name =="Zero Out" && Input.GetMouseButtonDown(0))
                {
                    state = 5;

                }


                break;

            case 5:

                meshtext.GetComponent<TMPro.TextMeshPro>().text = GameObject.Find("Petri Dish").GetComponent<Name>().Quantity.ToString();

                if (petri.GetComponent<Name>().Quantity >= 51 && petri.GetComponent<Name>().Quantity <= 53)
                {
                    gameObject.GetComponent<UI>().ScorePanelLIst[2].SetActive(true);
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Highlighted");
                    ShowScorePanel.GetComponent<Animator>().SetTrigger("Pressed");

                    state = 6;
                }

                break;


            case 6:

                if (gameObject.GetComponent<Raycast>().GetName().name == "Petri Dish" && gameObject.GetComponent<Raycast>().GlobalReflected.name == "Meassuring Cup (2))")
                {


                    state = 7;

                }


                    break;



            case 7:



                break;

        }


    }




    public void CameraAnim()
    {
        if(!gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("bloomanim"))
        {
            gameObject.GetComponent<Animator>().enabled = false;

        }



    }




}
