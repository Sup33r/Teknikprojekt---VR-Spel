using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
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
            Destroy(gameObject);
        }
        previousY = currentY;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground)
        {
            //TODO: PARTIKLAR
            if (Data.Instance.gameMode == 2)
            {
                gameHandler.missed += 1;
                Destroy(gameObject);
            }
            else
            {
                gameHandler.score -= 1;
                gameHandler.health -= 1;
                gameHandler.missed += 1;
                AudioSource audio = gameObject.AddComponent<AudioSource>();
                audio.clip = Resources.Load<AudioClip>("Sounds/hit_sound");
                audio.Play();
                GetComponent<Renderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
                Destroy(gameObject, audio.clip.length);
            }
        } else if (collision.gameObject == head)
        {
            //TODO: PARTIKLAR
            if (Data.Instance.gameMode == 2)
            {
                gameHandler.health -= 1;
                AudioSource audio = gameObject.AddComponent<AudioSource>();
                audio.clip = Resources.Load<AudioClip>("Sounds/hit_sound");
                audio.Play();
                GetComponent<Renderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
                Destroy(gameObject, audio.clip.length);
            }
        }
    }
    
    //Check if the spheres y value increases, and if it does check how much it does increase by until it stops increasing
    
}
