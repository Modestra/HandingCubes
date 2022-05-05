using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDiagonal : MonoBehaviour
{
    public Dropdown Dropdown;
    public void Change()
    {
        if (Dropdown.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else if (Dropdown.value == 1)
        {
            Screen.SetResolution(800, 600, true);
        }

    }
}
