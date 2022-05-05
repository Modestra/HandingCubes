using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlock : MonoBehaviour
{
    public Vector3 obj_select_transform;
    public Quaternion obj_select_rotation;
    public GameObject obj_select; //Обязательно присвоить объекту Rigidbody
    public Renderer rend;
    public Camera cam;
    public bool BlockIsConnect;
    public List<Transform> t_array;
    void Start()
    {
        rend = GetComponent<Renderer>();
        RotateCamera rc = new RotateCamera();
    }

    void Update()
    {
        HitBlock();
    }
    void HitBlock()
    {
        RotateCamera rc = new RotateCamera();
        CreateBox cb = new CreateBox();
        if (Input.GetMouseButton(0)) //Применять на главную камеру!
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                obj_select = hit.collider.gameObject;
                obj_select_transform = hit.transform.position; //Захват координат
                obj_select_rotation = hit.transform.rotation;

            }

        }
        else if (obj_select && obj_select.tag == "box" && obj_select.tag != "non-playble")
        {
            Vector3 mousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.y));
            obj_select.GetComponent<Rigidbody>().useGravity = false;
            obj_select.GetComponent<Rigidbody>().MovePosition(new Vector3(mousePosition.x, mousePosition.y, mousePosition.z)); // Работает!
            BlockIsConnect = true;
            if (BlockIsConnect == true)
            {
                obj_select.GetComponent<Rigidbody>().useGravity = true;

            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 270, 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 270, 0);
            }
            if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 315, 0);
            }
            if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.A))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 225, 0);
            }
            if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 135, 0);
            }
            if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
            {
                obj_select.transform.rotation = Quaternion.Euler(0, 45, 0);
            }
        }
    }
}
