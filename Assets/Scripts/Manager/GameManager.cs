using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager i;
    public string userName;
    public TMP_Text NameText;
    public GameObject ChangeSetNamePanel;

    private void Awake()
    {
        i = this;
    }

    void Start()
    {     
        userName = PlayerPrefs.GetString("Name");
        NameText.text = userName;
    }

    void Update()
    {
        //Debug.Log(PlayerPrefs.HasKey("Name"));
    }

    public void ChangeSetName(string _name)
    {
        userName = _name;        
    }
    public void OpenSetNameButtonClick()
    {
        ChangeSetNamePanel.SetActive(true);
    }
    public void ChangeSetNameButtonClick()
    {
        NameText.text = userName;
        ChangeSetNamePanel.SetActive(false);
        PlayerPrefs.SetString("Name", userName);
    }
}
