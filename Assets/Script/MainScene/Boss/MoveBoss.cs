using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : MonoBehaviour
{
    public static int Health;
    private UnityEngine.Object Explosion;
    private UnityEngine.Object HealingPlayer;
    void Start()
    {
        Health = 15;
        Explosion = Resources.Load("Explosion");
        HealingPlayer = Resources.Load("HealingPlayer");
    }
    private void OnCollisionEnter2D(Collision2D col) {     
        if(col.collider.tag == "Bullet"){
            Destroy(col.gameObject);
            Health --;
            if(Vibration.VibrationMode == true)
            {
                AndroidAPI.Vibration(15);
            }
            if(Health == 0)
            {
                Score.ScoreCount += 20;
                AudioSource AS = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<AudioSource>();
                AS.Play();
                GameObject ExplosionRef = (GameObject)Instantiate(Explosion);
                ExplosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                GameObject HealingPlayerRef = (GameObject)Instantiate(HealingPlayer);
                HealingPlayerRef.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
                MovePlayer.Health++;
                Destroy(gameObject);
            }                       
        }        
    }
}
