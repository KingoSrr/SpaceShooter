using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    public GameObject TargetOgject;
    private Spawn _Spawn;
    public GameObject BossBar;
    public int _NumForSpawnBoss;
    public static int Wave;
    void Start()
    {
        Wave = 0;
        _NumForSpawnBoss = 0;
        _Spawn = TargetOgject.GetComponent<Spawn>();
    }
    void Update()
    {
        GameObject[] CountEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] BossCheck = GameObject.FindGameObjectsWithTag("Boss");
        if(CountEnemy.Length == 0 && BossCheck.Length == 0)
        {
            _NumForSpawnBoss++;
            Wave++;
            Debug.Log(_NumForSpawnBoss);
        }
        if(_NumForSpawnBoss < 3 && CountEnemy.Length == 0 && BossCheck.Length == 0)
        {            
            _Spawn.SpawnEnemyMethod();
            BossBar.SetActive(false);            
        }
        if(_NumForSpawnBoss == 3 && CountEnemy.Length == 0 && BossCheck.Length == 0) 
        {
            _Spawn.SpawnBossMethod();
            BossBar.SetActive(true);
            _NumForSpawnBoss = -1;
        }
    }
}
