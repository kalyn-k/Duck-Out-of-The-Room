using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    public GameObject obj3, obj2;
	public static bool pressed;

    void OnMouseDown()
    {
        obj3.SetActive(true);
		obj2.SetActive(false);
		pressed = true;
    }
}
