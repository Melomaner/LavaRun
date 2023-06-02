using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject TelepotrIn;
    public GameObject PointTeleport;
    public GameObject teleportOut;
    public BoxCollider OnButton;
    private Vector3 teleportPosition = new();
    private bool Telepor = false;

    // Start is called before the first frame update
    void Start()
    {
        if (PointTeleport != null) { 
        teleportPosition = PointTeleport.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void TeleportTo(GameObject player)
    {
        if (player.TryGetComponent<FirstPersonController>(out var FPC))
        {
            if (!Telepor)
            {
                    FPC.enabled = false;
                    Telepor = true;
                    player.transform.position = teleportPosition;
            }
            else
            {
                    FPC.enabled = true;
                    Telepor = false;
            }
        }
    }
    public void TeleportOut(GameObject player)
    {
        if (Telepor)
        {
            FirstPersonController FPC = player.GetComponent<FirstPersonController>();
            if (FPC != null)
            {
                FPC.enabled = true;
                Telepor = false;
            }
        }
    }
    public void ActivateTeleports() {
        TelepotrIn.SetActive(true);
        teleportOut.SetActive(true);
    }
}
