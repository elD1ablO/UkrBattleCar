using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using RengeGames.HealthBars;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI enemiesKilledText;

    [SerializeField] RadialSegmentedHealthBar healthBar;

    PlayerHealth playerHP;

    int enemiesKilled = 0;
    int currentHP;
    

        
    void Awake()
    {
        EnemyHealth.OnEnemyKilled += EnemyHealth_OnEnemyKilled;
        PlayerHealth.OnDamageTaken += PlayerHealth_OnDamageTaken;
        //playerHP = FindObjectOfType<PlayerHealth>();
    }

    

    void Start()
    {
        currentHP = playerHP.GetPlayerHealth(); 
    }

    void Update()
    {
        enemiesKilledText.text = enemiesKilled.ToString();

        healthBar.AddRemoveSegments(-1);
    }
    void PlayerHealth_OnDamageTaken(object sender, EventArgs e)
    {

        currentHP = playerHP.GetPlayerHealth();
    }

    void EnemyHealth_OnEnemyKilled(object sender, EventArgs e)
    {
        enemiesKilled++;
    }


}
