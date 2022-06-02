using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearScript : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject portal;
    public AudioSource noise;
    public bool play1, play2, play3;
    // Start is called before the first frame update
    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
        obj3.SetActive(false);
        portal.SetActive(false);
    }

    void Update()
    {
        if (Object3.pressed == true && play1 == false)
        {
            noise.Play();
            obj3.SetActive(false);
            portal.SetActive(true);
            play1 = true;

        }

        else if (Object2.pressed == true && play2 == false)
        {
            noise.Play();
            obj2.SetActive(false);
            obj3.SetActive(true);
            play2 = true;
        }

        else if (Object1.pressed == true && play3 == false)
        {
            noise.Play();
            obj1.SetActive(false);
            obj2.SetActive(true);
            play3 = true;
        }
    }

}
