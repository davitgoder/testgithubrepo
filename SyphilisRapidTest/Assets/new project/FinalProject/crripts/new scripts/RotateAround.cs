using UnityEngine;
using System.Collections;

public class RoateAround : MonoBehaviour
{
    public float RotSpeed = 0.1f;


    void Start()
    {
      
    }

    void Update()
    {
      
    }
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("RightX") * RotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("RightY") * RotSpeed * Mathf.Deg2Rad;


        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);


    }
}