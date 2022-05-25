using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocator : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if(JigVar.here == true)
        {
            player.transform.position = new Vector3(6.54f, 1.5f, -7.84f);
        }
        else
        {
            player.transform.position = new Vector3(5f, 1.5f, 5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
