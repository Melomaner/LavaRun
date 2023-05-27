using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UiControler : MonoBehaviour
{
    public LoseUI LoseUI;
    public GameManager GameManager;
   
    public void EndGame()
    {
        LoseUI.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        GameManager.RestartGame(); 
    }
}
