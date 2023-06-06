using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreTMP;
    public float Easy = 2F;
    public float Normal = 4F;
    public float Hard = 8F;
    public int reduceScore = 100;
    public int VisualScore = 10;
    public string SaveKey = "Score";
    private float Speed;
    private float _score = 0;
    private float _multiplier;
    private void Start()
    {
        _multiplier = Easy;
    }
    public void MathScore(float time, bool die)
    {
        _score = (time * _multiplier * Speed * VisualScore);
        if (!die)
        {
            _score *= reduceScore;
        }
        ScoreTMP.text = _score.ToString("F3");
    }
    public void SetScore(float score)
    {
        _score = score;
        ScoreTMP.text = _score.ToString("F3");
    }
    public float GetScore()
    {
        ScoreTMP.text = _score.ToString("F3");
        return _score;

    }

    public void SwitchSpeed(int speedID, float speed)
    {
        Speed = speed;
        switch (speedID)
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
