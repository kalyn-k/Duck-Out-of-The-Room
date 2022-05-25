using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JigExit : MonoBehaviour
{
    public GameObject current;
    public static int completed;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(current);
    }

    void Update()
    {
        Debug.Log(completed);
        if (completed == 33)
        {
            Debug.Log("here");
            JigVar.x = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Room 2");
        }
    }
}
