using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPayLine : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward), Color.red);
    }
}
