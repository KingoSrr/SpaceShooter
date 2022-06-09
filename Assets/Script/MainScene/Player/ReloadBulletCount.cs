using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadBulletCount : MonoBehaviour
{
    public GameObject ReloadBulletBtn;
    public AudioClip ReloadAudio;
    public AudioSource AS;
    void Update()
    {
        if(ShootPlayer.CountBullet <= 0)
        {
            ReloadBulletBtn.SetActive(true);
        }
    }
    public void Reload()
    {
        if(Sound.SoundMode == true)
        {
            AS.PlayOneShot(ReloadAudio);
        }        
        Invoke("ClickAudio", 0.1f);        
    }
    public void ClickAudio()
    {
        ShootPlayer.CountBullet = 5;
        ReloadBulletBtn.SetActive(false);
    }
}
