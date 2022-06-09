using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    private Image Health;
    public float CurrentHealth;
    public float MaxHealth = 15f;
    MovePlayer Player;
    void Start() 
    {
        Health = GetComponent<Image>();
    }
    void Update()
    {
        CurrentHealth = MoveBoss.Health;
        Health.fillAmount = CurrentHealth / MaxHealth;
    }
}
