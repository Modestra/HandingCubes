using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPayLine : MonoBehaviour
{
    private Transform point;
    public GameObject goal;
    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, -transform.up*1000);
        Debug.DrawLine(transform.position, -transform.up*1000, Color.red);
        if (Physics.Raycast(ray, out hit))
        {
            goal = Instantiate(goal, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
