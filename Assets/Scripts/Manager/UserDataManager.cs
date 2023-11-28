using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using TMPro;
using UnityEngine.SceneManagement;

public class UserDataManager : MonoBehaviour
{
    public TMP_InputField input;
    public Image PlayercharOne;
    public Image PlayercharTwo;


    public void startButtonClick()
    {        
        PlayerPrefs.SetString("Name", input.text);
        SceneManager.LoadScene("MainScene");
        //PlayerPrefs.GetString("Name"); 불러올때
    }

    public void Selectcharone()
    {
        PlayercharOne.color = Color.yellow;
        PlayercharTwo.color = Color.white;
        PlayerPrefs.SetInt("PlayerChar", 0);
    }
    public void Selectchartwo()
    {
        PlayercharOne.color = Color.white;
        PlayercharTwo.color = Color.yellow;
        PlayerPrefs.SetInt("PlayerChar", 1);
    }
}

