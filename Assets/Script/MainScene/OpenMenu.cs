using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject MenuBtn;
    public GameObject Score;
    public GameObject BulletBar;
    public GameObject HealthtBar;
    public GameObject ReloadBulletBtn;
    public GameObject BossHealthBar;
    public GameObject StatBar;
    public void Open()
    {
        if(Sound.SoundMode == true)
        {
            GameObject BtnClick = GameObject.FindGameObjectWithTag("BtnClick");
            AudioSource ASClick = BtnClick.GetComponent<AudioSource>();
            ASClick.Play();

            GameObject BGAudio = GameObject.FindGameObjectWithTag("BGAudio");
            AudioSource ASBG = BGAudio.GetComponent<AudioSource>();
            ASBG.Pause();
        }
        
        MenuBtn.SetActive(false);
        StatBar.SetActive(false);
        BossHealthBar.SetActive(false);
        MenuPanel.SetActive(true);
        Score.SetActive(false);
        BulletBar.SetActive(false);
        HealthtBar.SetActive(false);
        ReloadBulletBtn.SetActive(false);
        Time.timeScale = 0;               
    }
}
