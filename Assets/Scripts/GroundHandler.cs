using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHandler : MonoBehaviour
{
    public GameObject ground;
    void Start()
    {
        float playAreaSize = Data.Instance.playAreaSize;
        ground.transform.localScale = new Vector3(playAreaSize, 0f, playAreaSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
