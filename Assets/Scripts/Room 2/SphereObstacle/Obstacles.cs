using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float sendTimer = 1;
    public float frequency = 8;
    public float position;
    public GameObject myObstacle;
    public GameObject mainCharacter;

    // Update is called once per frame
    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            position = Random.Range(-1.24f, 1.76f);
            transform.position = new Vector3(3.43f, position, 0f);
            Instantiate(myObstacle, transform.position, transform.rotation);
            sendTimer = frequency;
        }
        if (mainCharacter != null)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
