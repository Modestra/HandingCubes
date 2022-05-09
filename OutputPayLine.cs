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
        Ray ray = new Ray(transform.position, transform.up);
        Debug.DrawLine(transform.position, transform.up, Color.red);
    }
}
