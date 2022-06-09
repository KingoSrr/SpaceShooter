using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject MenuBtn;
    public GameObject Score;
    public GameObject BulletBar;
    public GameObject HealthtBar;
    public GameObject ReloadBulletBtn;
    public GameObject BossHealthBar;
    public GameObject StatBar;
    public void PlayBtn()
    {
        if(Sound.SoundMode == true)
        {
            GameObject BtnClick = GameObject.FindGameObjectWithTag("BtnClick");
            AudioSource ASClick = BtnClick.GetComponent<AudioSource>();
            ASClick.Play();

            GameObject BGAudio = GameObject.FindGameObjectWithTag("BGAudio");
            AudioSource ASBG = BGAudio.GetComponent<AudioSource>();
            ASBG.Play();
        }       
        
        MenuPanel.SetActive(false);
        if(GameObject.FindGameObjectsWithTag("Boss").Length != 0)
        {
            BossHealthBar.SetActive(true);  
        }
        MenuBtn.SetActive(true);
        StatBar.SetActive(true);
        BulletBar.SetActive(true);
        HealthtBar.SetActive(true);
        Score.SetActive(true);
        if(ShootPlayer.CountBullet <=0)
        {
            ReloadBulletBtn.SetActive(true);
        }
        Time.timeScale = 1;
    }
}
