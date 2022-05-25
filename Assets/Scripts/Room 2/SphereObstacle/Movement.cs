using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float life = 10;
    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;
        if(life <= 0)
        {
            BirdVar.z = true;
            SceneManager.LoadScene("Room 2");
        }
        else
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }
}
