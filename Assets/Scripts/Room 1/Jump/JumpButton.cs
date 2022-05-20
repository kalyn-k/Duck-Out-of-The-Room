using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpButton : MonoBehaviour
{
	public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
       c.SetActive(false);
		if(memVar.x == true || jVar.forever == true){
			c.SetActive(true);
		}
    }
    
    private void OnMouseDown(){
        Debug.Log("clicked");
        SceneManager.LoadScene("Jump");
    }
}
