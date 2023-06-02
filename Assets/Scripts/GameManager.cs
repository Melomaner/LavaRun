using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirstPersonController FirstPersonController;
    public UiControler UiControler;
    public Lava lava;
    public timer Timer;
    public GameObject ButtonDiff;
    
    public void EndGame(bool Die)
    {
        UiControler.EndGame(Die);
        FirstPersonController.enabled = false;
    }
    public void StartGame()
    {
        lava.StartRun();
        Timer._isPlaying = true;
        ButtonDiff.SetActive(false);
    }
    public void RestartGame()
    {
        FirstPersonController.RestartCharacter();
    }
    public void FinishGame()
    {
        EndGame(false);
        FirstPersonController.SwitchCursoreInput(false);
    }
    public void SwitchSpeed(int speed)
    {
        lava.SwitchSpeed(speed);
        UiControler.SwitchSpeed(speed);
    }
}
