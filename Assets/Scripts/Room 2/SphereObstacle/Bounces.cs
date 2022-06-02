using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounces : MonoBehaviour
{
    public float ySpeed;
    public float yTarget;
    public AudioSource noise;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, ySpeed, 0);
        ySpeed = Mathf.Lerp(ySpeed, yTarget, 0.025f);

        if (Input.GetKeyDown("space"))
        {
            noise.Play();
            ySpeed = 0.1f;
        }
    }
}
