using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float sendTimer = 0;
    public float frequency = 9.93f;
    public GameObject floor;

    // Update is called once per frame
    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            Instantiate(floor, new Vector3(0.0f, 0.0f, -10.0f), transform.rotation);
            sendTimer = frequency;
        }
    }
}
