using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager i;
    public GameObject player;

    public string userName;
    public TMP_Text NameText;
    public GameObject ChangeSetNamePanel;

    public GameObject charone;
    public GameObject chartwo;

    private void Awake()
    {
        i = this;
    }

    void Start()
    {     
        if(PlayerPrefs.GetInt("PlayerChar")==0)
        {
            Instantiate(charone);
        }
        else
        {
            Instantiate(chartwo);
        }

        userName = PlayerPrefs.GetString("Name");
        player = GameObject.FindGameObjectWithTag("Player");
        NameText = player.transform.GetChild(1).transform.GetChild(0).GetComponent<TMP_Text>();
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
