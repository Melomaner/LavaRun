using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirstPersonController FirstPersonController;
    public UiControler UiControler;
    public Lava lava;
    public timer Timer;
    public ButtonDiff ButtonDiff;
    public Score Score;
    [SerializeField] private SaveSystem SaveSystem; 
    public void EndGame(bool Die)
    {
        FirstPersonController.SwitchCursoreInput(false);
        Timer.Pause();
        Score.MathScore(Timer.GetTime(), Die);
        //SaveSystem.SaveFloat(Score.SaveKey,Score.GetScore());
       
        UiControler.EndGame(Die);
        FirstPersonController.enabled = false;
    }
    public void StartGame()
    {
        //Score.SetScore(SaveSystem.LoadFloat(Score.SaveKey));

        lava.StartRun();
        Score.SwitchSpeed(lava.GetSpeedID(), lava.GetSpeed());
        Timer._Start();
        ButtonDiff.gameObject.SetActive(false);
    }
    public void RestartGame()
    {
        FirstPersonController.RestartCharacter();
    }
    public void FinishGame()
    {
        EndGame(false);
    }
    public void SwitchSpeed(int SpeedID)
    {
        lava.SwitchSpeed(SpeedID);
    }
   /* private void Save()
    {
        PlayerPrefs.SetFloat(Score.GetScore());
    }
    private void Load()
    {
        Score.SetScore(PlayerPrefs.getFloat("Score",Score.GetScore());
    }*/
}
