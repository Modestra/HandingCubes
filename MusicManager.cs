using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audio;
    private void Awake()
    {
        DontDestroyOnLoad(audio);
    }
}
