using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollaBallinstructions : MonoBehaviour
{
	public TMP_Text m_TextComponent;
    // Start is called before the first frame update
    void Start()
    {
		m_TextComponent = GetComponent<TMP_Text>();
		m_TextComponent.text = "Move character using arrow keys to collect cubes.";
    }

    // Update is called once per frame
    void Update()
    {
        //new WaitForSeconds(time * Time.deltaTime);
		if(Var.x == true){
			m_TextComponent.text = "Game Complete! Exit all games by pressing R.";
		}
    }
}
