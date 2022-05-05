using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private Vector2 trans;
    public float speed = 2000.0F;
    private bool mouse;
    public float zoom = 80f;
    public Camera cam;
    void Start() //Привязывать только к камере
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        MouseTransform(true);
        MouseZoom();

    }
    public void MouseTransform(bool hitblock)
    {
        if (Input.GetMouseButtonDown(1))
        {
            mouse = true;
            hitblock = false;
        }
        if (Input.GetMouseButtonUp(1))
        {            
            mouse = false;
            hitblock = true;
        }
        trans.x = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        trans.y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
        if (mouse == true)
        {
            transform.Rotate(0, trans.x, 0);
        }
        else if (mouse == false)
        {
            return;
        }
    }
    public void MouseZoom()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Кнопка нажата, зум работает");
            cam.fieldOfView += zoom;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Кнопка нажата, зум работает");
            cam.fieldOfView -= zoom;
        }
    }
}

