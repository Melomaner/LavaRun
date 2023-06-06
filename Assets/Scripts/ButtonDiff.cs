using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDiff : MonoBehaviour
{
    public Push easy;
    public Push medium;
    public Push Hard;
    public GameManager gameManager;
    public int easyID = 1;
    public int mediumID = 2;
    public int HardID = 3;

    public void Push(Push button)
    {
        if (button == easy)
        {
            easy.ButtonOn();
            medium.ButtonOff();
            Hard.ButtonOff();
            gameManager.SwitchSpeed(easyID);

        } 
        else if (button == medium)
        {
            easy.ButtonOff();
            medium.ButtonOn();
            Hard.ButtonOff();
            gameManager.SwitchSpeed(mediumID);
        }
        else if (button == Hard)
        {
            easy.ButtonOff();
            medium.ButtonOff();
            Hard.ButtonOn();
            gameManager.SwitchSpeed(HardID);
        }
    }
}


