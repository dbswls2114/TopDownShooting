using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager i;
    public string userName;
    public TMP_Text NameText;

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
        Debug.Log(PlayerPrefs.HasKey("Name"));
    }
}
