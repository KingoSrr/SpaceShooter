using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static int _Minute = 0;
    public static int _Second = 0;
    public Text TimerTxt;
    void Start()
    {
        _Minute = 0;
        _Second = 0;
        TimerTxt.text = _Minute.ToString("D2") + " : " + _Second.ToString("D2");
        InvokeRepeating("TimerValue", 0f, 1f);
    }
    void TimerValue()
    {
        if(_Second == 59)
        {
            _Minute++;
            _Second =-1;
        }
        _Second++;
        TimerTxt.text = _Minute.ToString("D2") + " : " + _Second.ToString("D2");
    }
}
