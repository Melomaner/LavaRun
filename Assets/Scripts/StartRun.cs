using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartRun : MonoBehaviour
{
    public GameManager GameManager;
    public StartRun self;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.StartGame();
            self.gameObject.SetActive(false);
        }
    }
}
