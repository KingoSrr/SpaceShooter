using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreTxt;
    public Text YourScoreTxt;
    public static int ScoreCount;
    public int YourScore;
    void Start()
    {
        ScoreCount = 0;
        ScoreTxt.text = "Score";
    }
    void Update()
    {
        if(ScoreCount != 0)
        {
            ScoreTxt.text = ScoreCount.ToString();
        }
        YourScoreTxt.text = "YOUR SCORE " + ScoreCount.ToString();
    }
}
