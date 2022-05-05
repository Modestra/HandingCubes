using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class SaveManager : MonoBehaviour
{
    public List<Transform> coords;
    [System.Serializable] //������������ ������
    public class Position
    {
        public float x;
    }
    string filePath;
    void Start()
    {
    }
    public void SaveGame()
    {
        //----------------------------------------------------------------------------------------------------------------
        BinaryFormatter bi = new BinaryFormatter();
        string path = Application.persistentDataPath + "/block"; //�������������� ��������� �����,
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);//�������� �����, ��� ����� ���������� ����
            Debug.Log("����� �������");
        }
        Debug.Log("������ ������ ������� " + path);
        FileStream fs = new FileStream(path + "/SaveGameTest", FileMode.Create); //�������� ����� � ������ � ���� ������
        //-----------------------------------------------------------------------------------------------------------------


        Position pos = new Position(); //����� ��������� ������, ���� �� ���� ��� ���� � ��� �������
        pos.x = transform.position.x;

        CreateBox cb = new CreateBox();
        foreach(var obj in cb.array)
        {
            Debug.Log(obj);
        }

        bi.Serialize(fs, pos); //������������ ������
        fs.Close(); //�������� �����



    }
    public void LoadGame()
    {

    }
    public void FileCreate()
    {

    }
}

