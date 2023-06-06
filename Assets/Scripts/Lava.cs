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
    private int speedID;
    private bool RunNow = false;
    public enum ObjectType { Easy, Normal, Hard };
    [SerializeField]
    private ObjectType StartSpeed = ObjectType.Easy;
    void Start()
    {
        switch (StartSpeed)
        {
            case ObjectType.Easy:
                speed = EasySpeed / 10;
                speedID = 1;
                break;
            case ObjectType.Normal:
                speed = NormalSpeed / 10;
                speedID = 2;
                break;
            case ObjectType.Hard:
                speed = HardSpeed / 10;
                speedID = 3;
                break;
        }
    }
    void FixedUpdate()
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
            speedID = i;
        }
    }
    public int GetSpeedID()
    {
        return speedID;
    }
    public float GetSpeed()
    {
        return speed;
    }
}
