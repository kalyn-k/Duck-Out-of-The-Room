using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jigsawButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("Jigsaw");
    }
}
