using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    public int s = 100;
    public Text text;

    private void OnCollisionEnter(Collision collision)
        {
        s -= 1;
        text.text = s.ToString();
    }
}
