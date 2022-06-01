using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Room3Instructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Look for first button. Press M key to view map.";
		
    }
	
	void Update()
	{
		if(CameraChanger.done == false)
		{
			m_TextComponent.text = "Press E key to exit map.";
		}
		
		else if(FinalPortal.found == true)
		{
			m_TextComponent.text = "Game Completed!! Menu Scene will load soon...";
			
		}
		
		else if(Object3.pressed == true)
		{
			m_TextComponent.text = "Last button found! Look for portal.";
			
		}
		
		else if(Object2.pressed == true)
		{
			m_TextComponent.text = "Second button found! Look for last button.";
		}
		
		else if(Object1.pressed == true)
		{
			m_TextComponent.text = "First button found! Look for second button.";
		}
		else 
		{
			m_TextComponent.text = "Look for first button. Press M key to view map.";
		}
		
	}
}
