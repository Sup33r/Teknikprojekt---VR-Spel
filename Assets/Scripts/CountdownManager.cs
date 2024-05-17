using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshPro countdownText;
    void Start()
    {
        countdownText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCountdown(int seconds)
    {
        StartCoroutine(Countdown(seconds));
    }
    
    private IEnumerator Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        countdownText.text = "KÖR!";
        yield return new WaitForSeconds(1);
        countdownText.text = "";
        gameObject.SetActive(false);
    }
}
