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
    public void EndGame(bool Die)
    {
        LoseUI.gameObject.SetActive(true);
        if (Die) {
            LoseUI.SetScore(GameManager.Score.GetScore());
        } else
        {
            WinUI.SetScore(GameManager.Score.GetScore());
        }
    }
    public void RestartGame()
    {
        GameManager.RestartGame();
        
    }
    public void SwitchSpeed(int speed)
    {
        GameManager.Score.SwitchSpeed(speed);
    }
}
