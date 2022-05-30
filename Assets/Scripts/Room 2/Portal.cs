using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
	public GameObject player;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{
			SceneManager.LoadScene("Room 3");
		}
	}
}
