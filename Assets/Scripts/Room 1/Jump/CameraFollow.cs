using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public float speed = .3f;

    void Update()
    {
    	if (target.position.y > transform.position.y)
    	{
    		//transform.position = target.position + offset;
    		Vector3 newPos = new Vector3(target.position.x, target.position.y, target.position.z);
    		transform.position = Vector3.Lerp(transform.position, newPos, speed);
    	}
        
    }
}
