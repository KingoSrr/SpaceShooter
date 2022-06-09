using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    public Text WaveTxt;
    void Start()
    {
        WaveTxt.text = "wave";
    }
    void Update()
    {
        if(RespawnEnemy.Wave !=0)
        {
            WaveTxt.text = RespawnEnemy.Wave.ToString();
        }
    }
}