using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public GameObject obj; //Объект, который мы будем копировать
    public float y, x, z; //Координаты
    public List<GameObject> array; //Список созданных блоков
    public List<Vector3> array_t; //Список созданных блоков
    public Renderer rend; //Раскрашивание блока
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
            Debug.Log("Количество объектов: ");
        }

    }
    public void Create()
    {     
        obj = Instantiate(obj, new Vector3(x, y, z), Quaternion.Euler(0, 0, -90)) as GameObject;
        obj.gameObject.name = "Cube";
        array.Add(obj);
        Debug.Log("Количество объектов: " + array.Count);
        
    }
    public void SaveBlocks() //Запись координат всех блоков
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "non-playble")
        {
            SaveManager sm = new SaveManager();
            array_t.Add(obj.transform.position); //Объект добавляется, но только при его создании - доработать, выполнить проверку и соотнести название блока с его положением
            Debug.Log(obj.transform.position);

        }
    }
}
