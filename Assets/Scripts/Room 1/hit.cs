using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
	public GameObject player;
	bool isPlayerExit;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{
			SceneManager.LoadScene("Room 2");
		}
	}
}
