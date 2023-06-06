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
        
        if (Die) {
            LoseUI.gameObject.SetActive(true);
            LoseUI.SetScore(GameManager.Score.GetScore());
        } else
        {
            WinUI.gameObject.SetActive(true);
            WinUI.SetScore(GameManager.Score.GetScore());
        }
    }
    public void RestartGame()
    {
        GameManager.RestartGame();
        
    }
}
