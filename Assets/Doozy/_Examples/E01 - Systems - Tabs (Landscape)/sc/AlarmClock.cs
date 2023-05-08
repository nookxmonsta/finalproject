using Michsky.MUIP;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class AlarmClock : MonoBehaviour
{
    public float alarmTime = 3600f; // The time in seconds when the alarm should go off
    private bool alarmSet = false;
    private bool isPaused = false;
    private float pausedTime = 0f;
    public TMP_Text countdownText; // The UI text to display the countdown timer
    public TMP_Text dateTimeText;
    public TMP_Text dateTimeText2; // The UI text to display the current date and time
    private float startTime = 0f; // The time in seconds when the timer should start
    private float endTime = 0f; // The time in seconds when the timer should end

    public DateTime startTime2;
    public DateTime startTime3;

    [SerializeField] CustomDropdown timeSet;

    void Update()
    {
        if (!alarmSet && Time.time >= alarmTime)
        {
            Debug.Log("Alarm went off at " + System.DateTime.Now.ToString("HH:mm:ss"));
            alarmSet = true;
            countdownText.text = "00:00:00";
        }
        else if (!alarmSet)
        {
            float timeLeft = alarmTime - Time.time;
            int hours = Mathf.FloorToInt(timeLeft / 3600f);
            int minutes = Mathf.FloorToInt((timeLeft - hours * 3600f) / 60f);
            int seconds = Mathf.FloorToInt(timeLeft % 60f);
            string timerString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            countdownText.text = timerString;
        }

        dateTimeText.text = System.DateTime.Now.ToString("HH:mm dd/MM/yyyy");
    }

    public void SetAlarmSet()
    {
        if (timeSet.selectedItemIndex == 0)
        {
            SetAlarm(50400);
            startTime2 = DateTime.Now;
            DateTime completionTime = startTime2.AddSeconds(50400.0f);
            Debug.Log("Alarm will complete at " + completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy"));
            dateTimeText2.text = completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy");
        }
        else if (timeSet.selectedItemIndex == 1)
        {
            SetAlarm(57600);
            startTime2 = DateTime.Now;
            DateTime completionTime = startTime2.AddSeconds(57600.0f);
            Debug.Log("Alarm will complete at " + completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy"));
            dateTimeText2.text = completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy");
        }
        else if (timeSet.selectedItemIndex == 2)
        {
            SetAlarm(64800);
            startTime2 = DateTime.Now;
            DateTime completionTime = startTime2.AddSeconds(64800.0f);
            Debug.Log("Alarm will complete at " + completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy"));
            dateTimeText2.text = completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy");
        }
        else if (timeSet.selectedItemIndex == 3)
        {
            SetAlarm(72000);
            startTime2 = DateTime.Now;
            DateTime completionTime = startTime2.AddSeconds(72000.0f);
            Debug.Log("Alarm will complete at " + completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy"));
            dateTimeText2.text = completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy");
        }
        else if (timeSet.selectedItemIndex == 4)
        {
            SetAlarm(82800);
            startTime2 = DateTime.Now;
            DateTime completionTime = startTime2.AddSeconds(82800.0f);
            Debug.Log("Alarm will complete at " + completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy"));
            dateTimeText2.text = completionTime.ToLocalTime().ToString("HH:mm dd/MM/yyyy");
        }
    }



    public void SetAlarm(float timeInSeconds)
    {
        alarmTime = Time.time + timeInSeconds;
        alarmSet = false;
        Debug.Log("Alarm set for " + timeInSeconds + " seconds from now, at " + System.DateTime.Now.AddSeconds(timeInSeconds).ToString("HH:mm:ss dd/MM/yyyy"));
    }

    public void StopAlarm()
    {
        alarmSet = true;
        Debug.Log("Alarm stopped at " + System.DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"));
    }

}