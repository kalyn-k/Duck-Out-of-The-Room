using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Move tile by putting in center of screen and right clicking. Put tiles in order.";
    }

    // Update is called once per frame
    void Update()
    {
		if(TileVar.y == true){
			m_TextComponent.text = "Game Complete!";
		}
    }
}