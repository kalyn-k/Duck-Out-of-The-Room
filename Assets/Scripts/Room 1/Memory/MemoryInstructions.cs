using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MemoryInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Press number keys that correspond to tiles to flip. Find matching tiles.";
    }

    // Update is called once per frame
    void Update()
    {
        //new WaitForSeconds(time * Time.deltaTime);
		if(memVar.x == true){
			m_TextComponent.text = "Game Complete!";
		}
    }
}
