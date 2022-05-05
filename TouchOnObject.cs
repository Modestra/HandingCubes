using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchOnObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Координаты точки: " + hit.collider.gameObject.transform.position);
            }
        }
    }
}
