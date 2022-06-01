using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
    public GameObject obj2, obj1;
	public static bool pressed;

    void OnMouseDown()
    {
        obj2.SetActive(true);
		obj1.SetActive(false);
		pressed = true;
    }
}
