using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomMover : MonoBehaviour
{
    public UnityEngine.UI.Button but1, but2, but3, butTot;

    // Start is called before the first frame update
    void Start()
    {
        but1.onClick.AddListener(Room1);
        but2.onClick.AddListener(Room2);
        but3.onClick.AddListener(Room3);
        butTot.onClick.AddListener(Tutorial);
    }

    void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    void Room1()
    {
        SceneManager.LoadScene("Room1");
    }

    void Room2()
    {
        SceneManager.LoadScene("Room 2");
    }

    void Room3()
    {
        SceneManager.LoadScene("Room 3");
    }
}
