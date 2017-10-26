using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class UImanager : MonoBehaviour {
    public GameObject WelcomeText;

   
    public GameObject Inputpanel;

    public GameObject InputCheck;
    public GameObject Pleasewait;

    public List<InputField> PlayerInput = new List<InputField>();




    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}


   public void OnSubmit()
    {
        foreach(InputField i in PlayerInput)
        {
            if(string.IsNullOrEmpty(i.text))
            {
                InputCheck.GetComponent<Animator>().SetTrigger("I");
            }
            else
            {
                WelcomeText.SetActive(true);
                WelcomeText.transform.GetChild(0).GetComponent<Text>().text = PlayerInput[0].text;
                Inputpanel.SetActive(false);
                Pleasewait.SetActive(true);

              //SceneManager.LoadScene(1);

                SceneManager.LoadSceneAsync(1);
            }


        }




    }




}
