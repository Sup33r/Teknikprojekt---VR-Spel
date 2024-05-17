using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHandler : MonoBehaviour
{
    //Funktion som sätter storleken på marken beroende på playAreaSize
    
    public GameObject ground;
    void Start()
    {
        float playAreaSize = Data.Instance.playAreaSize;
        ground.transform.localScale = new Vector3(playAreaSize, 0f, playAreaSize);
    }
}
