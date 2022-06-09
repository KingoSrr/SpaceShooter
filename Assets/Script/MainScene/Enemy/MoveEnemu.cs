using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemu : MonoBehaviour
{
    public int Health = 2;
    private UnityEngine.Object Explosion;
    void Start()
    {
        Explosion = Resources.Load("Explosion");
    }
    private void OnCollisionEnter2D(Collision2D col) {     
        if(col.collider.tag == "Bullet"){
            Destroy(col.gameObject);
            Health--;
            if(Vibration.VibrationMode == true)
            {
                AndroidAPI.Vibration(15);
            }            
            if(Health <= 0)
            {
                Score.ScoreCount++;
                GameObject ExplosionRef = (GameObject)Instantiate(Explosion);
                ExplosionRef.transform.position = transform.position;
                Destroy(gameObject);
            }                       
        }        
    }
}
