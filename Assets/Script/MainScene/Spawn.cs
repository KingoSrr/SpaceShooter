using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject[] EnemyPref;
    public GameObject[] SpawnEnemy;
    public GameObject PlayerPref;
    public GameObject BossPref;
    public GameObject BossSpawn;
    public GameObject SpawnPlayer;
    public GameObject MenuBtn;
    public GameObject ScoreTxt;
    public GameObject BulletBar;
    public GameObject HealthBar;
    public GameObject BossBar;
    public GameObject ReloadBulletBtn;
    public GameObject GameOverPanel;
    public GameObject StatBar;
    void Start()
    { 
        Time.timeScale = 1;               
        MenuBtn.SetActive(true);
        StatBar.SetActive(true);
        ScoreTxt.SetActive(true);
        HealthBar.SetActive(true);
        BulletBar.SetActive(true);
        GameOverPanel.SetActive(false);
        ReloadBulletBtn.SetActive(false);
        Score.ScoreCount = 0;
        SpawnPlayerMethod();        
        SpawnEnemyMethod();   
        
        if(Sound.SoundMode == false)
        {
            GameObject BGAudio = GameObject.FindGameObjectWithTag("BGAudio");
            AudioSource ASBG = BGAudio.GetComponent<AudioSource>();
            ASBG.Pause();
        }     
    }
    public void SpawnPlayerMethod()
    {
        ShootPlayer.CountBullet = 5f;
        Instantiate(PlayerPref, SpawnPlayer.transform.position, Quaternion.identity);
    }
    public void SpawnEnemyMethod()
    {
        for (int i = 0; i < 8; i++)
        {            
            GameObject Enemy = Instantiate(EnemyPref[Random.Range(0, EnemyPref.Length)], SpawnEnemy[i].transform.position, Quaternion.identity);
            Enemy.transform.position = new Vector3(SpawnEnemy[i].transform.position.x, SpawnEnemy[i].transform.position.y, 0);
        }
    }
    public void SpawnBossMethod()
    {
        GameObject Boss = Instantiate(BossPref);
        Boss.transform.position = BossSpawn.transform.position;
    }
}
