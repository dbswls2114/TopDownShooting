using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
   
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void ChangeSetName(string _name)
    {
        GameManager.i.userName = _name;
    }

    public void OpenSetNameButtonClick()
    {
        GameManager.i.ChangeSetNamePanel.SetActive(true);
    }

    public void ChangeSetNameButtonClick()
    {
        GameManager.i.NameText.text = GameManager.i.userName;         
        GameManager.i.ChangeSetNamePanel.SetActive(false);
        PlayerPrefs.SetString("Name", GameManager.i.userName);
    }
}
