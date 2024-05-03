using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ground;
    private GameHandler gameHandler;
    void Start()
    {
        ground = GameObject.Find("Ground");
        gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground)
        {
            Debug.Log("Sphere collided");
            gameHandler.RemoveScore(1);
        }
    }
}
