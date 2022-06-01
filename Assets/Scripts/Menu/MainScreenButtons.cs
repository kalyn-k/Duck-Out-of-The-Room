using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenButtons : MonoBehaviour
{
    public GameObject Menu, Level, CreditInfo;
    public UnityEngine.UI.Button butL, butC, butBack;
    public UnityEngine.UI.Button but1, but2, but3, butTot;

    // Start is called before the first frame update
    void Start()
    {
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
        but3.gameObject.SetActive(false);
        butTot.gameObject.SetActive(false);
        butBack.gameObject.SetActive(false);
        Level.gameObject.SetActive(false);
        CreditInfo.gameObject.SetActive(false);
        
        butL.onClick.AddListener(LevelPress);
        butC.onClick.AddListener(CreditPress);
        butBack.onClick.AddListener(BackPress);
    }

    void LevelPress()
    {
        Debug.Log("L press");
		butTot.gameObject.SetActive(true);
        but1.gameObject.SetActive(true);
        but2.gameObject.SetActive(true);
        but3.gameObject.SetActive(true);
        Level.SetActive(true);
        butBack.gameObject.SetActive(true);

        butL.gameObject.SetActive(false);
        butC.gameObject.SetActive(false);
        Menu.SetActive(false);
    }

    void CreditPress()
    {
        Debug.Log("C press");
        CreditInfo.gameObject.SetActive(true);
        butBack.gameObject.SetActive(true);

        butL.gameObject.SetActive(false);
        butC.gameObject.SetActive(false);
        Menu.SetActive(false);
    }

    void BackPress()
    {
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
        but3.gameObject.SetActive(false);
        butTot.gameObject.SetActive(false);
        butBack.gameObject.SetActive(false);
        Level.gameObject.SetActive(false);
        CreditInfo.gameObject.SetActive(false);
        
        butL.gameObject.SetActive(true);
        butC.gameObject.SetActive(true);
        Menu.SetActive(true);
    }
}
