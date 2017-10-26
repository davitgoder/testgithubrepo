using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gglove : MonoBehaviour {



    public void OnMouseDown()
    {
        Camera.main.gameObject.GetComponent<newanimations>().enabled = true;

        Destroy(gameObject);
    }
}
