using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMM : MonoBehaviour
{
    public void StartBtn()
    {
        if(Sound.SoundMode == true)
        {
            AudioSource SoundBtn = GetComponent<AudioSource>();
            SoundBtn.Play();
        }
        SceneManager.LoadScene("MainScene");
    }
}
