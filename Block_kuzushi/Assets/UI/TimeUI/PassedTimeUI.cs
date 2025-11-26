using UnityEngine;
using TMPro;
using NUnit.Framework;

public class PassedTimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    private float passedTime;
    private bool isRunning = false;

    void Update()
    {
        if (!isRunning) return;

        passedTime += Time.deltaTime;

        timeText.text = FormatTime(passedTime);
    }

    public void StartTime()
    {
        isRunning = true;
        passedTime = 0;
    }

    public void StopTime()
    {
        isRunning = false;
    }

    private string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);

        return $"{minutes:00}:{seconds:00}";
    }
}
