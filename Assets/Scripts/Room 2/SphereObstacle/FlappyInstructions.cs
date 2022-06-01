using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlappyInstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
	public int time;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Use space to bounce up. Don't hit the walls!";
		Invoke("Change", time);
    }

    // Update is called once per frame
    void Change()
    {
		m_TextComponent.gameObject.SetActive(false);
    }
}
