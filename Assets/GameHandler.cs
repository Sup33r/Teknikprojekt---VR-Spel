using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private Data data;
    public float score = 0;
    public int health = 0;
    public float time = 0;
    void Start()
    {
        switch (Data.Instance.gameMode)
        {
            case 0:
                StartEndlessGame();
                break;
            case 1:
                StartTimedGame();
                break;
            case 2:
                StartSurvivalGame();
                break;
            default:
                Debug.Log("Invalid game mode");
                break;
        }
        InvokeRepeating("AddScore", 1.0f, 1.0f);
        //Call a function that initializes the game
        //Keep track of time, score, and other game state
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Data.Instance.gameMode == 0)
        {
            time += Time.deltaTime;
            if(health <= 0)
            {
                GameOver();
            }
        } else if (Data.Instance.gameMode == 1)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                GameOver();
            }
            
        } else if (Data.Instance.gameMode == 2)
        {
            time += Time.deltaTime;
            if(health <= 0)
            {
                GameOver();
            }
        }
    }
    
    public void GameOver()
    {
        //Call a function that ends the game
        //Display the final score and other game stats
    }
    
    //Survival är att man ska dodga kloten och inte bli träffad. Blir man träffad så går ens health ner. När man har 0 health så är spelet slut.
    public void StartSurvivalGame()
    {
        time = 0; //Sätt tiden till noll, gör så den tickar upp.
    }
    
    //Endless är att man har health, och när man missar att ta ett klot så går den ner. När man har 0 health så är spelet slut.
    public void StartEndlessGame()
    {
        time = 0; // Sätt tiden till noll, gör så den tickar upp.
    }
    
    //Timed är att man ska försöka få så hög score på tiden som man får. När tiden är slut summeras ens score.
    public void StartTimedGame()
    {
        time = 60f; // Sätt tiden till värde, gör så den tickar ner.
    }

    public void AddScore()
    {
        this.score++;
    }
}
