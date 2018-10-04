using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text timerText;
    public Text yourTimerText;
    public float timer = 0f;

    private bool timerStop = false;

    private void Start()
    {
        yourTimerText.text = "";
    }

    void Update ()
    {
        if(timerStop == false)
        {
            timer += Time.deltaTime;

            int seconds = (int)(timer % 60);
            int minutes = (int)(timer / 60) % 60;

            string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

            timerText.text = timerString;
        }
        else
        {
            Time.timeScale = 0F;

            yourTimerText.text = timerText.text;
        }
    }

    public void stopTimer()
    {
        timerStop = true;
    }
}