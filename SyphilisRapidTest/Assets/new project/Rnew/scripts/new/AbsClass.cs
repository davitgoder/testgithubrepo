using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class AbsClass : MonoBehaviour
{

    public float amount;
    public int wWeight;
    public int state;
    public string intag;

  


    public GameObject Player;



     void Awake()
    {
        Player = Camera.main.gameObject;
        

    }



    public bool mouse;


   


    public virtual void PlaseObjectInsade(GameObject Insade)
    {

       
        gameObject.transform.position = Insade.transform.GetChild(0).transform.position;
      
       // gameObject.GetComponent<BoxCollider>().enabled = true;

       // Player.GetComponent<NewRaysdasu>().locfind = null;
       

      
    


    }




    public Vector2 v;
  
   


    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    public float ps;

    public Quaternion q4;

    public Vector3 glob = new Vector3();

   public virtual void rotate(Vector2 r, GameObject cklicked)
    {


        gameObject.transform.position = cklicked.transform.GetChild(0).transform.position;  // shesabamisi child ari 0 elementi masivshi

        q4.eulerAngles = gameObject.transform.rotation.eulerAngles;

        ps = (r.y - new Vector2(Input.mousePosition.x, Input.mousePosition.y).y);

        ps *= -3;
       

       // if ( glob.x > 80  && glob.x <300 ) 
        {
            
            



             Quaternion target = Quaternion.Euler(ps, 0, 0);
           
             gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }

     


    }








}
