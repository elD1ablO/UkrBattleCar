using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI enemiesKilledText;

    int enemiesKilled = 0;
    

        
    void Awake()
    {
        EnemyHealth.OnEnemyKilled += EnemyHealth_OnEnemyKilled;
    }

    void Update()
    {
        enemiesKilledText.text = enemiesKilled.ToString();
    }

    void EnemyHealth_OnEnemyKilled(object sender, EventArgs e)
    {
        enemiesKilled++;
    }
}
