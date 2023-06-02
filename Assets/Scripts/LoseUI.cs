using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    public UiControler UiControler;
    public TextMeshProUGUI ScoreTMP;
    public void Restart()
    {
        UiControler.RestartGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SetScore(float score)
    {
        ScoreTMP.text = ""+score;
    }

}
