using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class TeleportActivator : MonoBehaviour
{
    public Teleport teleport;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teleport.ActivateTeleports();
        }
    }
}
