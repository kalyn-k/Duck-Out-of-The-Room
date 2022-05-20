using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnMouseDown(){
        Debug.Log("clicked");
        SceneManager.LoadScene("Memory");
    }
}

