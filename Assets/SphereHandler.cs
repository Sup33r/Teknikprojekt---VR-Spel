using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ground;
    public GameObject head;
    private GameHandler gameHandler;
    private float previousY;
    private bool IsIncreasing = false;
    void Start()
    {
        ground = GameObject.Find("Ground");
        head = GameObject.Find("Head");
        gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        previousY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float currentY = transform.position.y;
        if (currentY > previousY)
        {
            IsIncreasing = true;
        }
        else if (IsIncreasing)
        {
            IsIncreasing = false;
            gameHandler.score += ((int) Math.Round(previousY / 2));
        }
        previousY = currentY;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground)
        {
            Debug.Log("Sphere collided");
            //Partiklar
            if (Data.Instance.gameMode == 2)
            {
                gameHandler.missed += 1;
            }
            else
            {
                gameHandler.score -= 1;
                gameHandler.health -= 1;
                gameHandler.missed += 1;
            }
            Destroy(gameObject);
        } else if (collision.gameObject == head)
        {
            //Partiklar
            if (Data.Instance.gameMode == 2)
            {
                gameHandler.health -= 1;
                Destroy(gameObject);
            }
        }
    }
    
    //Check if the spheres y value increases, and if it does check how much it does increase by until it stops increasing
    
}
