using UnityEngine;
using UnityEngine.UI;

public class AlarmClock1 : MonoBehaviour
{
    public float alarmTime = 3600f; // The time in seconds when the alarm should go off
    private bool alarmSet = false;
    private bool isPaused = false;
    private float pausedTime = 0f;
    public Text countdownText; // The UI text to display the countdown timer
    public Text dateTimeText; // The UI text to display the current date and time
    private float startTime = 0f; // The time in seconds when the timer should start
    private float endTime = 0f; // The time in seconds when the timer should end

    void Update()
    {
        if (!alarmSet && Time.time >= endTime)
        {
            Debug.Log("Alarm went off at " + System.DateTime.Now.ToString("HH:mm:ss"));
            alarmSet = true;
            countdownText.text = "ALARM!";
        }
        else if (!alarmSet && !isPaused)
        {
            float timeLeft = endTime - (Time.time - startTime);
            int hours = Mathf.FloorToInt(timeLeft / 3600f);
            int minutes = Mathf.FloorToInt((timeLeft - hours * 3600f) / 60f);
            int seconds = Mathf.FloorToInt(timeLeft % 60f);
            string timerString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            countdownText.text = timerString;
        }

        dateTimeText.text = System.DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
    }

    public void SetAlarm(float timeInSeconds)
    {
        endTime = Time.time + timeInSeconds;
        startTime = Time.time;
        alarmSet = false;
        isPaused = false;
        Debug.Log("Alarm set for " + timeInSeconds + " seconds from now, at " + System.DateTime.Now.AddSeconds(timeInSeconds).ToString("HH:mm:ss dd/MM/yyyy"));
    }

    public void StopAlarm()
    {
        alarmSet = true;
        Debug.Log("Alarm stopped at " + System.DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"));
    }

    public void PauseTimer()
    {
        if (!isPaused && !alarmSet)
        {
            pausedTime = Time.time - (endTime - pausedTime);
            isPaused = true;
            Debug.Log("Timer paused at " + System.DateTime.Now.ToString("HH:mm:ss"));
        }
    }

    public void ResumeTimer()
    {
        if (isPaused && !alarmSet)
        {
            pausedTime = Time.time - pausedTime;
            isPaused = false;
            Debug.Log("Timer resumed at " + System.DateTime.Now.ToString("HH:mm:ss"));
        }
    }

    public void setTimeStart(float timeInSeconds)
    {
        startTime = Time.time + timeInSeconds;
        Debug.Log("Timer start time set for " + System.DateTime.Now.AddSeconds(timeInSeconds).ToString("HH:mm:ss dd/MM/yyyy"));
    }

    public void setTimeEnd(float timeInSeconds)
    {
        endTime = Time.time + timeInSeconds;
        Debug.Log("Timer end time set for " + System.DateTime.Now.AddSeconds(timeInSeconds).ToString("HH:mm:ss dd/MM/yyyy"));
    }
}
