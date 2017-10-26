using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasaxsneladMitana : MonoBehaviour {   // mtlianad aketebs tepshis gadatanas sasworidan magidaze awonvis shendeg

    public GameObject TepshiXelshi;   public GameObject TepshiXelshiNiadagi;
    public GameObject TepshiMagidaze;  // magidaze daideba niadagiani tepshi gaxsnis win
    public GameObject Player;
    public GameObject TepshiSasworzeNiadagi;
    public GameObject GasaxsneliMenzura; // menzura romleshic niadagi ixsneba



    public GameObject GaxsniliWyali; 

    private int a = 0;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {

        if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(gameObject.transform.position, Player.transform.position) <1.5f && a==0) // tepshs achens xelshi
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            TepshiSasworzeNiadagi.GetComponent<Renderer>().enabled = false;

            TepshiXelshi.SetActive(true);
            TepshiXelshiNiadagi.SetActive(true);
            a++;

        }

        if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Player.transform.position, GasaxsneliMenzura.transform.position) <1.7f && a==1)  // gadaaqvs tepshi 
        {

            Debug.Log("meore if i");
            TepshiMagidaze.SetActive(true);
            TepshiXelshi.SetActive(false);

            a++;
        }



        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Player.transform.position, GasaxsneliMenzura.transform.position) < 1.5 && a == 2)  // wniadagis chayra // tepshi magidaze chartulia tu ara???
        {
            TepshiMagidaze.GetComponent<Animator>().enabled = true;    // animatori rtvas ragac cvlads !!!


            a++;
        }


        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Player.transform.position, GasaxsneliMenzura.transform.position) < 1.5 && a == 3)  // feris shecvla  
        {
          //  GaxsniliWyali.SetActive(true);


            a++;
        }




        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Player.transform.position, GasaxsneliMenzura.transform.position) <1.5 && a== 4)  // shemdeg
        {
            GasaxsneliMenzura.GetComponent<Animator>().enabled = true;
            a++;
        }

        if( a== 5)
        {
            TepshiSasworzeNiadagi.SetActive(false); 
             
            gameObject.SetActive(false);
            
           
        }

	}
}
