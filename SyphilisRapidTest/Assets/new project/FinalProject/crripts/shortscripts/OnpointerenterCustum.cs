using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class OnpointerenterCustum : MonoBehaviour, IPointerEnterHandler// required interface when using the OnPointerEnter method.
{
    public GameObject Player;


    public void OnPointerEnter(PointerEventData eventData)
    {
        

        Player.GetComponent<UImanagerStateM>().ScoreInfo();

    }
}