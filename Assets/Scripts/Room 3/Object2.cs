using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    public GameObject obj3;

    void OnMouseDown()
    {
        obj3.SetActive(true);
    }
}
