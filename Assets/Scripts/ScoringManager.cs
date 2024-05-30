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
        ShowScoring();
        if(gameMode == 0 || gameMode == 2)
        {
            scoringText.text = "Spelets tid: " + gameHandler.time + "s\n\nAntal liv: " + gameHandler.health + "\n\nPoäng Ackumulerade: " + gameHandler.score;
            
        }
        else if(gameMode == 1)
        {
            scoringText.text = "Poäng Ackumulerade: " + gameHandler.score;
        }
    }
    
    private void HideScoring()
    {
        transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
    }
    
    private void ShowScoring()
    {
        transform.parent.gameObject.GetComponent<Canvas>().enabled = true;
    }
}