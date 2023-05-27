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
    private void Start()
    {
        FirstPersonController.IDie.AddListener(EndGame);
    }
    private void EndGame()
    {
        UiControler.EndGame();
        FirstPersonController.enabled = false;
    }
    public void StartGame()
    {
        lava.StartRun();
    }
    public void RestartGame()
    {
        FirstPersonController.RestartCharacter();
    }
}
