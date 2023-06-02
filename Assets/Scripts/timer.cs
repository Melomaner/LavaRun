using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    float _timer = 0;
    public bool _isPlaying = false;
    public UiControler UiControler;
    // Start is called before the first frame update
    void Update()
    {
        if (_isPlaying)
        {
            _timer += Time.deltaTime;
            UiControler.AddTime(_timer);
        }
    }
}
