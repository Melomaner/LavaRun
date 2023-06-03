using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private GameManager GameManager;
    public void SaveFloat(string key,float Value)
    {
        PlayerPrefs.SetFloat(key, Value);
    }
    public float LoadFloat(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }
}