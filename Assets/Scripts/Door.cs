using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject y;
    // Start is called before the first frame update
    void Start()
    {
        y.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Var.x == true){
            Debug.Log("made it");
            y.SetActive(true);
        }
    }
}
