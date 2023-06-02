using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UiControler : MonoBehaviour
{
    public LoseUI LoseUI;
    public WinUI WinUI;
    public GameManager GameManager;
    public TimerUI TimerUI;
    public ScoreUI ScoreUI;
    public void EndGame(bool Die)
    {
        LoseUI.gameObject.SetActive(true);
        if (Die) { 
            LoseUI.SetScore(ScoreUI.scoreMax - ScoreUI.score);
        } else
        {
            WinUI.SetScore(ScoreUI.score);
        }
    }
    public void RestartGame()
    {
        GameManager.RestartGame();
        
    }
    public void AddTime(float time)
    {
        TimerUI.SetTime(time);
        ScoreUI.SetScore(time);
    }
    public void SwitchSpeed(int speed)
    {
        ScoreUI.SwitchSpeed(speed);
    }
}
