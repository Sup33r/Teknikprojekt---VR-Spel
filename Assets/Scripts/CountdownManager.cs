using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    // Nedräkningstexten
    private TextMeshProUGUI countdownText;
    // Ljuden som spelas vid nedräkning
    private AudioSource countdownAudio1;
    private AudioSource countdownAudio2;
    void Start()
    {
        countdownAudio1 = gameObject.AddComponent<AudioSource>();
        countdownAudio1.clip = Resources.Load<AudioClip>("Sounds/countdown-1");
        countdownAudio2 = gameObject.AddComponent<AudioSource>();
        countdownAudio2.clip = Resources.Load<AudioClip>("Sounds/countdown-2");
        countdownText = GetComponent<TextMeshProUGUI>();
    }
    
    // Startar en nedräkning i antal sekunder
    public float StartCountdown(int seconds)
    {
        StartCoroutine(Countdown(seconds));
        return seconds;
    }
    
    // Nedräkningen i sig
    private IEnumerator Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            countdownText.text = i.ToString();
            countdownAudio1.Play();
            yield return new WaitForSeconds(1);
        }
        countdownAudio2.Play();
        countdownText.text = "KÖR!";
        yield return new WaitForSeconds(1);
        countdownText.text = "";
        gameObject.SetActive(false);
    }
}
