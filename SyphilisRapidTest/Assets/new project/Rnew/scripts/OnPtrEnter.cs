using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPtrEnter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void PtrEnter()
    {

        gameObject.GetComponent<Animator>().SetTrigger("a");

    }

    public void ptrexit()
    {
        gameObject.GetComponent<Animator>().SetTrigger("b");

    }




    public void Load2()
    {
        SceneManager.LoadScene(2);

    }

    public void Load3()
    {
        SceneManager.LoadScene(3);

    }
     
    public void Load4()
    {
        SceneManager.LoadScene(4);

    }


}