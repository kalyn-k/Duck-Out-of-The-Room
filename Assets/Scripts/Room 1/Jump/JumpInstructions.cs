using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Use arrow keys to move. Jump to the top!";
    }

    // Update is called once per frame
    void Update()
    {
		if(jVar.x == true){
			m_TextComponent.text = "Game Complete!";
		}
    }
}
