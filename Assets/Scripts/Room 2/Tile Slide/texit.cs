using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class texit : MonoBehaviour
{
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(current);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Room 2");
        }
    }
}
