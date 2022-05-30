using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3 : MonoBehaviour
{
    public GameObject portal;

    void OnMouseDown()
    {
        portal.SetActive(true);
    }
}
