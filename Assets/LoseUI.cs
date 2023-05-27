using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    public UiControler UiControler;
    public void Restart()
    {
        UiControler.RestartGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
