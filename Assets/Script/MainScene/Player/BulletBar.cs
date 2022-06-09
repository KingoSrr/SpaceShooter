using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletBar : MonoBehaviour
{
    private Image Bullet;
    public float CurrentBullet;
    public float MaxBullet = 5f;
    MovePlayer Player;
    void Start() 
    {
        CurrentBullet = ShootPlayer.CountBullet;
        Bullet = GetComponent<Image>();
    }
    void Update()
    {
        CurrentBullet = ShootPlayer.CountBullet;
        Bullet.fillAmount = CurrentBullet / MaxBullet;
    }
}
