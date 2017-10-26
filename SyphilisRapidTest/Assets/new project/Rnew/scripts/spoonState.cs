using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spoonState : MonoBehaviour {


    public int state = 0;
    public GameObject ca;


    public GameObject buttonQ;


    public  int quantity = 0;



    int check = 0;


    public bool st = false;


    private Button button;

    public  GameObject tex;

    public int sawwori=0;

    public bool mesh_true = false;

    public GameObject PetrisJami;

    public GameObject amountButton;

 

    public bool isfinished = false;

    void Start()
    {
        button = buttonQ.GetComponent<Button>();
    }


    float f = 0;
    public GameObject moveUI;


    float loctime = 0; bool lo = true;


    public GameObject isactive;
   public int s =0;

    public bool kkkk = false;
    void Update()
    {
        moveUI.transform.position = Camera.main.WorldToScreenPoint( new Vector3( gameObject.transform.position.x, gameObject.transform.position.y +0.5f, gameObject.transform.position.z ));

        kkkk = isactive.GetComponent<MeshRenderer>().enabled;
       

        if (!kkkk)
        {
            sawwori = s;
        }
        tex.GetComponent<TextMesh>().text = sawwori.ToString() + " g";

        if (sawwori == 52)
        {
            amountButton.SetActive(false);
            gameObject.GetComponent<Animator>().SetInteger("s", 10);
          
            if (lo)  // !!!!!!
            {
                loctime = Time.time; lo = false;
            }
            if (Time.time - loctime > 0.5f)
            {
                gameObject.GetComponent<Animator>().SetBool("b10", false);
            }
            isfinished = true;
        }
        else
        {

          

            if (gameObject.transform.GetChild(1).GetComponent<MeshRenderer>().enabled)
            {
                mesh_true = true;
            }
            else
                mesh_true = false;









            if ((quantity + (int)(Input.GetAxis("Mouse ScrollWheel") * 10)) > 0 && (quantity + (int)(Input.GetAxis("Mouse ScrollWheel") * 10)) < 11)
                quantity += (int)(Input.GetAxis("Mouse ScrollWheel") * 10);
           








            switch (state)
            {
                case 0:




                    if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == gameObject.name)
                    {
                        buttonQ.SetActive(true);
                        state = 1;

                    }







                    break;


                case 1:






                    buttonQ.SetActive(true);

                    if (buttonQ.activeSelf)
                        button.transform.GetChild(0).GetComponent<Text>().text = quantity.ToString();

                    if (Time.time - f > 1)
                    {


                        f = 0;

                        gameObject.GetComponent<Animator>().SetInteger("s", 1);


                        if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "petris jami")
                        {

                            state = 2;
                        }
                        else if (ca.GetComponent<NewRaysdasu>().GetHoldName().name == "kkkkk")
                        {

                            state = 3;
                        }


                    }


                    break;




                case 2:








                    if (mesh_true)
                    {


                        gameObject.GetComponent<Animator>().SetInteger("s", 8);




                        //  sawwori += quantity;
                        s += quantity;
                        tex.GetComponent<TextMesh>().text = sawwori.ToString() + " g";




                        if (sawwori <= 52)

                            PetrisJami.transform.GetChild(1).localScale = (new Vector3(0.6390795f, 0.6942326f, 0.2854813f) / 52) * sawwori;



                        //   button.transform.GetChild(0).GetComponent<Text>().text = "0";


                        f = Time.time;
                        state = 1;







                    }
                    else
                    {

                       


                        if (sawwori - quantity > 0)
                        {

                            // sawwori -= quantity;
                            s -= quantity;
                            tex.GetComponent<TextMesh>().text = sawwori.ToString() + " g";

                            PetrisJami.transform.GetChild(1).localScale = (new Vector3(0.6390795f, 0.6942326f, 0.2854813f) / 52) * sawwori;


                        }
                        else
                        {
                            sawwori = 0;
                        }


                        gameObject.GetComponent<Animator>().SetInteger("s", 6);
                        f = Time.time;
                        state = 1;








                    }




                    break;


                case 3:






                    if (mesh_true)
                    {









                        gameObject.GetComponent<Animator>().SetInteger("s", 2);


                        f = Time.time;

                        state = 1;





                    }
                    else
                    {




                        gameObject.GetComponent<Animator>().SetInteger("s", 4);




                        f = Time.time;
                        state = 1;


                    }







                    break;


            }




        }



    }



}
