using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JigsawInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
	public int time;
    // Start is called before the first frame update
	void Start()
    {
		CameraMove.move = false;
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Pickup piece by right clicking. Drop piece by pressing tab.";
		Invoke("Change", time);
    }

    // Update is called once per frame
    void Change()
    {
		m_TextComponent.text = "Press space to check if piece in right place.";
		Invoke("Allow", time);
    }
	
	void Allow()
	{
		m_TextComponent.gameObject.SetActive(false);
		CameraMove.move = true;
	}
	
	void Update()
	{
		if(JigVar.x == true)
		{
			m_TextComponent.gameObject.SetActive(true);
			m_TextComponent.color = Color.white;
			m_TextComponent.text = "Game Completed!.";
		}
	}
}
