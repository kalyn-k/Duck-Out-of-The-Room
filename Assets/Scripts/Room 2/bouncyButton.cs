using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouncyButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("SphereObstacle");
    }
}
