using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetrisState : MonoBehaviour {


    public int state=0;
    public GameObject ca;
    public GameObject NiadagisYuti;
    public GameObject spoon;

    public GameObject menzura;

    public GameObject sasworistext;


	public float dro=0;


    public bool awonilia= false;


    private bool SasworisGanuleba = false;



    public bool  bloki=false;



    public GameObject niadagi;
 

    void Update ()
    {




        if (spoon.GetComponent<spoonState>().sawwori == 52)
        {

            awonilia = true;
        }




        switch (state)
        {
            case 0:

                gameObject.GetComponent<Animator>().SetInteger("state", 0);

                if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == gameObject.name)
                {
                    dro = Time.time;
                    state = 1;
               
                }
          


                break;




            case 1:

                gameObject.GetComponent<Animator>().SetInteger("state", 1);

                if (Time.time - dro >2)
                {
                    state = 0;
                }

                if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "weight 1")
                {
                    state = 2;

                }


               




                    break;




            case 2:

                sasworistext.SetActive(true);

                gameObject.GetComponent<Animator>().SetInteger("state", 2);



                if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "ganuleba")
                {
                    sasworistext.GetComponent<TextMesh>().text = "0";
                    SasworisGanuleba = true;
                }



                    if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "kkkkk" && SasworisGanuleba)
                {
                    spoon.GetComponent<spoonState>().enabled = true;
                    NiadagisYuti.GetComponent<Animator>().SetTrigger("t");

                }


                    if (awonilia)
                {
                    dro = Time.time;
                    spoon.GetComponent<spoonState>().enabled = false;
                    state = 3;
                }



                break;


            case 3:

                gameObject.GetComponent<Animator>().SetInteger("state", 3);

                if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "petris jami"  && Time.time -dro >2)
                {
                    bloki = true;
                    state = 4;
                }

                    break;



            case 4:

                gameObject.GetComponent<Animator>().SetInteger("state", 4);


                if ( (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "petris jami" || ca.GetComponent<NewRaysdasu>().GetHoldName().name == "menzura state ma (1)")  && bloki)
                {

                    bloki = false;
                    state = 5;
                   
                }


                break;


            case 5:


                gameObject.GetComponent<Animator>().SetInteger("state", 5);

                niadagi.SetActive(false);
                menzura.GetComponent<Animator>().SetTrigger("feri");
                if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "menzura state ma (1)" && bloki)
                {
                   


                    



                    bloki = false;
                    state = 4;
                   
                }


                break;


            

        }








	}



}
