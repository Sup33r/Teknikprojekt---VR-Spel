using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public GameObject dataGameObject;
    
    public void onEndlessButton()
    {
        dataGameObject.GetComponent<Data>().playAreaSize = GameObject.Find("Settings").GetComponent<SettingsHandler>().playAreaSize;
        dataGameObject.GetComponent<Data>().endless = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}