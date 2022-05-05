using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public GameObject obj; //������, ������� �� ����� ����������
    public float y, x, z; //����������
    public List<GameObject> array; //������ ��������� ������
    public List<Vector3> array_t; //������ ��������� ������
    public Renderer rend; //������������� �����
    public bool block_connect;

    void Start()
    {
        rend = GetComponent<Renderer>();     
    }

    void Update()
    {
       
    }
    public void Delete()
    {
        foreach (var obj in array) {
            array.Remove(obj);
            Destroy(obj);
            Debug.Log("���������� ��������: ");
        }

    }
    public void Create()
    {     
        obj = Instantiate(obj, new Vector3(x, y, z), Quaternion.Euler(0, 0, -90)) as GameObject;
        obj.gameObject.name = "Cube";
        array.Add(obj);
        Debug.Log("���������� ��������: " + array.Count);
        
    }
    public void SaveBlocks() //������ ��������� ���� ������
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "non-playble")
        {
            SaveManager sm = new SaveManager();
            array_t.Add(obj.transform.position); //������ �����������, �� ������ ��� ��� �������� - ����������, ��������� �������� � ��������� �������� ����� � ��� ����������
            Debug.Log(obj.transform.position);

        }
    }
}
