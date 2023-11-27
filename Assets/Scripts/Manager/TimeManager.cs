using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public TextMeshPro timeText;
    public Text text;
    public TextMesh textmesh;
    public TMP_Text realText;

    private void Awake()
    {
       
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        DateTime nowData = DateTime.Now;
        realText.text = $"{nowData.Hour} : {nowData.Minute:D2} : {nowData.Second:D2}";
    }
}
