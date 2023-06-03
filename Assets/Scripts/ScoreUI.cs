using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreTMP;
    public int Easy = 1;
    public float Normal = 1.5F;
    public int Hard = 2;
    public int reduceScore = 10; 
    private float _score = 0;
    private float _multiplier;
    public string SaveKey = "Score";
    private void Start()
    {
        _multiplier = Easy;
    }
    public void MathScore(float time, bool die)
    {
        _score = (time * _multiplier);
        if (die)
        {
            _score /= reduceScore;
        }
        ScoreTMP.text = _score.ToString("F3");
    }
    public void SetScore(float score)
    {
        _score = score;
    }
    public float GetScore()
    {
        return _score;
    }

    public void SwitchSpeed(int speed)
    {
        switch (speed)
        {
            case 1:
                _multiplier = Easy;
                break;
            case 2:
                _multiplier = Normal;
                break;
            case 3:
                _multiplier = Hard;
                break;
            default: 
                break;
        }
    }
}
