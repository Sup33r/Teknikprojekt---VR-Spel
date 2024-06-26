using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsHandler : MonoBehaviour
{
    public float playAreaSize = 10;
    public GameObject ground;
    
    public void setPlayAreaSize(float size)
    {
        playAreaSize = size/3;
        ground.transform.localScale = new Vector3(playAreaSize, 0f, playAreaSize);
    }

    public void Update()
    {
        transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, transform.position.z);
    }

}
