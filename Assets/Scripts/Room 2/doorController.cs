using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject d1;
    public GameObject d2;
    //public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        d1.SetActive(true);
        d2.SetActive(true);
        //portal.SetActive(false);
        if (TileVar.y == true)
        {
            Debug.Log("made it");
            d1.SetActive(false);
        }
    }
}
