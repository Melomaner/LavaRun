using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOut : MonoBehaviour
{
    public Teleport teleport;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teleport.TeleportTo(other.gameObject);
        }
    }
}
