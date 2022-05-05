using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public Image Image;
    public bool select_level;
    public float val;
    public static bool GameisPaused = false;
    public GameObject PauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                BackToGame();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1); //Загрузочное меню

    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void GoingToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BackToGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    public void SliderEvents(Slider sl) //При перемещении бегунка менять изображение
    {
        val = (float)sl.value;
        Debug.Log(val);
        if (val == 0)
        {
            select_level = true;
        }
        else if (val == 1)
        {
            select_level = false;
        }
    }
    public void Select1()
    {
        if (select_level == true) {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Select2()
    {
        SceneManager.LoadScene(3);
    }
    public void Select3()
    {
        SceneManager.LoadScene(4);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
