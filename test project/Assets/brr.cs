using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brr : MonoBehaviour
{
    public GameObject Levels;

    public void Play()
    {

        Levels.SetActive(!Levels.activeSelf);

    }
}