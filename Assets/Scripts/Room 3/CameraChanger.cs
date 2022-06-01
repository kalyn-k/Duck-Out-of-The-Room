using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    public GameObject cam1, camMap, crosshair;
	public KeyCode map;
	public KeyCode main;
	public static bool done = true;
	// Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
		camMap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(map))
        {
			
			// deactivate character movement
			PlayerMovement.canMove = false;
			done = false;
			Debug.Log(done);
			// change camera view
			cam1.SetActive(false);
			camMap.SetActive(true);
			crosshair.SetActive(false);
        }
		if (Input.GetKeyDown(main))
        {
			// deactivate character movement
			PlayerMovement.canMove = true;
			// change camera view\
			done = true;
			cam1.SetActive(true);
			camMap.SetActive(false);
			crosshair.SetActive(true);
        }
    }
}
