using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollaBallMove : MonoBehaviour
{
    //public CharacterController controller;
    private Rigidbody rb;

    public AudioSource hitThing;
    
    public int total = 0;
    
    public float speed = 12f;
        
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3 (x, 0.0f, z);
        
        rb.AddForce(move * speed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            hitThing.Play();
            other.gameObject.SetActive(false);
            total = total + 1;
        }
        if (total == 2){
            Debug.Log("here1");
            Var.x = true;
        }
        else {
            Var.x = false;
        }
    }
}