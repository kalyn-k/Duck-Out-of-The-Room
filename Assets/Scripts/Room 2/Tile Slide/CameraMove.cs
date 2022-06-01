using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float y = 0.0f;
    private float pitch = 0.0f;
	
	public static bool move = true;

    // Update is called once per frame
    void Update()
    {
		if(move == true){
			y += speedH * Input.GetAxis("Mouse X");
			pitch -= speedV * Input.GetAxis("Mouse Y");

			transform.eulerAngles = new Vector3(pitch, y, 0.0f);
		}
    }
}
