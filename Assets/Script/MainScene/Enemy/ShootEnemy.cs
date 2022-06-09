using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject BulletEnemy;
    public Transform BulletArea;
    void Start() 
    {
        if(Sound.SoundMode == true)
        {
            AudioSource AS = BulletEnemy.GetComponent<AudioSource>();
            AS.playOnAwake = true;
        }     
        if(Sound.SoundMode == false)
        {
            AudioSource AS = BulletEnemy.GetComponent<AudioSource>();
            AS.playOnAwake = false;
        }
        InvokeRepeating("Shoot", 1.5f, 0.5f); 
    }
    void Shoot()
    {
        int One = Random.Range(0, 3);
        int Two = Random.Range(0, 3);
        if( One == 1 && Two == 1)
        {
            Destroy(Instantiate (BulletEnemy, BulletArea.transform.position,Quaternion.identity), 2f);
        }
    }
}
