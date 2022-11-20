using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] Sprite fullHP;
    [SerializeField] Sprite midHP;
    [SerializeField] Sprite lowHP;
    
    [SerializeField] Image HPIndication;

    [SerializeField] TextMeshProUGUI enemiesKilledText;

    

    PlayerHealth playerHP;

    int enemiesKilled = 0;
    int currentHP;


    void Awake()
    {
        EnemyHealth.OnEnemyKilled += EnemyHealth_OnEnemyKilled;
        PlayerHealth.OnDamageTaken += PlayerHealth_OnDamageTaken;
        playerHP = FindObjectOfType<PlayerHealth>();
    }


    void Start()
    {
        currentHP = playerHP.GetPlayerHealth(); 
    }

    void Update()
    {
        enemiesKilledText.text = enemiesKilled.ToString();

        if (currentHP > 60) HPIndication.sprite = fullHP;
        if (currentHP <= 60 && currentHP > 30) HPIndication.sprite = midHP;
        if (currentHP <= 30) HPIndication.sprite = lowHP;
    }
    void PlayerHealth_OnDamageTaken(object sender, EventArgs e)
    {        
        currentHP = playerHP.GetPlayerHealth();
           

        Debug.Log(currentHP);
    }

    void EnemyHealth_OnEnemyKilled(object sender, EventArgs e)
    {
        enemiesKilled++;
    }


}
