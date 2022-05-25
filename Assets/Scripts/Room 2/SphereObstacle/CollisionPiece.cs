using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPiece : MonoBehaviour
{ 
    public float checkpointCount = 0;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Environment")
        {
            SceneManager.LoadScene("Room 2");
        }
        else if(other.gameObject.tag == "Checkpoint")
        {
            checkpointCount += 1;
        }
    }
}
