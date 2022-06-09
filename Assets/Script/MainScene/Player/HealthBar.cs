using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image _Health;
    public float CurrentHealth;
    public float MaxHealth = 4f;
    MovePlayer Player;
    void Start() 
    {
        _Health = GetComponent<Image>();
    }
    void Update()
    {
        CurrentHealth = MovePlayer.Health;
        _Health.fillAmount = CurrentHealth / MaxHealth;
    }
}
