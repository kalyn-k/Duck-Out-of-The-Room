using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tileButton : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("TileSlide");
    }
}
