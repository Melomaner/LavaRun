using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public void SetTime(float time)
    {
        int hours = Mathf.FloorToInt(time / 3600f);
        int minutes = Mathf.FloorToInt((time - hours * 3600f) / 60f);
        float seconds = Mathf.FloorToInt(time - hours * 3600f - minutes * 60f);
        seconds.ToString("F3");
        timer.text = $"{hours}:{minutes}:{seconds}";

    }
}
