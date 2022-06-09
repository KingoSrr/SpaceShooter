using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootPlayer : MonoBehaviour
{
    public static float CountBullet;
    public GameObject Bullet;
    public Transform BulletArea;
    private void Start() 
    {
        CountBullet = 5f;
        if(Sound.SoundMode == true)
        {
            AudioSource AS = Bullet.GetComponent<AudioSource>();
            AS.playOnAwake = true;
        }     
        if(Sound.SoundMode == false)
        {
            AudioSource AS = Bullet.GetComponent<AudioSource>();
            AS.playOnAwake = false;
        }
        InvokeRepeating("Shoot", 1f, 0.7f);    
    }
    void Shoot()
    {
        if(CountBullet>0)
        {
            CountBullet--;
            Destroy(Instantiate (Bullet, BulletArea.transform.position, Quaternion.identity), 1.5f);
        }
    }
}
