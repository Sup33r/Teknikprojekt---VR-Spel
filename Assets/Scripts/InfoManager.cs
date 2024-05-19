using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    // Nedräkningstexten
    private TextMeshProUGUI infoText;
    private GameHandler gameHandler;
    private int gameMode;
    void Start()
    {
        infoText = GetComponent<TextMeshProUGUI>();
        gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        gameMode = Data.Instance.gameMode;
    }

    private void Update()
    {
        if(gameMode == 0 || gameMode == 2)
        {
            infoText.text = "Antal liv: " + gameHandler.health + "\n\nPasserad tid: " + gameHandler.time + "s";        }
        else if(gameMode == 1)
        {
            infoText.text = "Kvarstående tid: " + gameHandler.time + "s";
        }
    }
}