
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upp : MonoBehaviour
{
    public GameObject Sphere;

    public void OnButtonDown()
    {
        Sphere.transform.Translate(0, 2, 0);
    }
}
