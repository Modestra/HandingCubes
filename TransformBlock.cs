using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBlock : MonoBehaviour
{
    public Transform obj_select;
    public Camera cam;
    void Start()
    {
        
    }

    void Update() //Применять на главную камеру!
    {

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                obj_select = hit.transform;
                obj_select.position += new Vector3(0, 1, 0);

            }

        }

    }
}
