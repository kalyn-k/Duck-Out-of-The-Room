using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Entry : MonoBehaviour
{
    public GameObject y;
    // Start is called before the first frame update
    void Start()
    {
        y.SetActive(false);
        if (jVar.x == true)
        {
            Debug.Log("made it");
            y.SetActive(true);
        }
    }
}
