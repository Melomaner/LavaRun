using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    private float _timer = 0;
    private bool _isRun = false;
    public UiControler UiControler;
    // Start is called before the first frame update
    void Update()
    {
        if (_isRun)
        {
            _timer += Time.deltaTime;
            UiControler.TimerUI.SetTime(_timer); 
        }
    }
    public void _Start()
    {
        _isRun = true;
    }
    public void Pause()
    {
        _isRun = false;
    }
    public void _Reset()
    {
        _isRun = false;
        _timer = 0;
    }
    public float GetTime()
    {
        return _timer;
    }
}
