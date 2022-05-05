using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class SaveManager : MonoBehaviour
{
    public List<Transform> coords;
    [System.Serializable] //Сериализация класса
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
        string path = Application.persistentDataPath + "/block"; //Форматирование бинарного файла,
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);//Создание папки, где будет находиться файл
            Debug.Log("Папка создана");
        }
        Debug.Log("Скрипт записи включён " + path);
        FileStream fs = new FileStream(path + "/SaveGameTest", FileMode.Create); //Создание файла и запись в него данных
        //-----------------------------------------------------------------------------------------------------------------


        Position pos = new Position(); //Вывод координат блоков, пока не знаю для чего я это написал
        pos.x = transform.position.x;

        CreateBox cb = new CreateBox();
        foreach(var obj in cb.array)
        {
            Debug.Log(obj);
        }

        bi.Serialize(fs, pos); //Сериализация класса
        fs.Close(); //Закрытие файла



    }
    public void LoadGame()
    {

    }
    public void FileCreate()
    {

    }
}

