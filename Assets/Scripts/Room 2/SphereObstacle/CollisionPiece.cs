using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPiece : MonoBehaviour
{ 
    public float checkpointCount = 0;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Environment")
        {
            Debug.Log("go back to room");
        }
        else if(other.gameObject.tag == "Checkpoint")
        {
            checkpointCount += 1;
        }
    }
}
