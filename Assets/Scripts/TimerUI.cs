using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timer;
    float _timerTime = 0;
    public void SetTime(float time)
    {
        _timerTime = time;
        int hours = Mathf.FloorToInt(time / 3600f);
        int minutes = Mathf.FloorToInt((time - hours * 3600f) / 60f);
        float seconds = Mathf.FloorToInt(time - hours * 3600f - minutes * 60f);
        seconds.ToString("F3");
        timer.text = $"{hours}:{minutes}:{seconds}";
       // Score (440)500
       // (123) 1200
    }
}
