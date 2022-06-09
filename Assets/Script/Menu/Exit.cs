using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    public int _ScoreForSave;
    void Start()
    {
        _ScoreForSave = Score.ScoreCount;
    }
    public void ExitBtn()
    {
        if(Sound.SoundMode == true)
        {
            GameObject BtnClick = GameObject.FindGameObjectWithTag("BtnClick");
            AudioSource AS = BtnClick.GetComponent<AudioSource>();
            AS.Play();
        }

        string key = "Score";        
        if(_ScoreForSave > PlayerPrefs.GetInt(key))
        {
            PlayerPrefs.SetInt(key, this._ScoreForSave);
            PlayerPrefs.Save();
            Debug.Log("Saving Successful");
        }
        SceneManager.LoadScene("MainMenu");
    }
}
