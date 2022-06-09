using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartBtn()
    {
        if(Sound.SoundMode == true)
        {
            GameObject BtnClick = GameObject.FindGameObjectWithTag("BtnClick");
            AudioSource AS = BtnClick.GetComponent<AudioSource>();
            AS.Play();
        }
        SceneManager.LoadScene("MainScene");
    }
}
