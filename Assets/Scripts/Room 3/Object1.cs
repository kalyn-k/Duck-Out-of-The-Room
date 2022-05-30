using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
    public GameObject obj2;

    void OnMouseDown()
    {
        obj2.SetActive(true);
    }
}
