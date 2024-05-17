using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    // Nedräkningstexten
    private TextMeshPro countdownText;
    void Start()
    {
        countdownText = GetComponent<TextMeshPro>();
    }
    
    // Startar en nedräkning i antal sekunder
    public void StartCountdown(int seconds)
    {
        StartCoroutine(Countdown(seconds));
    }
    
    // Nedräkningen i sig
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
