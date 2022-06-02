using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
	public static bool pressed;

    public AudioSource noise;

    void OnMouseDown()
    {
        
        pressed = true;
        //Invoke("ChangeButton", time);
    }

    void ChangeButton()
    {
        
    }
}
