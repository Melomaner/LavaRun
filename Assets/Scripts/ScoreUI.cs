using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI ScoreTMP;
    public float scoreMax = 10000;
    public int SpeedEasy = 30;
    public int SpeedNormal = 20;
    public int SpeedHard = 10;
    public float score = 0;
    public float scoreTime = 0;
    public float scoreAll = 0;
    int _multiplierS;
    int _multiplierT;

    private void Start()
    {
        _multiplierS = SpeedEasy;
        _multiplierT = SpeedHard;
    }
    public void SetScore(float time)
    {
        score = scoreMax - (time * _multiplierS);
        scoreTime = (time * _multiplierT);
        scoreAll = scoreMax - score + scoreTime;
        score.ToString("F3");
        ScoreTMP.text = "" + score + " - " + scoreTime + " - " + scoreAll;
        // Score (440)500
        // (123) 1200
    }
    public void SwitchSpeed(int speed)
    {
        switch (speed)
        {
            case 1:
                _multiplierS = SpeedEasy;
                _multiplierT = SpeedHard;
                break;
            case 2:
                _multiplierS = SpeedNormal;
                _multiplierT = SpeedNormal;
                break;
            case 3:
                _multiplierS = SpeedHard;
                _multiplierT = SpeedEasy;
                break;
            default: 
                break;
        }
    }
}
