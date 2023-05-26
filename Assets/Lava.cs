using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float EasySpeed = 5f;
    public float NormalSpeed = 10f;
    public float HardSpeed = 20f;
    private float speed;
    private bool RunNow = false;
    void Start()
    {
        speed = EasySpeed / 10;
    }
    void Update()
    {
        if (RunNow)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
    public void StartRun()
    {
        RunNow = true;
    }
    public void SwitchSpeed(int i)
    {
        if (!RunNow)
        {
            switch (i)
            {
                case 1:
                    speed = EasySpeed / 10;
                    break;
                case 2:
                    speed = NormalSpeed / 10;
                    break;
                case 3:
                    speed = HardSpeed / 10;
                    break;
            }
        }
    }
}
