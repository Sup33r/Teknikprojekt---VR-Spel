using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoringManager : MonoBehaviour
{
    // Nedräkningstexten
    private TextMeshProUGUI scoringText;
    private GameHandler gameHandler;
    private int gameMode;
    void Start()
    {
        scoringText = GetComponent<TextMeshProUGUI>();
        gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        gameMode = Data.Instance.gameMode;
    }
    

    public void DisplayScoring()
    {
        if(gameMode == 0 || gameMode == 2)
        {
            infoText.text = "Spelets tid: " + gameHandler.time + "s\n\nAntal liv: " + gameHandler.health;
            
        }
        else if(gameMode == 1)
        {
            infoText.text = "Kvarstående tid: " + gameHandler.time + "s";
        }
    }
}