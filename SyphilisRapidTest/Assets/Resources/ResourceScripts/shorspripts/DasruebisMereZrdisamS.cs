using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DasruebisMereZrdisamS : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("input").GetComponent<gamecontroller>().WylisGadasxmadarulda = true;
        GameObject.Find("yuti").GetComponent<BoxOpen>().enabled = true;
      

    }
}
