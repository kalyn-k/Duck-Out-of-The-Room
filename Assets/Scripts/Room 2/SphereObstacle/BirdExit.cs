using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdExit : MonoBehaviour
{
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(current);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Room 2");
        }
    }
}

