using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class start : MonoBehaviour {

	public Button starta;
    public Button exits;
	void Start () {
        starta = starta.GetComponent<Button>();
        exits = exits.GetComponent<Button>();
    }
	public void startaa()
    {
        Debug.Log("111111111111111111111111");
        Application.LoadLevel(1);
        Application.UnloadLevel(0);
    }
    public void exita()
    {
        Debug.Log("ajsjdknsadasdddd");
        Application.Quit();

    }
	
}
