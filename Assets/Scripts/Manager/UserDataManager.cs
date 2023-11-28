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
    public Button startButton;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void startButtonClick()
    {        
        PlayerPrefs.SetString("Name", input.text);        
        SceneManager.LoadScene("MainScene");
        //PlayerPrefs.GetString("Name"); 불러올때
    }
}

