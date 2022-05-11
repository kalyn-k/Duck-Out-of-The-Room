using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitButton : MonoBehaviour
{
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(current);
    }

    //private void OnMouseDown(){
        //Debug.Log("clicked exit");
        //SceneManager.LoadScene("Main Scene");
    //}
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
