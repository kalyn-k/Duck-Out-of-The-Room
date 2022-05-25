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
        //d1.SetActive(true);
        d1.SetActive(false);
        //d2.SetActive(true);
        d2.SetActive(false);
        //portal.SetActive(false);

        /*if (TileVar.y == true)
        {
            d1.SetActive(false);
        }
        if (JigVar.x == true)
        {
            d1.SetActive(false);
            d2.SetActive(false);
        }*/
    }
}
