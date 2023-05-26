using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public ButtonDiff ButtonDiff;
    public Push self;
    public Material materialOn;
    public Material materialOff;
    public bool Activate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ButtonDiff.Push(self);
            Debug.Log("Игрок находится в позиции " + self);
        }
    }
    public void ButtonOn()
    {
        self.gameObject.GetComponent<Renderer>().material = materialOn;
        Activate = true;
    }
    public void ButtonOff()
    {
        self.gameObject.GetComponent<Renderer>().material = materialOff;
        Activate = false;
    }
}

