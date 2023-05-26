using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDiff : MonoBehaviour
{
    public Push easy;
    public Push medium;
    public Push Hard;
    public Lava lava;

    public void Push(Push button)
    {
        if (button == easy)
        {
            easy.ButtonOn();
            medium.ButtonOff();
            Hard.ButtonOff();
            lava.SwitchSpeed(1);
        } 
        else if (button == medium)
        {
            easy.ButtonOff();
            medium.ButtonOn();
            Hard.ButtonOff();
            lava.SwitchSpeed(2);
        }
        else if (button == Hard)
        {
            easy.ButtonOff();
            medium.ButtonOff();
            Hard.ButtonOn();
            lava.SwitchSpeed(3);
        }
    }
}


