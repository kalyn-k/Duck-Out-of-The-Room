using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GeneralInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
	public int time;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Move character using arrow keys. Move camera using mouse.";
		Invoke("Change", time);
    }

    // Update is called once per frame
    void Change()
    {
        //new WaitForSeconds(time * Time.deltaTime);
		m_TextComponent.text = "Click on game by putting in center of screen and right clicking.";
    }
	
	void Update()
	{
		if(Var.x == true)
		{
			m_TextComponent.text = "After completing all games in room, go through portal to advance.";
		}
	}
}
