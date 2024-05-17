using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    
    //Data som ska sparas mellan scener
    public float playAreaSize = 0;
    public int gameMode = 0; // 0 = endless, 1 = tidsspel, 2 = survival
    public static Data Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
