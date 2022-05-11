using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
	public float movementSpeed = 10f;

	float movement = 0f;

	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	movement = Input.GetAxis("Horizontal")	* movementSpeed;
        
    }

    void FixedUpdate()
    {
    	Vector2 velocity = rb.velocity;
    	velocity.x = movement;
    	rb.velocity = velocity;

    }


}
