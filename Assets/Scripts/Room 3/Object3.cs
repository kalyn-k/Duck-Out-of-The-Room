using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3 : MonoBehaviour
{
    public GameObject portal, obj3;
	public static bool pressed;

    void OnMouseDown()
    {
        portal.SetActive(true);
		obj3.SetActive(false);
		pressed = true;
    }
}
