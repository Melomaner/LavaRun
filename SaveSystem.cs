using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private GameManager GameManager;
    private void SaveFloat(string key,float Value)
    {
        PlayerPrefs.SetFloat(key, Value);
    }
    private void Load()
    {
        //Score.SetScore(PlayerPrefs.getFloat("Score", Score.GetScore());
    }
}