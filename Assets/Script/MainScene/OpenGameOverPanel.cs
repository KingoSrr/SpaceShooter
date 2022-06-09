using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGameOverPanel : MonoBehaviour
{
    public GameObject MenuBtn;
    public GameObject BulletBar;
    public GameObject HealthtBar;
    public GameObject ReloadBulletBtn;
    public GameObject GameOverPanel;
    public GameObject StatBar;
    public GameObject BossHealthBar;
    public void OpenPanel()
    {

        GameObject BGAudio = GameObject.FindGameObjectWithTag("BGAudio");
        AudioSource ASBG = BGAudio.GetComponent<AudioSource>();
        ASBG.Pause();         
        if(Sound.SoundMode == false)
        {
            AudioSource ASGOP = GameOverPanel.GetComponent<AudioSource>();
            ASGOP.enabled = false;
        }  
        MenuBtn.SetActive(false);
        StatBar.SetActive(false);
        BulletBar.SetActive(false);
        HealthtBar.SetActive(false);
        BossHealthBar.SetActive(false);
        GameOverPanel.SetActive(true);
        ReloadBulletBtn.SetActive(false);
    }
}
