using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private Data data;
    public int score = 0;
    public int health = 0;
    public float time = 0;
    void Start()
    {
        if (Data.Instance.gameMode == 0)
        {
            StartEndlessGame();
        }
        else if (Data.Instance.gameMode == 1)
        {
            StartTimedGame();
        }
        else if (Data.Instance.gameMode == 2)
        {
            StartSurvivalGame();
        }
        //Call a function that initializes the game
        //Keep track of time, score, and other game state
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
    
    public void AddScore(int score)
    {
        //Lägg till score
        this.score += score;
    }
    
    public void RemoveScore(int score)
    {
        //Ta bort score
        this.score -= score;
    }
}
