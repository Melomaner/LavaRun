using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDiff : MonoBehaviour
{
    public Push easy;
    public Push medium;
    public Push Hard;
    public GameManager gameManager;
    public int speed = 1;

    public void Push(Push button)
    {
        if (button == easy)
        {
            easy.ButtonOn();
            medium.ButtonOff();
            Hard.ButtonOff();
            speed = 1;
            gameManager.SwitchSpeed(speed);

        } 
        else if (button == medium)
        {
            easy.ButtonOff();
            medium.ButtonOn();
            Hard.ButtonOff();
            speed = 2;
            gameManager.SwitchSpeed(speed);
        }
        else if (button == Hard)
        {
            easy.ButtonOff();
            medium.ButtonOff();
            Hard.ButtonOn();
            speed = 3;
            gameManager.SwitchSpeed(speed);
        }
    }
}


