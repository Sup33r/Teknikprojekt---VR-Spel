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
            infoText.text = "Antal liv: " + gameHandler.health + "\n\nPasserad tid: " + gameHandler.time.ToString("F1") + "s" + "\n\nAckumulerade poäng: " + gameHandler.score;
        }
        else if(gameMode == 1)
        {
            if(gameHandler.time <= 0)
            {
                HideInfo();
            }
            infoText.text = "Kvarstående tid: " + gameHandler.time.ToString("F1") + "s" + "\n\nAckumulerade poäng: " + gameHandler.score;
        }
    }
    
    private void HideInfo()
    {
        transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
    }
}