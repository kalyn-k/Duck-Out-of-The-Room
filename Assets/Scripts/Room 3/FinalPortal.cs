using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalPortal : MonoBehaviour
{
	public GameObject player;
	public static bool found;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{
			// m_T.text = "Game Completed!! Menu Scene will load soon..."
			found = true;
			Invoke("MoveScene", 4);
		}
	}
	
	void MoveScene()
	{
		SceneManager.LoadScene("Menu");
	}
}
