using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private GameObject _TargetObject;
    private OpenGameOverPanel _OGOP;
    public static int Health;
    private Material _MatBlink;
    public static Material _MatDefault;
    public static SpriteRenderer _Sprite;
    private int _ScoreForSave;
    private int _WaveForSave;
    private int _MinuteForSave;
    private int _SecondForSave;
    private Rigidbody2D _rb;
    private GameObject _RightLim;
    private GameObject _LeftLim;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Health = 4;
        _TargetObject = GameObject.FindGameObjectWithTag("MainCamera");
        _OGOP = _TargetObject.GetComponent<OpenGameOverPanel>();
        _Sprite = GetComponent<SpriteRenderer>();
        _MatBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        _MatDefault = _Sprite.material;
        _RightLim = GameObject.FindGameObjectWithTag("RightLim");
        _LeftLim = GameObject.FindGameObjectWithTag("LeftLim");
    }
    void Update()
    {
        _ScoreForSave = Score.ScoreCount;
        _WaveForSave = RespawnEnemy.Wave;
        _MinuteForSave = Timer._Minute;
        _SecondForSave = Timer._Second;

        if (transform.position.x > _RightLim.transform.position.x - 0.5f)
        {
            transform.position = new Vector3(_RightLim.transform.position.x - 0.5f, transform.position.y, 0);
        }
        if (transform.position.x < _LeftLim.transform.position.x + 0.5f)
        {
            transform.position = new Vector3(_LeftLim.transform.position.x + 0.5f, transform.position.y, 0);
        }

        float Speed = 12f;
        Vector3 acceleration = Input.acceleration;
        _rb.velocity = new Vector3(acceleration.x * Speed, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.tag=="BulletEnemy" || col.tag=="Bomb")
        {
            Destroy(col.gameObject);
            Health--;
            _Sprite.material = _MatBlink;
            if(Health == 0)
            {          
                //Destroy(gameObject);                
                _OGOP.OpenPanel();
                Time.timeScale=0;
                SaveGame();
            }    
            else
            {
                Invoke("ResetMaterial", 0.05f);
            }                   
        } 
    }
    void ResetMaterial()
    {
        _Sprite.material = _MatDefault;
    }
    void SaveGame()
    {
        string keyScore = "Score";        
        if(_ScoreForSave > PlayerPrefs.GetInt(keyScore))
        {
            PlayerPrefs.SetInt(keyScore, this._ScoreForSave);
            PlayerPrefs.Save();
            Debug.Log("Saving Successful");
        }

        string keyScoreAds = "ScoreAds";
        PlayerPrefs.SetInt(keyScoreAds, this._ScoreForSave);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");

        string keyWave = "Wave";
        PlayerPrefs.SetInt(keyWave, RespawnEnemy.Wave);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");

        string keyMinute = "Minute";
        PlayerPrefs.SetInt(keyMinute, Timer._Minute);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");

        string keySecond = "Second";
        PlayerPrefs.SetInt(keySecond, Timer._Second);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");
    }
}