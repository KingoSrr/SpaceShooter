using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBoss : MonoBehaviour
{
    public GameObject Bomb;
    public Transform[] BulletArea;
    public int RandowRangeOne = 4;
    void Start() 
    {
        InvokeRepeating("Shoot", 1.5f, 0.5f); 
        if(Sound.SoundMode == true)
        {
            AudioSource AS = Bomb.GetComponent<AudioSource>();
            AS.playOnAwake = true;
        }
        if(Sound.SoundMode == false)
        {
            AudioSource AS = Bomb.GetComponent<AudioSource>();
            AS.playOnAwake = false;
        } 
    }
    void Shoot()
    {
        int One = Random.Range(0, RandowRangeOne);
        if( One != 1)
        {
            Destroy(Instantiate (Bomb, BulletArea[Random.Range(0, BulletArea.Length)].transform.position, Quaternion.identity), 1.3f);
        }
    }
}
