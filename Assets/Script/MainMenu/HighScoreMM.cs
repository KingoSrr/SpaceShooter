using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMM : MonoBehaviour
{
    public Text HighScoreMMTxt;     
    public int GetScore;
    
    void Start()
    {
       Load();
    }  
    void Update()
    {
        HighScoreMMTxt.text = "HIGH SCORE " + GetScore;
    }
    private void Load() 
    {
        string key = "Score";
        if (PlayerPrefs.HasKey(key)) 
        {
            this.GetScore = PlayerPrefs.GetInt(key);
        }
    }
}
